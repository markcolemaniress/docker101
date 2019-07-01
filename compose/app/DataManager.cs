using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using app.Models;

public class DataManager
 {
    internal static Player GetPlayerDetails(int playerId)
    {
        Player result = null;

        SqlConnection conn = GetConnection();
        SqlCommand comm = new SqlCommand($"SELECT * FROM Player WHERE PlayerId = {playerId}", conn);

        SqlDataReader rdr = comm.ExecuteReader();
        if (rdr.Read())
        {
            result = new Player();
            result.Id = playerId;
            result.Name = rdr.GetSqlString(1).Value;
            result.Position = rdr.GetSqlString(2).Value;
        }

        conn.Close();

        return result;
    }

    internal static IList<Player> GetPlayers()
    {
        IList<Player> result = new List<Player>();

        SqlConnection conn = GetConnection();
        SqlCommand comm = new SqlCommand($"SELECT PlayerId, Name, Position FROM Player", conn);

        SqlDataReader rdr = comm.ExecuteReader();
        while (rdr.Read())
        {
            var player = new Player();
            player.Id = rdr.GetInt16(0);
            player.Name = rdr.GetSqlString(1).Value;
            player.Position = rdr.GetSqlString(2).Value;
            result.Add(player);
        }

        conn.Close();

        return result;
    }

    private static SqlConnection GetConnection()
    {
        const string CONNECTION_STRING = "Server=db;Database=DockerDemo;User Id=sa;Password=Passw0rd";

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        return connection;
    }

 }
