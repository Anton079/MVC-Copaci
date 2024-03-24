using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class Copaci
    {
        public int _inaltime;
        public string _specie;
        public int _varsta;
        public int _grosime;


        public int Inaltime
        {
            get { return _inaltime; }
            set { _inaltime = value; }
        }

        public string Specie
        {
            get { return _specie; }
            set { _specie = value; }
        }

        public int Varsta
        {
            get { return _varsta; }
            set { _varsta = value; }
        }

        public int Grosime
        {
            get { return _grosime; }
            set { _grosime = value; }
        }


        public string CopaciInfo()
        {
            string text = " ";
            text += "Inaltime" + Inaltime + "\n";
            text += "Specie" + Specie + "\n";
            text += "Varsta" + Varsta + "\n";
            text += "Grosime" + Grosime + "\n";
            return text;
        }
    }
}
