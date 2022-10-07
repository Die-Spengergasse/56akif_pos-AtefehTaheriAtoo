using System.Net.Http.Headers;

namespace ExProperties.App
{
    internal class Rechteck
    {
        public int Laenge
        {
            get { return _laenge; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ungültige Länge");
                }
                _laenge = value;
            }
        }
        private int _laenge;    
    

        private int _breite;
        public int Breite
        {
            get 
            {
                return _breite;
            }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Ungültige Länge");
                        }
                _breite = value;

            }
        }


        public int Flaeche 
        { 
            get 
            {
                return _laenge * _breite;
                    
                    } 
        }
    }
}