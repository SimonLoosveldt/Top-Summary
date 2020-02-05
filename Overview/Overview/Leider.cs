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

        public enum Afdeling
        {
            Kabouters,
            Sloebers,
            Speelclub_jongens,
            Speelclub_meisjes,
            Rakkers,
            Kwiks,
            Toppers,
            Tippers,
            Kerels,
            Tiptiens,
            Aspis,
            Aspies
        }
        public enum Leiding {
            Arne,
            Hélène,
            Silke,
            Arthur,
            Axel,
            Mateo,
            Gil,
            HanneVb,
            Marthe,
            SeppeV,
            SeppeC,
            Simon,
            Stan,
            Kasper,
            Alexandra,
            Margot,
            Levi,
            Luka,
            LauraVh,
            Maarten,
            Leni,
            Luna,
            HanneVdb,
            Clemens,
            Pieter,
            Viktor,
            Robin,
            Leontine,
            Axelle,
            Lucas,
            Robbe,
            Arnaud,
            LauraVb
        };

        public Leider ()
        {

        }

        public Leider (String naam)
        {
            SetNaam(naam);
            //SetNaam(afdeling);

        }

        public void SetNaam(String naam) // Getter and setter of private field 'naam'
        {
            if (NameChecker(naam) == true)
            {
                this.naam = naam;
            }
        }  
        public String GetNaam() { return this.naam; }

        public void Setafdeling(String afdeling)
        {
            if (AfdelingsChecker(afdeling) == true)
            {
                this.afdeling = afdeling;
            }
        }
        public String Getafdeling() { return this.naam; }

        public bool NameChecker (string name)
        {
             foreach (var leiding in Enum.GetValues(typeof(Leiding)))
            {
                if (leiding.ToString() == name)
                {
                    return true;
                }
                else
                {
                    break;
                }   
            }
            return false;
        }

        public bool AfdelingsChecker(string name)
        {
            foreach (var afdeling in Enum.GetValues(typeof(Afdeling)))
            {
                if (afdeling.ToString() == name)
                {
                    return true;
                }
                else
                {
                    break;
                }
            }
            return false;
        }     
    }
}
