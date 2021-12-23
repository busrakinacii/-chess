using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        Button[,] Tahta = new Button[6, 6];
        bool ProgramAcilisi = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yerlestir();

        }

        private void Yerlestir()
        {
            for (int ii = 0; ii < 6; ii++)
            {
                for (int jj = 0; jj < 6; jj++)
                {
                    if (ProgramAcilisi)
                    {
                        Tahta[ii, jj] = new Button();
                        this.Controls.Add(Tahta[ii, jj]);
                    }

                    Tahta[ii, jj].Width = 80;
                    Tahta[ii, jj].Height = 80;
                    Tahta[ii, jj].Left = (jj * 80);
                    Tahta[ii, jj].Top = (ii * 80);

                    if (ii % 2 == 1)        // Satırlar: 1, 3, 5, 7.
                    {
                        if (jj % 2 == 1)    // Tek sütunlar.
                        {
                            Tahta[ii, jj].BackColor = Color.White;
                        }
                        else                // Çift sütunlar.
                        {
                            Tahta[ii, jj].BackColor = Color.DarkGray;
                        }
                    }
                    else                    // Satırlar: 0, 2, 4, 6.
                    {
                        if (jj % 2 == 1)    // Tek sütunlar.
                        {
                            Tahta[ii, jj].BackColor = Color.DarkGray;
                        }
                        else                // Çift sütunlar.
                        {
                            Tahta[ii, jj].BackColor = Color.White;
                        }
                    }

                    Tahta[ii, jj].BackgroundImage = System.Drawing.Image.FromFile(@"Bos.png");
                    Tahta[ii, jj].BackgroundImageLayout = ImageLayout.Stretch;

                    Point koordinat = new Point();
                    koordinat.X = ii;
                    koordinat.Y = jj;
                    Tahta[ii, jj].Tag = (Object)koordinat;
                }
            }

            if (ProgramAcilisi)
            {
                ProgramAcilisi = false;
            }

            // Piyonlar:
           
                Tahta[0, 2].BackgroundImage = System.Drawing.Image.FromFile(@"Piyon_Siyah.png");
                Tahta[0, 4].BackgroundImage = System.Drawing.Image.FromFile(@"Piyon_Siyah.png");

                Tahta[5, 2].BackgroundImage = System.Drawing.Image.FromFile(@"Piyon_Beyaz.png");
                Tahta[5, 4].BackgroundImage = System.Drawing.Image.FromFile(@"Piyon_Beyaz.png");
               // Kaleler:
              Tahta[0, 0].BackgroundImage = System.Drawing.Image.FromFile(@"Kale_Siyah.png");
              Tahta[5, 5].BackgroundImage = System.Drawing.Image.FromFile(@"Kale_Beyaz.png");
    
              // Vezir ve Şah:
              Tahta[0, 3].BackgroundImage = System.Drawing.Image.FromFile(@"Sah_Siyah.png");
              Tahta[5, 3].BackgroundImage = System.Drawing.Image.FromFile(@"Sah_Beyaz.png");
        }
 
      
        private void sifirla_Click(object sender, EventArgs e)
        {
            Yerlestir();
        }

    }
}