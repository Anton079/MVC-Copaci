using MVC_Copaci;

internal class Program
{
    public static void Main(string[] args)
    {
        
        CopaciService service = new CopaciService();

        service.LoadData();


        List<Copaci> Copacis = service.FilterCopaciByLimits(25);
        foreach(Copaci x in Copacis)
        {
            Console.WriteLine(x.CopaciInfo());
        }
    }
}