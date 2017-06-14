using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLauncherTests
{
    [TestClass]
    public class SpielVerwaltungTests
    {

        [TestMethod]
        public void SpielHinzufügen_simpel_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";
            string pfad = "";
            string kategorie = "";
            string publisher = "";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);

            Assert.IsTrue(verwaltung.SpielListe.FirstOrDefault(s => s.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel existiert bereits")]
        public void DoppeltesSpielHinzufügen_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";
            string pfad = "";
            string kategorie = "";
            string publisher = "";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Pfad des Spiels nicht gefunden")]
        public void SpielHinzufügen_BadPath_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";
            string pfad = "";
            string kategorie = "";
            string publisher = "";
            int usk = 18;

            verwaltung.SpielHinzufügen(titel, pfad, kategorie, publisher, usk);
        }

        [TestMethod]
        public void SpielFinden_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            Spiel spiel = verwaltung.SpielFinden(titel);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel nicht gefunden")]
        public void SpielFinden_NotFound_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            Spiel spiel = verwaltung.SpielFinden(titel);
        }

        [TestMethod]
        public void SpielLöschen_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            Spiel spiel = new Spiel();
            spiel.Titel = titel;

            verwaltung.SpielListe.Add(spiel);

            verwaltung.SpielLöschen(titel);

            Assert.IsNull(verwaltung.SpielListe.FirstOrDefault(s => s.Titel == titel));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel nicht gefunden")]
        public void SpielLöschen_NotFound_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            verwaltung.SpielLöschen(titel);

            Assert.IsNull(verwaltung.SpielListe.FirstOrDefault(s => s.Titel == titel));
        }

        [TestMethod]
        public void SpielDetails_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            verwaltung.SpielDetails(titel);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Spiel nicht gefunden")]
        public void SpielDetails_NotFound_Test()
        {
            SpielVerwaltung verwaltung = new SpielVerwaltung();

            string titel = "";

            verwaltung.SpielDetails(titel);
        }

    }
}
