using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace CardGame
{
    public class CardsDeck
    {
        private List<string> allCardsDeck = new List<string>();

        public CardsDeck()
        {
            AddCardsFromFile();
        }
        
        
        public List<string> GetAllCardsDeck()
        {
            return allCardsDeck;
        }
        
        
        private void AddCardsFromFile()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            
            connectionStringBuilder.DataSource = "./cars.db";

            using(var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                // read records

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM cars";
                using(var reader = selectCmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var message = "";
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            message += ","+reader.GetString(i);

                        }
                        message = message.TrimStart(',');
                        System.Console.WriteLine(message);
                        allCardsDeck.Add(message);
                    }
                }
            }    
        }
    }
}