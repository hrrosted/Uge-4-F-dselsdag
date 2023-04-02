using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_4_Fødselsdag
{
    internal class Person
    {
        private string navn;
        private int alder;
        private string adresse;
        public string Navn
        { get { return navn; } set { navn = value; } }
        public int Alder
        {
            get { return alder; }
            set
            {
                if (value >= 0)
                {
                    alder = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Alder skal være større end eller lig med 0");
                }
            }

        }
        public string Adresse { get { return adresse; } set { adresse = value; } }

        public Person(string navn, int alder, string adresse)
        {
            Navn = navn;
            Alder = alder;
            Adresse = adresse;
        }

        public void Fødselsdag(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Alder++;
            }
        }
        public override string ToString()
        {
            string s = $"{Navn} er nu {Alder} år og bor på adressen {Adresse}";
            return s;
        }
    }
}
