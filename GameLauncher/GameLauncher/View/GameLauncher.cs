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

        private List<DrawedButton> DrawedButtons
        {
            get;
            set;
        }

        public GameLauncher()
        {
            InitializeComponent();

            this.ResizeRedraw = true;

            SpielVerwaltung = new SpielVerwaltung();
            DrawedButtons = new List<DrawedButton>();
        }

        Graphics g = null;

        /// <summary>
        /// Fenster malen
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            g = e.Graphics;

            PaintThis();
        }

        private void PaintThis()
        {
            DrawedButtons.Clear();
            g.Clear(SystemColors.Control);

            float windowHeight = this.Size.Height;
            float windowWidth = this.Size.Width;

            // Title text
            string titleText = "Deine Spiele";

            SizeF titleTextSize = MeasureString(g, titleText, 24);
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

                SizeF spielTitelSize = MeasureString(g, titleText, 16);

                // rand + reihe * titelhöhe und abstand + abstand
                int titelX = randLinks + spalte * 300 + abstand;
                int titelY = randOben + reihe * (FloatToInt(spielTitelSize.Height) + abstand);

                int rectX = titelX - 10;
                int rectY = titelY - 10;
                int rectWidth = 260 + 10 + 10;
                int rectHeight = FloatToInt(spielTitelSize.Height) + 10 + 10;

                Rectangle spielTitelRectangle = new Rectangle(rectX, rectY, rectWidth, rectHeight);

                Brush spielTitelBrush = new SolidBrush(Color.Gray);
                Font spielTitelFont = new Font("Century Gothic", 16);

                g.DrawString(spielTitel, spielTitelFont, spielTitelBrush, titelX, titelY);
                g.DrawRectangle(new Pen(Color.Gray, 1.4F), spielTitelRectangle);

                DrawedButton drawedButton = new DrawedButton();
                drawedButton.X = rectX;
                drawedButton.Y = rectY;
                drawedButton.Width = rectWidth;
                drawedButton.Height = rectHeight;
                drawedButton.Spiel = spiel;

                DrawedButtons.Add(drawedButton);

                // Spalte hochzählen
                spalte++;
            }

            this.AutoScrollMinSize = new Size(0, randOben + reihe * (40 + abstand));
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
        private SizeF MeasureString(Graphics g, string text, int fontSize)
        {
            Font stringFont = new Font("Century Gothic", fontSize);

            SizeF stringSize = g.MeasureString(text, stringFont);

            return stringSize;
        }

        private void GameLauncher_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Starten eines Spiels durch anklicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLauncher_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            foreach (DrawedButton button in DrawedButtons)
            {
                if (x >= button.X &&
                    y >= button.Y &&
                    x <= button.Width + button.X &&
                    y <= button.Height + button.Y)
                {
                    this.WindowState = FormWindowState.Minimized;
                    SpielVerwaltung.SpielStarten(button.Spiel.Titel);
                    break;
                }
            }
        }

        /// <summary>
        /// Hover-Effekt beim überfliegen von gezeichneten Schaltflächen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLauncher_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            foreach (DrawedButton button in DrawedButtons)
            {
                if (x >= button.X &&
                    y >= button.Y &&
                    x <= button.Width + button.X &&
                    y <= button.Height + button.Y)
                {
                    Cursor.Current = Cursors.Hand;
                }
                else
                {
                    if (Cursor.Current == Cursors.Hand)
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        private void neuesSpielButton_Click(object sender, EventArgs e)
        {
            NeuesSpielView neuesSpielView = new NeuesSpielView();
            DialogResult result = neuesSpielView.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                neuesSpielView.Close();
            }
            else if (result == DialogResult.OK)
            {
                PaintThis();
                neuesSpielView.Close();
            }
        }
    }
}
