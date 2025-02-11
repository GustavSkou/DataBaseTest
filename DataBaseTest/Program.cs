
public class Program
{
    static async Task Main()
    {
        Pim pim = new Pim();
        await pim.fetch();
    }
}