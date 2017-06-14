using GameLauncher.Controller;
using GameLauncher.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.View
{
    public partial class GameLauncher : Form
    {

        private SpielVerwaltung SpielVerwaltung
        {
            get;
            set;
        }

        public GameLauncher()
        {
            InitializeComponent();

            this.ResizeRedraw = true;
            this.AutoScrollMinSize = new Size(0, 3000);

            SpielVerwaltung = new SpielVerwaltung();
        }

        /// <summary>
        /// Fenster malen
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Graphics g = e.Graphics;

            float windowHeight = this.Size.Height;
            float windowWidth = this.Size.Width;

            // Title text
            string titleText = "Deine Spiele";

            SizeF titleTextSize = MeasureString(e, titleText, 24);
            float titleTextX = ZentrierteBreiteKoodrinaten(windowWidth, titleTextSize.Width);

            Rectangle titleTextRectangle = new Rectangle(FloatToInt(titleTextX), 30, FloatToInt(titleTextSize.Width), FloatToInt(titleTextSize.Height));

            Brush titleTextBrush = new LinearGradientBrush(titleTextRectangle, Color.Gray, Color.DarkGray, LinearGradientMode.Vertical);
            Font titleTextFont = new Font("Century Gothic", 24);

            g.DrawString(titleText, titleTextFont, titleTextBrush, titleTextX, 30F);


            // Title line
            float titleLineX = ZentrierteBreiteKoodrinaten(windowWidth, titleTextSize.Width + 50);
            float titleLineY = 30 + titleTextSize.Height + 9;

            Pen pen = new Pen(Color.Gray, 1.4F);
            Brush titleLinesBrush = new LinearGradientBrush(titleTextRectangle, Color.Red, Color.OrangeRed, LinearGradientMode.Vertical);
            Point titleLinePoint1 = new Point(FloatToInt(titleLineX), FloatToInt(titleLineY));
            Point titleLinePoint2 = new Point(FloatToInt(titleLineX + titleTextSize.Width + 50), FloatToInt(titleLineY));

            g.DrawLine(pen, titleLinePoint1, titleLinePoint2);


            // Draw games
            int randLinks = 140;
            int randOben = 30 + FloatToInt(titleTextSize.Height) + 50;
            int abstand = 50;
            int reihe = 0;
            int spalte = 0;

            foreach (Spiele spiel in SpielVerwaltung.SpielListe)
            {
                // Titel in neue Zeile, sobald die Spalte voll ist
                if (spalte == 3)
                {
                    reihe++;
                    spalte = 0;
                }

                // Titel des Spiels malen
                string spielTitel = spiel.Titel;

                SizeF spielTitelSize = MeasureString(e, titleText, 16);

                // rand + reihe * titelhöhe und abstand + abstand
                int titelX = randLinks + spalte * 300 + abstand;
                int titelY = randOben + reihe * (FloatToInt(spielTitelSize.Height) + abstand);

                Rectangle spielTitelRectangle = new Rectangle(titelX, titelY, FloatToInt(spielTitelSize.Width), FloatToInt(spielTitelSize.Height));

                Brush spielTitelBrush = new SolidBrush(Color.Gray);
                Font spielTitelFont = new Font("Century Gothic", 16);

                g.DrawString(spielTitel, spielTitelFont, spielTitelBrush, titelX, titelY);

                // Spalte hochzählen
                spalte++;
            }
        }

        private int FloatToInt(float f)
        {
            return (int)Math.Round(f);
        }

        /// <summary>
        /// Breitenkoordinate für zentrierten Text
        /// </summary>
        /// <param name="fixWidth">Breite des Fensers</param>
        /// <param name="width">Breite des Objekts</param>
        /// <returns>Relative Breitenkoordinate</returns>
        private float ZentrierteBreiteKoodrinaten(float fixWidth, float width)
        {
            return (fixWidth / 2) - (width / 2);
        }

        /// <summary>
        /// Größe eines Textes ausgeben
        /// </summary>
        /// <param name="e">PaintEventArgs aus OnPaint</param>
        /// <param name="text">Text</param>
        /// <returns>Größe des Textes</returns>
        private SizeF MeasureString(PaintEventArgs e, string text, int fontSize)
        {
            Font stringFont = new Font("Century Gothic", fontSize);

            SizeF stringSize = e.Graphics.MeasureString(text, stringFont);

            return stringSize;
        }

    }
}
