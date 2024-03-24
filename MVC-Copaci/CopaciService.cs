using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class CopaciService
    {
        private List<Copaci> _CopaciList;

        public CopaciService()
        {
            _CopaciList = new List<Copaci>();
            this.LoadData();
        }

        public void LoadData()
        {
            Copaci copac1 = new Copaci ();
            copac1.Grosime = 1;
            copac1.Varsta = 2;
            copac1.Specie = "Stejar";
            copac1.Inaltime = 5;

            Copaci copac2 = new Copaci ();
            copac2.Grosime = 3;
            copac2.Varsta = 4;
            copac2.Specie = "Molid";
            copac2.Inaltime = 5;

            Copaci copac3 = new Copaci ();
            copac3.Grosime = 7;
            copac3.Varsta = 8;
            copac3.Specie = "Artar";
            copac3.Inaltime = 9;

            Copaci copac4 = new Copaci ();
            copac4.Grosime = 10;
            copac4.Varsta = 11;
            copac4.Specie = "pin";
            copac4.Inaltime = 12;

            Copaci copac5 = new Copaci ();
            copac5.Varsta = 13;
            copac5.Specie = "Mesteacan";
            copac5.Inaltime = 14;
            copac5.Grosime = 15;

            this._CopaciList.Add(copac1);
            this._CopaciList.Add(copac2);
            this._CopaciList.Add(copac3);
            this._CopaciList.Add(copac4);
            this._CopaciList.Add(copac5);
        }


        //metoda ce retuneaza o lista cu toti copacii de o anumita inaltime
        public List<Copaci> FilterCopaciByInaltime(int inaltime)
        {
            List <Copaci> listaCopaciByInaltime = new List<Copaci>();

            foreach(Copaci x in _CopaciList)
            {
                if (inaltime.Equals(x.Inaltime))
                {
                     listaCopaciByInaltime.Add(x);
                }
            }
            return listaCopaciByInaltime;
        }

        //metoda ce returneaza o list unde totalul varstelor copaciilor sa fie de 25
        public List <Copaci> FilterCopaciByLimits(int varstaMax)
        {
            List <Copaci> copacis = new List<Copaci>();
            int suma = 0;
            foreach(Copaci x in _CopaciList)
            {
                if (suma + x.Varsta <= varstaMax)
                {
                    copacis.Add(x);
                    suma += x.Varsta;
                }
            }
            return copacis;
        }

        public bool EditTreeThickness(string specie, int newThickness)
        {
            foreach (Copaci x in _CopaciList)
            {
                if (x.Specie == specie)
                {
                    x.Grosime = newThickness; 
                    return true;
                }
            }
            return false; 
        }

        //CRUD
        public void AfisareCopaci()
        {
            foreach(Copaci x in _CopaciList)
            {
                Console.WriteLine(x.CopaciInfo());
            }
        }

        public int FindCopacBySpecie(string specieCautata)
        {
            for(int i = 0; i < _CopaciList.Count; i++)
            {
                if (_CopaciList[i].Specie == specieCautata)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddCopacInList(Copaci CopacNou)
        {
            if (FindCopacBySpecie(CopacNou.Specie) == -1)
            {
                this._CopaciList.Add(CopacNou);
                return true;
            }
            return false;
        }

        public bool RemoveCopacBySpecie(string CopacCautat)
        {
            int CopaculCautat = FindCopacBySpecie(CopacCautat);
            if(CopaculCautat != -1)
            {
                _CopaciList.RemoveAt(CopaculCautat);
                return true;
            }
            return false;
        }

        //View
        public bool AfisareCopaciInalti(int inaltimeCop)
        {
            for (int i = 0;i < _CopaciList.Count;i++)
            {
                if (_CopaciList[i].Inaltime == inaltimeCop) 
                {
                    Console.WriteLine(i);
                    return true;
                }
            }
            return false;
        }

        //public bool AfisareCopaciBySpecie()
        //{
        //    for(int i = 0; i < CopaciList.Count; i++)
        //    {
        //        if(copaciL)
        //    }
        //}

        //Edit
        public bool EditCopaciInaltime(string copacAles,int newInaltime)
        {
            foreach (Copaci x in _CopaciList)
            {
                if (x.Specie.Equals(copacAles))
                {
                    x.Inaltime = newInaltime;
                    return true;
                }
            }
            return false;
        }

        public bool EditCopaciVarsta(string copacAles, int newVarsta)
        {
            foreach (Copaci x in _CopaciList)
            {
                if (x.Specie.Equals(copacAles))
                {
                    x.Varsta = newVarsta;
                    return true;
                }
            }
            return false;
        }

    }
}
