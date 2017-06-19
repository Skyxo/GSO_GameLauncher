using GameLauncher.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.View
{
    public partial class SpielDetailsView : Form
    {

        private string SpielTitel
        {
            get;
            set;
        }

        /// <summary>
        /// Zeigt alle übergebenen Details eines Spiels an
        /// </summary>
        /// <param name="titel">Spieltitel</param>
        /// <param name="installationsDatum">Installationsdatum</param>
        /// <param name="zuletztGespielt">Zuletzt gespielt</param>
        /// <param name="installationspfad">Installationspfad</param>
        /// <param name="kategorie">Kategorie</param>
        /// <param name="publisher">Publisher</param>
        /// <param name="usk">USK-Einstufung</param>
        public SpielDetailsView(string titel, DateTime installationsDatum, DateTime? zuletztGespielt, string installationspfad, string kategorie, string publisher, int usk)
        {
            InitializeComponent();

            SpielTitel = titel;

            spielTitelLabel.Text = titel;
            installationsDatumLabel.Text = installationsDatum.ToLongTimeString();
            zuletztGespieltLabel.Text = (zuletztGespielt != null && zuletztGespielt.HasValue ? zuletztGespielt.Value.ToLongDateString() : "");
            installationspfadLabel.Text = installationspfad;
            kategorieLabel.Text = kategorie;
            publisherLabel.Text = publisher;
            uskLabel.Text = usk.ToString() + " Jahre";

            this.AutoSize = true;
        }

        private void spielLöschenButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Soll das Spiel wirklich aus der Übersicht entfernt werden?", "Spiel löschen", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SpielVerwaltung.Instanz.SpielLöschen(SpielTitel);
                MessageBox.Show("Das Spiel wurde aus der Übersicht entfernt");
            }
        }

        private void spielStartenButton_Click(object sender, EventArgs e)
        {
            SpielVerwaltung.Instanz.SpielStarten(SpielTitel);
        }
    }
}
