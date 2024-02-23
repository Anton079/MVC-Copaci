using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Copaci
{
    public class Copaci
    {
        public int inaltime;
        public string specie;
        public int varsta;
        public int grosime;

        public string CopaciInfo()
        {
            string text = " ";
            text += "Inaltime" + inaltime + "\n";
            text += "Specie" + specie + "\n";
            text += "Varsta" + varsta + "\n";
            text += "Grosime" + grosime + "\n";
            return text;
        }
    }
}
