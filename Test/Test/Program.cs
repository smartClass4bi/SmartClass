using System;
using System.Data.SqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hallo i bin do");
            Console.WriteLine("SPISCHL is in");
            Console.WriteLine("I owat nix is do");
            Console.WriteLine("Da Rob is ah do und duat nix");
            Console.WriteLine("Hallo Prammer is dooo");
            DataBase();
        }

        static void DataBase()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = smartclass4bi.database.windows.net; Initial Catalog=SmartClass; User Id=adminadmin;Password=Februar2020";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            Console.WriteLine("hoffentli koa crahs");
            
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql, Output = "";

            sql = "Insert into dbo.Class(Classname, StudentCount) Values(\'4BI\', 32);";
                     
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            sql = "Select * from dbo.Class;";

            command = new SqlCommand(sql, cnn);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + dataReader.GetValue(1);
            }
            cnn.Close();
            Console.WriteLine(Output);
            Console.ReadKey();
        }
    }
}
