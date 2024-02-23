﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class CopaciService
    {
        public List <Copaci> CopaciList = new List <Copaci> ();

        public void LoadData()
        {
            Copaci copac1 = new Copaci ();
            copac1.grosime = 1;
            copac1.varsta = 2;
            copac1.specie = "Stejar";
            copac1.inaltime = 5;

            Copaci copac2 = new Copaci ();
            copac2.grosime = 3;
            copac2.varsta = 4;
            copac2.specie = "Molid";
            copac2.inaltime = 5;

            Copaci copac3 = new Copaci ();
            copac3.grosime = 7;
            copac3.varsta = 8;
            copac3.specie = "Artar";
            copac3.inaltime = 9;

            Copaci copac4 = new Copaci ();
            copac4.grosime = 10;
            copac4.varsta = 11;
            copac4.specie = "pin";
            copac4.inaltime = 12;

            Copaci copac5 = new Copaci ();
            copac5.varsta = 13;
            copac5.specie = "Mesteacan";
            copac5.inaltime = 14;
            copac5.grosime = 15;

            this.CopaciList.Add(copac1);
            this.CopaciList.Add(copac2);
            this.CopaciList.Add(copac3);
            this.CopaciList.Add(copac4);
            this.CopaciList.Add(copac5);
        }

        public void AfisareCopaci()
        {
            foreach(Copaci x in CopaciList)
            {
                Console.WriteLine(x.CopaciInfo());
            }
        }

        //metoda ce retuneaza o lista cu toti copacii de o anumita inaltime
        public List<Copaci> FilterCopaciByInaltime(int inaltime)
        {
            List <Copaci> listaCopaciByInaltime = new List<Copaci>();

            foreach(Copaci x in CopaciList)
            {
                if (inaltime.Equals(x.inaltime))
                {
                     listaCopaciByInaltime.Add(x);
                }
            }
            return listaCopaciByInaltime;
        }
    }
}
