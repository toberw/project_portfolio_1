using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

using System.Diagnostics;

namespace weatherScraper
{
    class Program
    {
        MySqlConnection _con = null;
        static void Main(string[] args)
        {

            decimal temp = 0;
            decimal pressure = 0;
            int humidity = 0;
            string currentCity = "";
            

            Program instance = new Program();

            //start connection and connect
            instance._con = new MySqlConnection();
            instance.Connect();

            bool programRunning = true;
            bool found = false;

            while (programRunning)
            {
                if (found)
                {
                    Console.WriteLine("\nEnter the name of another city to find or type x to exit: ");
                    found = false; 
                } else
                {
                    Console.WriteLine("Welcome to Weather Scraper!");
                    Console.WriteLine("Please enter the name of the city you would like to find the weather for or press x to exit!");
                    Console.Write("\n\nEnter City: ");
                }


                string input = Console.ReadLine().ToLower();

                while (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please don't leave the name of the city blank! ");
                    Console.Write("\nEnter the name of the city and press return!\n\n" +
                        "Enter City: ");

                    input = Console.ReadLine().ToLower();
                }

                if (input == "x")
                {
                    programRunning = false;
                }
                else
                {
                    DataTable data = instance.QueryDB("SELECT city, temp, pressure, humidity FROM weather");
                    DataRowCollection rows = data.Rows;

                    //read from db and add each record of currentDVD to list DVD
                    foreach (DataRow row in rows)
                    {
                        currentCity = row["city"].ToString().ToLower();

                        string tmp;
                        tmp = row["temp"].ToString();
                        decimal.TryParse(tmp, out temp);
                        Debug.WriteLine($"{row["temp"].ToString()} Read and equals {temp}");

                        tmp = row["pressure"].ToString();
                        decimal.TryParse(tmp, out pressure);
                        Debug.WriteLine($"{row["pressure"].ToString()} Read and equals {pressure}");

                        tmp = row["humidity"].ToString();
                        int.TryParse(tmp, out humidity);
                        Debug.WriteLine($"{row["humidity"].ToString()} Read and equals {humidity}");

                        if (input == currentCity)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        Console.WriteLine($"CITY: {currentCity}\n" +
                            $"TEMPERATURE: {temp}\n" +
                            $"PRESSURE: {pressure}\n" +
                            $"HUMIDITY: {humidity}\n" +
                            $"");
                    } else if (!found)
                    {
                        Console.WriteLine($"{input} could not be found!");
                    }

                    Console.Write("Press any key to continue! ");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }

            //close connection 
            instance._con.Close();
        }

        void Connect()
        {
            BuildConString();
            
        }

        void BuildConString()
        {
            string ip = "";

            using(StreamReader sr = new StreamReader(@"C:\VFW\connect.txt"))
            {
                ip = sr.ReadLine();
            }

            string conString = $"Server={ip};";
            conString += "uid=dbsAdmin;";
            conString += "pwd=password;";
            conString += "database=sampleAPIData;";
            conString += "port=8889;";

            _con.ConnectionString = conString;
        }

        DataTable QueryDB(string query)
        {
            //Assign an adapter to pass query through our connection
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, _con);
            //predefine a DataTable datatype to store the data we plan on passing through
            DataTable data = new DataTable();

            //Tell the adapter what type of data you'd like to get back i.e. text
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(data);

            return data;
        }
    }
}
