using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Data.SqlTypes;

namespace CardGame
{
    public class BestScores
    {
        Game _game;
        public void AddToBestScores()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            
            connectionStringBuilder.DataSource = "./best_scores.db";

            using(var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                // Dodawanie rekordów

                using(var transaction = connection.BeginTransaction())
                {
                    // var listOfWinningPlayers = _game.PlayingTable.GetListWithWinningPlayers();
                    
                    string[] listOfWinningPlayers = {"2020/04/17", "1", "Radek", "15"};

                    var insertCmd = connection.CreateCommand();

                    insertCmd.CommandText = "insert into players values(";
                    foreach(var item in listOfWinningPlayers)
                    {
                        insertCmd.CommandText+="'" + item + "',";

                    }
                    insertCmd.CommandText = insertCmd.CommandText.TrimEnd(',');
                    insertCmd.CommandText+=")";
                    Console.WriteLine(insertCmd.CommandText);
                    insertCmd.ExecuteNonQuery();
                    
                    transaction.Commit();
                }

                // Usuwanie rekordów

                // using(var transaction = connection.BeginTransaction())
                // {
                //     var insertCmd = connection.CreateCommand();
                //     insertCmd.CommandText = "DELETE FROM players WHERE id='1'";
                //     insertCmd.ExecuteNonQuery();

                //     transaction.Commit();
                // }

                // Czytanie rekordów

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM players";
                using(var reader = selectCmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var message = "";
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            message += ","+reader.GetString(i);
                            

                        }
                        System.Console.WriteLine(message.TrimStart(','));
                       
                        
                    }
                    
                }
            }
        }
    }
}