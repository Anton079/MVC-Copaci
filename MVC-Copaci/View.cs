using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class View
    {
        private CopaciService _copaciService;

        public View()
        {
            _copaciService = new CopaciService();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati 1 pentru a afisa toti copacii!");
            Console.WriteLine("Apasati 2 pentru a adauga un copac in lista");
            Console.WriteLine("Apasati 3 pentru a da remove la un copac");
            Console.WriteLine("Apasati 4 pentru a edita inaltimea unui copac");
            Console.WriteLine("Apasati 5 pentru a edita varsta unui copac");
            Console.WriteLine("Apasati 6 pentru a afisa toti copacii de o anumita inaltime");
            Console.WriteLine("Apasati 7 pentru a afisa toti copacii de aceasi specie");
        }

        public void Play()
        {
            bool running = true;

            _copaciService.LoadData();
            while(running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _copaciService.AfisareCopaci(); 
                        break;

                    case "2":
                        AdaugareaUnuiAnimal();
                        break;

                    case "3":
                        StergereaUnuiCopac();
                        break;

                    case "4":
                        EditInaltimeCopaci();
                        break;

                    case "5":
                        EditAgeCopac();
                        break;

                }
            }
        }

        public void AdaugareaUnuiAnimal()
        {
            Console.WriteLine("Inaltimea copacului");
            int inaltimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tipul de copac");
            string specieNou = Console.ReadLine();

            Console.WriteLine("varsta");
            int varstaNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Greutate");
            int greutateNou = Int32.Parse(Console.ReadLine());

            Copaci copac6 = new Copaci();
            copac6.Inaltime = inaltimeNou;
            copac6.Specie = specieNou;
            copac6.Varsta = varstaNou;
            copac6.Grosime = greutateNou;               

            Console.WriteLine("Copacul a fost adaugat cu succes");
        }

        public void StergereaUnuiCopac()
        {
            Console.WriteLine("Din lista de mai jos ce copac doiriti sa stergeti");
            _copaciService.AfisareCopaci();
            string CopacDorite = Console.ReadLine();

            if (_copaciService.FindCopacBySpecie(CopacDorite) != -1)
            {
                _copaciService.RemoveCopacBySpecie(CopacDorite);
                Console.WriteLine("Copacul a fost sters!");
            }
            else
            {
                Console.WriteLine("Copacul nu exista");

            }
        }

        public void EditInaltimeCopaci()
        {
            Console.WriteLine("Ce copac doriti sa editati");
            string copacAles = Console.ReadLine();

            Console.WriteLine("Cu ce inaltime doriti sa modificati copacul");
            int copaciNewHigh = Int32.Parse(Console.ReadLine());

            if (_copaciService.EditCopaciInaltime(copacAles, copaciNewHigh))
            {
                Console.WriteLine("Copacul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Copacul nu a putut fi editat");
            }
        }

        public void EditAgeCopac()
        {
            Console.WriteLine("Ce copac doriti sa editati");
            string copacAles = Console.ReadLine();

            Console.WriteLine("Cu ce varsta doriti sa modificati copacul");
            int copaciNewAge = Int32.Parse(Console.ReadLine());

            if (_copaciService.EditCopaciInaltime(copacAles, copaciNewAge))
            {
                Console.WriteLine("Copacul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Copacul nu a putut fi editat");
            }
        }

        //public void AfisareCopaciByInaltime()
        //{
        //    Console.WriteLine("Introduceti inaltimea pe care o cautati la copaci");

        //    string inaltimeCop = Console.ReadLine();

        //    int poz = copaciService.AfisareCopaciInalti(inaltimeCop);
        //}
    }
}
