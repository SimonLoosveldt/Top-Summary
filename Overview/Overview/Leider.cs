using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    class Leider
    {

        private String naam;
        private String afdeling;



        public enum Leidsters { HanneVl, Marie, Clémence, Laura, Leni, Hélène, Silke, Leonie, Leontine, HanneVb, Margot, Alexandra, Lotte };

        public Leider (String naam, String afdeling)
        {
            SetNaam(naam);


        }

        public void SetNaam(String naam) { this.naam = naam; }
        public String GetNaam() { return this.naam; }

        public void Setafdeling(String naam) { this.naam = naam; }
        public String Getafdeling() { return this.naam; }



    }
}
