using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private static string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=OtelRezervasyon;Trusted_Connection=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}