public class Program
{
    static async Task Main()
    {
        IPim pim = new Pim();
        Console.WriteLine(await pim.Fetch(2));
    }
}