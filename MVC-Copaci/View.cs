using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class View
    {
        CopaciService copaciService = new CopaciService();

        public void Meniu()
        {
            Console.WriteLine("Apsati 1 pentru a afisa toti copacii!");
            Console.WriteLine("Apasati 2 pentru a afisa toti copacii de o anumita inaltime");
            Console.WriteLine("Apasati 3 pentru a afisa toti copacii de aceasi specie");
        }

        public void Play()
        {
            bool running = true;

            copaciService.LoadData();
            while(running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        copaciService.AfisareCopaci(); 
                        break;
                    case "2":
                        copaciService.AfisareCopaciByInaltime();
                        break;
                }
            }
        }

        public void AfisareCopaciByInaltime()
        {
            Console.WriteLine("Introduceti inaltimea pe care o cautati la copaci");

            string inaltimeCop = Console.ReadLine();

            int poz = copaciService.AfisareCopaciInalti(inaltimeCop);
        }
    }
}
