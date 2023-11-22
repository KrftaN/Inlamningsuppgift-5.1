
class Program
{
    static void Main(string[] args)
    {
        string[] sentences = { "Detta är den första meningen.", "Och detta är den andra meningen", "Detta är den avslutande meningen" };

        foreach (var element in sentences)
        {
            Console.WriteLine($"{element}\n");
        }
    }
}
