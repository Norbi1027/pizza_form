using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaForm
{
    internal class Pizza
    {
        char[] forrasbolEltavolitandoKarakterek = new char[] { '\"', '\\', ' ' };

        int pazon;
        string pnev;
        int par;

        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            pnev = sor[1].Trim().Replace("\"",string.Empty).Replace('.',',');
            par = int.Parse(sor[2].Trim().Replace("\"",string.Empty).Replace('.',','));


        }
        public string Pnev { get => pnev; set => pnev = value; }
        public int Par { get => par; set => par = value; }

        public override string ToString()
        {
            return $"{pnev} Ár: {par.ToString()}";
        }
    }
}
