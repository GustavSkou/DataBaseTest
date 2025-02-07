using Npgsql;

public class Program
{
    static async Task Main()
    {
        var con = new NpgsqlConnection //Connection instans
        (
                "Server=localhost;" +
                "Port=5432;" +
               $"User Id={UserCredentials.Name};" +
               $"Password={UserCredentials.Password};" +
                "Database=postgres;"
        );
        con.Open();
        using var cmd = new NpgsqlCommand();
        cmd.Connection = con;

        /*cmd.CommandText = "DROP TABLE IF EXISTS teachers";

        await cmd.ExecuteNonQueryAsync();

        cmd.CommandText = 
            "CREATE TABLE teachers (" +
                "id SERIAL PRIMARY KEY," +
                "first_name VARCHAR(255)," +
                "last_name VARCHAR(255)," +
                "subject VARCHAR(255)," +
                "salary INT)";
        
        await cmd.ExecuteNonQueryAsync();

        cmd.CommandText =
            "INSERT INTO teachers (first_name, last_name, subject, salary)" +
            "VALUES('John', 'Doe', 'Math', 50000), " +
            "('Jane', 'Smith', 'Science', 55000)";
        await cmd.ExecuteNonQueryAsync();
        */

        cmd.CommandText = "SELECT * FROM teachers WHERE first_name = 'John'";
        using var reader = await cmd.ExecuteReaderAsync();
        Teacher teacher = null;
        while (await reader.ReadAsync())
        {
            teacher = new Teacher
            (
                reader.GetInt32(0),     //ID SERIAL
                reader.GetString(1),    //first_name VARCHAR
                reader.GetString(2),    //last_name VARCHAR
                reader.GetString(3),    //subject VARCHAR
                reader.GetInt32(4)      //salary INT
            );
        }
        Console.WriteLine((object)teacher.ToString());
    }
}