using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher.Controller;
using GameLauncher.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameLauncherTests
{
    [TestClass]
    public class SpielVerwaltungTests
    {

        [TestMethod]
        public void EntityFramework_Test()
        {
            Assert.IsNotNull(SpielVerwaltung.Instanz);
        }

        [TestMethod]
        public void Spiel_Alphabetisch()
        {
            IEnumerable<Spiele> spiele = SpielVerwaltung.Instanz.SpielListe;

            // Liste alphabetisch sortieren
            List<string> spieleTitel = spiele.Select(x => x.Titel).ToList();
            spieleTitel.Sort();

            List<string> spieleTitelVerwaltung = SpielVerwaltung.Instanz.SpielListe.Select(x => x.Titel).ToList();


            for (int i = 0; i < spieleTitel.Count; i++)
            {
                Assert.AreEqual(spieleTitel[i], spieleTitelVerwaltung[i]);
            }
        }

        [TestMethod]
        public void SpielHinzufügen_mehrere_Test()
        {
            for (int i = 0; i < 4; i++)
            {
                string titel = "Testprogramm " + i;
                string pfad = "C:/Program Files/Windows Mail/wab.exe";
                string kategorie = "MailProgramm";
                string publisher = "Ich";
                int usk = 18;

                //SpielVerwaltung.Instanz.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);

                //Assert.IsNotNull(SpielVerwaltung.Instanz.SpielListe.Find(x => x.Titel == titel));
            }
        }

        [TestMethod]
        public void SpielHinzufügen_simpel_Test()
        {
            string titel = "Random Spiel";
            string pfad = "C:/Program Files/Windows Mail/wab.exe";
            string kategorie = "MailProgramm";
            string publisher = "Ich";
            int usk = 18;

            SpielVerwaltung.Instanz.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);

            Assert.IsNotNull(SpielVerwaltung.Instanz.SpielListe.Find(x => x.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel existiert bereits")]
        public void DoppeltesSpielHinzufügen_Test()
        {
            string titel = "Random Spiel";
            string pfad = "C:/Program Files/Windows Mail/wab.exe";
            string kategorie = "MailProgramm";
            string publisher = "Ich";
            int usk = 18;

            SpielVerwaltung.Instanz.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Pfad des Spiels nicht gefunden")]
        public void SpielHinzufügen_BadPath_Test()
        {
            string titel = "Schlechtes Mailprogramm";
            string pfad = "C:\badpath";
            string kategorie = "Mail";
            string publisher = "Ich";
            int usk = 18;

            SpielVerwaltung.Instanz.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        public void SpielFinden_Test()
        {
            string titel = "Mails";

            Spiele spiel = SpielVerwaltung.Instanz.SpielFinden(titel);

            Assert.IsNotNull(spiel);
        }

        [TestMethod]
        public void SpielFinden_NotFound_Test()
        {
            string titel = "Mailkalender";

            Spiele spiel = SpielVerwaltung.Instanz.SpielFinden(titel);

            Assert.IsNull(spiel);
        }

        [TestMethod]
        public void SpielLöschen_Test()
        {
            string titel = "Mails";

            SpielVerwaltung.Instanz.SpielLöschen(titel);

            //Assert.IsNull(verwaltung.SpielListe.Find(s => s.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel nicht gefunden")]
        public void SpielLöschen_NotFound_Test()
        {
            string titel = "Mailkalender";

            SpielVerwaltung.Instanz.SpielLöschen(titel);

            Assert.IsNull(SpielVerwaltung.Instanz.SpielListe.Find(s => s.Titel == titel));
        }

        
    }
}
