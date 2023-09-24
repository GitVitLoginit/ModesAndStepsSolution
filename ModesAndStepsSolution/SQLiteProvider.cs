using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution
{
    internal class SQLiteProvider : IDisposable
    {
    
        private SQLiteConnection sqliteConnection;

        private string dbFileName = "MyDatabase.sqlite";
        private string connectionString = "Data Source=MyDatabase.sqlite;Version=3;Compress=True;";
        public SQLiteProvider() 
        {
            bool dbExisted = true;
            if (!File.Exists(dbFileName))
            {
                dbExisted = false;
                SQLiteConnection.CreateFile(dbFileName);             
            }


            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();



            if (!dbExisted)
            {
                FirstTablesInitialization();
            }

/*
            RunQuery(@"INSERT INTO Modes
            (Name, MaxBottleNumber, MaxUsedTips) VALUES('Third Mode', 2332, 1324238); ");


            RunQuery(@"INSERT INTO Steps
            (ModeId, Timer, Destination,Speed,Type,Volume) VALUES(1, 'some time1', 'some destination1', 'some speed1', 'some type1', 'some volume1'); ");

            RunQuery(@"INSERT INTO Steps
            (ModeId, Timer, Destination,Speed,Type,Volume) VALUES(5, 'some time1', 'some destination1', 'some speed1', 'some type1', 'some volume1'); ");

           
            ReadQuery(@"SELECT * FROM Steps");
            */


        }

        private void FirstTablesInitialization()
        {
            string query = @"CREATE TABLE Modes
               (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, Name TEXT, MaxBottleNumber INTEGER, MaxUsedTips INTEGER)";

            RunQuery(query);

            query= @"CREATE TABLE Steps
               (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, ModeId REFERENCES Modes(ID)  ON DELETE CASCADE ON UPDATE CASCADE , Timer TEXT, Destination TEXT, Speed TEXT, Type TEXT, Volume TEXT)";

            RunQuery(query);

        }

        public DataTable? ReadQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable? dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                cmd = sqliteConnection.CreateCommand();
                cmd.CommandText = query;  
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); 
            }
            catch 
            {
                dt = null;
            }
         
            return dt;
        }


        public void RunQuery(string query)
        {

            SQLiteCommand sqlite_cmd;

            try
            {
                sqlite_cmd = sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = query;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong while running query:"+ "query./r" + ex.Message);
            }
       

        }


        public void Dispose()
        {
            sqliteConnection.Close();
        }
    }
}
