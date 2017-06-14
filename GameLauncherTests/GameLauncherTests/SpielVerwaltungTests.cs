using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher.Controller;
using GameLauncher.Model;

namespace GameLauncherTests
{
    [TestClass]
    public class SpielVerwaltungTests
    {

        [TestMethod]
        public void EntityFramework_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();
            Assert.IsNotNull(verwaltung);
        }

        [TestMethod]
        public void SpielHinzufügen_simpel_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "und so weiter ...";
            string pfad = "C:/Program Files/Windows Mail/wab.exe";
            string kategorie = "MailProgramm";
            string publisher = "Ich";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);

            Assert.IsNotNull(verwaltung.SpielListe.Find(x => x.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel existiert bereits")]
        public void DoppeltesSpielHinzufügen_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Mails";
            string pfad = "C:/Program Files/Windows Mail/wab.exe";
            string kategorie = "MailProgramm";
            string publisher = "Ich";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Pfad des Spiels nicht gefunden")]
        public void SpielHinzufügen_BadPath_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Schlechtes Mailprogramm";
            string pfad = "C:\badpath";
            string kategorie = "Mail";
            string publisher = "Ich";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        public void SpielFinden_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Mails";

            Spiele spiel = verwaltung.SpielFinden(titel);

            Assert.IsNotNull(spiel);
        }

        [TestMethod]
        public void SpielFinden_NotFound_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Mailkalender";

            Spiele spiel = verwaltung.SpielFinden(titel);

            Assert.IsNull(spiel);
        }

        [TestMethod]
        public void SpielLöschen_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Mails";

            verwaltung.SpielLöschen(titel);

            //Assert.IsNull(verwaltung.SpielListe.Find(s => s.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel nicht gefunden")]
        public void SpielLöschen_NotFound_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "Mailkalender";

            verwaltung.SpielLöschen(titel);

            Assert.IsNull(verwaltung.SpielListe.Find(s => s.Titel == titel));
        }

        
    }
}
