using ModesAndStepsSolution.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution
{
    public class SQLiteProvider : IDisposable
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

                       */

          //  ReadQuery(@"SELECT * FROM Modes", new List<SqlCommandParameter>());
            


        }

        public void Dispose()
        {
            sqliteConnection.Close();

            GC.SuppressFinalize(this);
        }

        ~SQLiteProvider()
        {

            sqliteConnection.Close();
        }

        private void FirstTablesInitialization()
        {
            string query = @"CREATE TABLE Modes
               (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, Name TEXT, MaxBottleNumber INTEGER, MaxUsedTips INTEGER)";

            RunQuery(query, new List<SqlCommandParameter>());

            query= @"CREATE TABLE Steps
               (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, ModeId REFERENCES Modes(ID)  ON DELETE CASCADE ON UPDATE CASCADE , Timer TEXT, Destination TEXT, Speed TEXT, Type TEXT, Volume TEXT)";

            RunQuery(query, new List<SqlCommandParameter>());

            query = @"CREATE TABLE User
               (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT,  Login TEXT UNIQUE, Password TEXT)";

            RunQuery(query, new List<SqlCommandParameter>());


        }

        public DataTable? ReadQuery(string query, List<SqlCommandParameter> parameters)
        {
            SQLiteDataAdapter ad;
            DataTable? dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                cmd = sqliteConnection.CreateCommand();
                cmd.CommandText = query;
 
                //prevent from injection
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.ParameterName, par.Value);
                }

                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); 
            }
            catch 
            {
                dt = null;
            }
         
            return dt;
        }


        public void RunQuery(string query, List<SqlCommandParameter> parameters)
        {

            SQLiteCommand sqlite_cmd;

            try
            {
                sqlite_cmd = sqliteConnection.CreateCommand();
                sqlite_cmd.CommandText = query;
                //prevent from injection
                foreach (var par in parameters)
                {
                    sqlite_cmd.Parameters.AddWithValue(par.ParameterName, par.Value);
                }
                sqlite_cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong while running query:"+ "query./r" + ex.Message);
            }
       

        }


        public bool AddNewUser(string login, string passw)
        {
            try
            {
                //var query = @"INSERT INTO User
                //    (Login, Password) VALUES('" + login + @"', '" + HashPassword(passw) + @"');";

                var query = @"INSERT INTO User
                    (Login, Password) VALUES(@login,@password);";

                var parameters= new List<SqlCommandParameter>()
                {
                      new SqlCommandParameter("@login", login),
                      new SqlCommandParameter("@password", HashPassword(passw))
                };

                RunQuery(query, parameters);
            }
            catch
            {
                return false;
            }
            return true;
    
        }

        public bool Login(string login, string passw)
        {
            DataTable? findedUserData;
            try
            {

                //var query = @"SELECT * FROM User WHERE Login='"+ login+ @"' AND Password='"+HashPassword(passw)+@"';";
                var query = @"SELECT * FROM User WHERE Login=@login AND Password=@password;";

                findedUserData = ReadQuery(query, new List<SqlCommandParameter>()
                {
                      new SqlCommandParameter("@login", login),
                      new SqlCommandParameter("@password", HashPassword(passw))
                });
            }
            catch
            {
                return false;
            }

            if (findedUserData?.Rows.Count!= 0)
               return true;
            else
               return false;

        }

        public bool DeleteMode(int modeId)
        {
            try
            {
                RunQuery(@"DELETE FROM Modes WHERE ID = @modeId;", new List<SqlCommandParameter>()
            {
                new SqlCommandParameter()
                {
                    ParameterName = "@modeId",
                    Value= modeId
                }
            });
            }
            catch { return false; }
            return true;
  
        }

        public bool DeleteStep(int stepId)
        {
            try
            {
                RunQuery(@"DELETE FROM Steps WHERE ID = @stepId;", new List<SqlCommandParameter>()
            {
                new SqlCommandParameter()
                {
                    ParameterName = "@stepId",
                    Value= stepId
                }
            });
            }
            catch { return false; }
            return true;

        }

        public bool AddMode(Mode mode)
        {
            try
            {
                RunQuery(@"INSERT INTO Modes
                        (Name, MaxBottleNumber, MaxUsedTips) VALUES(@name, @maxBottleNumber, @maxUsedTips); ", new List<SqlCommandParameter>()
            {
                new SqlCommandParameter()
                {
                    ParameterName = "@name",
                    Value= mode.Name
                },
                 new SqlCommandParameter()
                {
                    ParameterName = "@maxBottleNumber",
                    Value= mode.MaxBottleNumber
                },
                  new SqlCommandParameter()
                {
                    ParameterName = "@maxUsedTips",
                    Value= mode.MaxUsedTips
                }
            });
            }
            catch { return false; }
            return true;

        }

        public bool AddStep(Step step)
        {
            try
            {
                //Timer TEXT, Destination TEXT, Speed TEXT, Type TEXT, Volume TEXT
                RunQuery(@"INSERT INTO Steps
                        (ModeId, Timer, Destination, Speed, Type, Volume) VALUES(@modeId, @timer, @destination, @speed, @type, @volume); ", new List<SqlCommandParameter>()
            {
                new SqlCommandParameter()
                {
                    ParameterName = "@modeId",
                    Value= step.ModeId
                },
                 new SqlCommandParameter()
                {
                    ParameterName = "@timer",
                    Value= step.Timer
                },
                  new SqlCommandParameter()
                {
                    ParameterName = "@destination",
                    Value= step.Destination
                }
                  ,
                new SqlCommandParameter()
                {
                    ParameterName = "@speed",
                    Value= step.Speed
                }
                  ,
                new SqlCommandParameter()
                {
                    ParameterName = "@type",
                    Value= step.Type
                }
                  ,
                new SqlCommandParameter()
                {
                    ParameterName = "@volume",
                    Value= step.Volume
                }
            });
            }
            catch { return false; }
            return true;

        }

        public bool UpdateMode(Mode mode)
        {
            try
            {
                RunQuery(@"UPDATE Modes set Name=@name, MaxBottleNumber=@maxBottleNumber, MaxUsedTips=@maxUsedTips  WHERE ID=@id;", new List<SqlCommandParameter>()
            {
                new SqlCommandParameter()
                {
                    ParameterName = "@name",
                    Value= mode.Name
                },
                 new SqlCommandParameter()
                {
                    ParameterName = "@maxBottleNumber",
                    Value= mode.MaxBottleNumber
                },
                  new SqlCommandParameter()
                {
                    ParameterName = "@maxUsedTips",
                    Value= mode.MaxUsedTips
                },
                new SqlCommandParameter()
                {
                    ParameterName = "@id",
                    Value= mode.Id
                }
            });
            }
            catch { return false; }
            return true;

        }


        public bool UpdateStep(Step step)
        {
            try
            {
                RunQuery(@"UPDATE Steps set ModeId=@modeId, Timer=@timer, Destination=@destination, Speed=@speed, Type=@type, Volume=@volume  WHERE ID=@id;", new List<SqlCommandParameter>()
            {
                 new SqlCommandParameter()
                {
                    ParameterName = "@modeId",
                    Value= step.ModeId
                },
                 new SqlCommandParameter()
                {
                    ParameterName = "@timer",
                    Value= step.Timer
                },
                  new SqlCommandParameter()
                {
                    ParameterName = "@destination",
                    Value= step.Destination
                }
                  ,
                new SqlCommandParameter()
                {
                    ParameterName = "@speed",
                    Value= step.Speed
                }
                 ,
                new SqlCommandParameter()
                {
                    ParameterName = "@type",
                    Value= step.Type
                }
                ,
                new SqlCommandParameter()
                {
                    ParameterName = "@volume",
                    Value= step.Volume
                },  new SqlCommandParameter()
                {
                    ParameterName = "@id",
                    Value= step.Id
                }
            });
            }
            catch { return false; }
            return true;

        }


        private string HashPassword(string passw)
        {
            byte[] data = Encoding.ASCII.GetBytes(passw);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }

    }
}
