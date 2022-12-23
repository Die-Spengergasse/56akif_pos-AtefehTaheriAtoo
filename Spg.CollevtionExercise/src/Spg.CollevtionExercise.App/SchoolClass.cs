using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Spg.CollevtionExercise.App;

namespace ExCollection.App
{
    public class SchoolClass
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.

        public List<Person> Schuelers { get; set; } = new();
        public string Name { get; set; }
        public string KV { get; set; }
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Person s)
        {
            if (s is null)
            {
                throw new ArgumentNullException("Nur null");
            }
            if (Schuelers.Contains(s))
            {
                throw new ArgumentException("Schüler ist breits in der klasse");
            }

            Student? student = s as Student;
            if (Student is not null)
            {
                s.KlasseNavigation = this;
            }
            Schuelers.Add(s);
        }

    }
}