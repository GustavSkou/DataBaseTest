using Npgsql;

class Database
{
    /*---------------------------------------------------------*/
    static readonly private Database database = new Database();
    static public Database Instance { get { return database; } }
    /*---------------------------------------------------------*/

    private NpgsqlConnection connection;
    private NpgsqlCommand command;

    public NpgsqlConnection Connection { get { return connection; } }
    public NpgsqlCommand Command { get { return command; } }

    private Database()
    {
        connection = new NpgsqlConnection //Connection instans
        (
            $"Server=localhost;" +
            $"Port=5432;" +
            $"User Id={UserCredentials.Name};" +
            $"Password={UserCredentials.Password};" +
            $"Database=postgres;"
        );
        connection.Open();

        command = new NpgsqlCommand();
        command.Connection = connection;
    }
}