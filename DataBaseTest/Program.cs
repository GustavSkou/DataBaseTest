public class Program
{
    static async Task Main()
    {
        Pim pim = new Pim();
        Console.WriteLine(await pim.fetch(2));
    }
}