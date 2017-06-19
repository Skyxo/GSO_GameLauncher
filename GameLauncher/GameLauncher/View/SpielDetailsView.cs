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

            spielTitelLabel.Text = titel;
            installationsDatumLabel.Text = installationsDatum.ToLongTimeString();
            zuletztGespieltLabel.Text = (zuletztGespielt != null && zuletztGespielt.HasValue ? zuletztGespielt.Value.ToLongDateString() : "");
            installationspfadLabel.Text = installationspfad;
            kategorieLabel.Text = kategorie;
            publisherLabel.Text = publisher;
            uskLabel.Text = usk.ToString() + " Jahre";

            this.AutoSize = true;
        }

    }
}
