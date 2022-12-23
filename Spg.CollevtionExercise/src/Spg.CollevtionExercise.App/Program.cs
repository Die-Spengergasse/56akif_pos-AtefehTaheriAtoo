using System;
using System.Collections.Generic;
using ExCollection.App;
using Newtonsoft.Json;
using Spg.CollevtionExercise.App;

namespace Spg.CollevtionExercise.App
{

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SchoolClass> SchoolClasses = new Dictionary<string, SchoolClass>();
            SchoolClasses.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
            SchoolClasses.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
            SchoolClasses.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
            SchoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1001, LastName = "VN1", FirstName = "ZN1", MaximaleStudiendauer = 5 });
            SchoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1002, LastName = "VN2", FirstName = "ZN2", MaximaleStudiendauer = 2 });
            SchoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1003, LastName = "VN3", FirstName = "ZN3", MaximaleStudiendauer = 3 });
            SchoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1011, LastName = "VN4", FirstName = "ZN4", MaximaleStudiendauer = 1 });
            SchoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1012, LastName = "VN5", FirstName = "ZN5", MaximaleStudiendauer = 7 });
            SchoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1013, LastName = "VN6", FirstName = "ZN6", MaximaleStudiendauer = 2 });
            SchoolClasses["3CHIF"].AddSchueler(new Student() { Id = 1021, LastName = "VN7", FirstName = "ZN7", MaximaleStudiendauer = 7 });


            Student? s = SchoolClasses["3AHIF"].Schuelers[0] as Student;
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(SchoolClasses["3AHIF"].Schuelers));
            s.ChangeKlasse(SchoolClasses["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(SchoolClasses["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(SchoolClasses["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            KurzesteStudiendauer(SchoolClasses["3AKIF"]);

            Console.WriteLine(SchoolClasses["3CHIF"].Schuelers[1].FullName);
        }
        private static void KurzesteStudiendauer(SchoolClass k)
        {
            // 1. Erste Dauer merken
            // 2. Prüfung ob die nächste Dauer kleiner oder größer ist.
            // 2.1. wenn größer: nichts zu tun ; zum nächsten Schüler gehen
            // 2.2. wenn kleiner: überschreiben wir den ersten wert mit dem neuen Minimum

            int minwert = 7;
            foreach (Student item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minwert)
                {
                    if (item is Student)
                    {
                        minwert = item.MaximaleStudiendauer;
                    }
                }
            }

            Console.WriteLine($"Minimal Studendauer in der {k?.Name ?? "unbekannt klasse"} ist: {minwert}");
        }

    }

}
