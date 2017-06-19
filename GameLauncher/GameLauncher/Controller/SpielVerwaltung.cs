using GameLauncher.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Controller
{
    class SpielVerwaltung
    {

        /// <summary>
        /// [Singleton] Instanz der Spielverwaltung
        /// </summary>
        private static SpielVerwaltung __Instanz = new SpielVerwaltung();

        /// <summary>
        /// [Singleton] Instanz der Spielverwaltung
        /// </summary>
        public static SpielVerwaltung Instanz
        {
            get
            {
                return __Instanz;
            }
        }

        /// <summary>
        /// Spiel
        /// </summary>
        public List<Spiele> SpielListe
        {
            get;
            set;
        }

        /// <summary>
        /// Laden aller Spieleinträge
        /// </summary>
        private SpielVerwaltung()
        {
            SpielListe = new List<Spiele>();

            DatenLaden();
        }

        /// <summary>
        /// Spieleinträge aus der Datenbank laden
        /// </summary>
        private void DatenLaden()
        {
            SpieleEntities spieleEntities = new SpieleEntities();

            SpielListe.AddRange(from s in spieleEntities.Spiele
                                select s);
        }

        /// <summary>
        /// Spiel der Liste hinzufügen
        /// </summary>
        /// <param name="titel"></param>
        /// <param name="pfad"></param>
        /// <param name="kategorie"></param>
        /// <param name="publisher"></param>
        /// <param name="usk"></param>
        public void SpielHinzufügen(string titel, string pfad, string kategorie, string publisher, int usk)
        {
            if (SpielFinden(titel) != null)
            {
                throw new ArgumentException("Spiel existiert bereits");
            }

            // Pfad überprüfen
            Utils.Utils.PfadCheck(pfad);

            // Spielmodel befüllen
            Spiele spiel = new Spiele();
            spiel.Titel = titel;
            spiel.InstallationsPfad = pfad;
            spiel.Kategorie = kategorie;
            spiel.Publisher = publisher;
            spiel.USK = usk;
            spiel.InstallationsDatum = DateTime.Now;
            spiel.ZuletztGespielt = null;

            // Spiel dem Datenmodell hinzufügen
            SpieleEntities spieleEntities = new SpieleEntities();
            spieleEntities.Spiele.Add(spiel);

            spieleEntities.SaveChanges();

            // Spiel zur Liste hinzufügen
            SpielListe.Add(spiel);
        }

        /// <summary>
        /// Existierendes Spiel aus der Liste löschen
        /// </summary>
        /// <param name="titel"></param>
        public void SpielLöschen(string titel)
        {
            // Spiel in der Datenbank finden
            Spiele spiel = SpielFinden(titel);

            if (spiel == null)
            {
                throw new ArgumentException("Spiel nicht gefunden");
            }

            // Spiel aus der Datenbank löschen
            SpieleEntities spieleEntities = new SpieleEntities();
            spieleEntities.Spiele.Remove(spieleEntities.Spiele.FirstOrDefault(s => s.Titel == titel));
            spieleEntities.SaveChanges();
        }

        /// <summary>
        /// Existierendes Spiel finden
        /// </summary>
        /// <param name="titel"></param>
        /// <returns></returns>
        public Spiele SpielFinden(string titel)
        {
            SpieleEntities spieleEntities = new SpieleEntities();

            // Spiel in der Datenbank finden
            IQueryable<Spiele> spiele = from s in spieleEntities.Spiele
                                        where s.Titel == titel
                                        select s;

            // Existenz des Spiels prüfen
            if (spiele.Count() == 0)
            {
                return null;
            }

            return spiele.FirstOrDefault();
        }

        /// <summary>
        /// Spiel starten
        /// </summary>
        /// <param name="titel"></param>
        public void SpielStarten(string titel)
        {
            Spiele spiel = SpielFinden(titel);

            if (spiel == null)
            {
                throw new ArgumentException("Spiel nicht gefunden");
            }

            SpieleEntities spieleEntities = new SpieleEntities();
            Spiele s = spieleEntities.Spiele.Find(spiel.SpielID);
            s.ZuletztGespielt = DateTime.Now;

            Process.Start(spiel.InstallationsPfad);
        }

    }
}
