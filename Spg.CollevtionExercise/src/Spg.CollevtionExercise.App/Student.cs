using Newtonsoft.Json;
using Spg.CollevtionExercise.App;

namespace Spg.CollevtionExercise.App
{
    public class Student : Person
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.

        [JsonIgnore] 
        public SchoolClass KlasseNavigation { get; set; } = new();

        public string FirstName { get; set; }
        public string LastName { get; set; }



        public string FullName
        {
            get 
            {
                return $"fullName: {LastName} {FirstName}";
            }
        }


        // Bedigung: Die Studierender muss mindestenst 1 Jahr, maximal 7 Jahre betragen.
        public int MaximaleStudiendauer
        {
            get { return _maximaleStudiendauer; }
            set 
            {
                if (value >= 1 && value <= 7)
                {
                    _maximaleStudiendauer = value;
                }
                else 
                {
                    throw new ArgumentException("Studiernedauer liegt nicht im gültigen Breich!");
                }
            }
        }
        private int _maximaleStudiendauer;

        public Student() : this (12)
        { }

        public Student(int id) : base (id) 
        {
            
        }



        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(SchoolClass k)
        {
            KlasseNavigation.Schuelers.Remove(this);
            //KlasseNavigation = k;
            k.AddSchueler(this);
        }
         
        public override string GetArriveType()
        {
            return "Resit meist Öff an, oder mit dem Fahrad"; 
        }
    }
}
