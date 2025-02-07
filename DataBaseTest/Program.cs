using Npgsql;

public class Program
{
    static async Task Main()
    {
        var con = new NpgsqlConnection //Connection instans
        (
            connectionString:
                "Server=localhost;" +
                "Port=5432;" +
               $"User Id={UserCredentials.Name};" +
               $"Password={UserCredentials.Password};" +
                "Database=postgres;"
        );
        con.Open();
        using var cmd = new NpgsqlCommand();
        cmd.Connection = con;

        cmd.CommandText = ($"DROP TABLE IF EXISTS teachers");
        await cmd.ExecuteNonQueryAsync();
        cmd.CommandText = ("CREATE TABLE teachers (id SERIAL PRIMARY KEY," +
            "first_name VARCHAR(255)," +
            "last_name VARCHAR(255)," +
            "subject VARCHAR(255)," +
            "salary INT)");
        await cmd.ExecuteNonQueryAsync();
    }
}