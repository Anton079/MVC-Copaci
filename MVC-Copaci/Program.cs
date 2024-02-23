using MVC_Copaci;

internal class Program
{
    public static void Main(string[] args)
    {
        
        CopaciService service = new CopaciService();

        service.LoadData();

        service.AfisareCopaci();



    }
}