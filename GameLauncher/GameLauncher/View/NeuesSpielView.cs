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
    public partial class NeuesSpielView : Form
    {

        private string installationsPfad = "";

        public NeuesSpielView()
        {
            InitializeComponent();
        }

        private void durchsuchenButton_Click(object sender, EventArgs e)
        {
            if (installationsPfadOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(installationsPfadOpenFileDialog.FileName);
                installationsPfad = installationsPfadOpenFileDialog.FileName;

                installationsPfadLabel.Text = installationsPfad;
                sr.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(spielTitelTextBox.Text) ||
                string.IsNullOrEmpty(kategorieTextBox.Text) ||
                string.IsNullOrEmpty(publisherTextBox.Text) ||
                string.IsNullOrEmpty(uskTextBox.Text) ||
                string.IsNullOrEmpty(installationsPfad))
            {
                MessageBox.Show("Bitte fülle alle Felder aus um ein Spiel hinzuzufügen");
                return;
            }

            string titel = spielTitelTextBox.Text;
            string kategorie = kategorieTextBox.Text;
            string publisher = publisherTextBox.Text;
            int usk = -1;

            try
            {
                Int32.TryParse(uskTextBox.Text, out usk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte eine gültige Zahl für das USK angeben.");
            }

            SpielVerwaltung spielVerwaltung = new SpielVerwaltung();
            spielVerwaltung.SpielHinzufügen(titel, installationsPfad, kategorie, publisher, usk);

            this.Close();
        }
    }
}
