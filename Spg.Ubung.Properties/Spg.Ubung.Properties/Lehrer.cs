namespace ExProperties.App
{
    public  class Lehrer
    {
        public string Vorname { get;  set; } = String.Empty;
        public string Zuname { get;  set; } = String.Empty;
        public string Kuerzel
        {
            get {
                if (Zuname.Length >= 3)
                { 
                    return Zuname?.Substring(0, 3).ToUpper() ?? "--";
                }
                return "--";
            }
        }

        public decimal? Bruttogehalt
        { get
            { 
                return _bruttoGehalt;
            }
            
           
            set
            {
                if (Bruttogehalt != null)
                {
                    _bruttoGehalt = value;
                }
            }
        
        } 
        private decimal? _bruttoGehalt;


        public decimal Nettogehalt => _bruttoGehalt ?? 0 * 0.8M;
        
    }
}