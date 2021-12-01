using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XadrezProject.pecas;
using XadrezProject.tabuleiro;

namespace XadrezProject
{
    public partial class Form1 : Form
    {
        private Casa[] casas;
        private List<Peca> pecas;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (this.casas != null)
            {
                for (int i = 0; i < casas.Length; i++)
                {
                    Casa casa = casas[i];
                    e.Graphics.FillRectangle(casa.Color, casa.Rectangle);
                    e.Graphics.DrawString($"{casa.AddressColumnName}{casa.Y}", new Font("Arial", 11, FontStyle.Bold), Brushes.White, casa.PixelLocation);                    
                }
                for (int i = 0; i < this.pecas.Count; i++)
                {
                    Peca p = this.pecas[i];
                    e.Graphics.DrawImage(p.Image, p.PixelLocation.X, p.PixelLocation.Y, 30, 30);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabuleiro tabuleiro = new Tabuleiro(50, 50, 8, 8, Color.White, Color.LightBlue);
            this.casas = tabuleiro.ObterArrayCasas();
            this.pecas = tabuleiro.Pecas;
            Bispo bispo = (Bispo)tabuleiro.Casas[2, 0].Peca;
            bispo.CasasDisponiveis();
            this.Invalidate();
        }
    }
}
