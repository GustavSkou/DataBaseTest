public class Pim
{
    async public Task<object> fetch(int id)
    {
        Database.Instance.Command.CommandText = $"SELECT * FROM teachers WHERE ID = '{id}'";

        using var reader = await Database.Instance.Command.ExecuteReaderAsync();

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
        return teacher;
    }
}