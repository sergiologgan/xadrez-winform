using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.pecas;

namespace XadrezProject.tabuleiro
{
    public class Tabuleiro
    {
        public Casa[,] Casas { get; set; }
        public List<Peca> Pecas { get; set; }
        public int QtdX { get; set; }
        public int QtdY { get; set; }

        public Tabuleiro(int sizeX, int sizeY, int qtdX, int qtdY, Color color1, Color color2)
        {
            Casa[,] casas = CriarCasas(sizeX, sizeY, qtdX - 1, qtdY - 1, color1, color2);
            List<Peca> pecas = CriarPecas();
            ConvertLocation(casas, ref pecas);
            Pecas = pecas;
            Casas = casas;
            QtdX = qtdX - 1;
            QtdY = qtdY - 1;
        }

        public Casa[,] CriarCasas(int sizeX, int sizeY, int qtdX, int qtdY, Color color1, Color color2)
        {
            Casa[,] casas = new Casa[qtdX+1, qtdY+1];
            int i = 0;
            int nsy = sizeY;
            int nsx = sizeX;
            for (int x = 0; x <= qtdX; x++)
            {
                nsx += sizeX;
                nsy = 0;
                for (int y = qtdY; y >= 0; y--)
                {
                    nsy += sizeY;
                    Point pixelLocation = new Point() { X = nsx, Y = nsy };
                    SolidBrush color = (i % 2 == 0) ? new SolidBrush(color1) : new SolidBrush(color2);
                    Casa casa = new Casa()
                    {
                        Rectangle = new Rectangle()
                        {
                            Location = pixelLocation,
                            Size = new Size(sizeX, sizeY)
                        },
                        AddressLocation = new Point(x, y),
                        PixelLocation = pixelLocation,
                        Color = color
                    };
                    casas[x, y] = casa;
                    i++;
                }
                i++;
            }
            return casas;
        }

        public List<Peca> CriarPecas()
        {
            string dir = Environment.CurrentDirectory;
            List<Peca> pecas = new List<Peca>()
            {
                new Torre(this) { Image = Image.FromFile($"{dir}/pecas/ptorre.png"), Cor = Cor.BLACK, AddressLocation = new Point(0, 7) },
                new Torre(this) { Image = Image.FromFile($"{dir}/pecas/ptorre.png"), Cor = Cor.BLACK, AddressLocation = new Point(7, 7) },
                new Cavalo(this) { Image = Image.FromFile($"{dir}/pecas/pcavalo.png"), Cor = Cor.BLACK, AddressLocation = new Point(1, 7) },
                new Cavalo(this) { Image = Image.FromFile($"{dir}/pecas/pcavalo.png"), Cor = Cor.BLACK, AddressLocation = new Point(6, 7) },
                new Bispo(this) { Image = Image.FromFile($"{dir}/pecas/pbispo.png"), Cor = Cor.BLACK, AddressLocation = new Point(2, 7) },
                new Bispo(this) { Image = Image.FromFile($"{dir}/pecas/pbispo.png"), Cor = Cor.BLACK, AddressLocation = new Point(5, 7) },
                new Rei(this) { Image = Image.FromFile($"{dir}/pecas/prei.png"), Cor = Cor.BLACK, AddressLocation = new Point(4, 7) },
                new Rainha(this) { Image = Image.FromFile($"{dir}/pecas/prainha.png"), Cor = Cor.BLACK, AddressLocation = new Point(3, 7) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(0, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(1, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(2, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(3, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(4, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(5, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(6, 6) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/ppeao.png"), Cor = Cor.BLACK, AddressLocation = new Point(7, 6) },
                new Torre(this) { Image = Image.FromFile($"{dir}/pecas/btorre.png"), Cor = Cor.WHITE, AddressLocation = new Point(0, 0) },
                new Torre(this) { Image = Image.FromFile($"{dir}/pecas/btorre.png"), Cor = Cor.WHITE, AddressLocation = new Point(7, 0) },
                new Cavalo(this) { Image = Image.FromFile($"{dir}/pecas/bcavalo.png"), Cor = Cor.WHITE, AddressLocation = new Point(1, 0) },
                new Cavalo(this) { Image = Image.FromFile($"{dir}/pecas/bcavalo.png"), Cor = Cor.WHITE, AddressLocation = new Point(6, 0) },
                new Bispo(this) { Image = Image.FromFile($"{dir}/pecas/bbispo.png"), Cor = Cor.WHITE, AddressLocation = new Point(2, 0) },
                new Bispo(this) { Image = Image.FromFile($"{dir}/pecas/bbispo.png"), Cor = Cor.WHITE, AddressLocation = new Point(5, 0) },
                new Rei(this) { Image = Image.FromFile($"{dir}/pecas/brei.png"), Cor = Cor.WHITE, AddressLocation = new Point(4, 0) },
                new Rainha(this) { Image = Image.FromFile($"{dir}/pecas/brainha.png"), Cor = Cor.WHITE, AddressLocation = new Point(3, 0) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(0, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(1, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(2, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(3, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(4, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(5, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(6, 1) },
                new Peao(this) { Image = Image.FromFile($"{dir}/pecas/bpeao.png"), Cor = Cor.WHITE, AddressLocation = new Point(7, 1) },
            };
            return pecas;
        }

        public Casa ObterCasa(int x, int y)
        {
            return Casas[x, y];
        }

        public Casa[] ObterArrayCasas()
        {
            return Casas.Cast<Casa>().ToArray();
        }



        public void ConvertLocation(Casa[,] casas, ref List<Peca> pecas)
        {
            for (int i = 0; i < pecas.Count; i++)
            {
                Peca p = pecas[i];
                p.PixelLocation = casas[p.AddressLocation.X, p.AddressLocation.Y].PixelLocation;
                casas[p.AddressLocation.X, p.AddressLocation.Y].Peca = p;
            }
        }

        public void ConvertLocation(Casa casa, Peca peca)
        {
            Casas[casa.AddressLocation.X, casa.AddressLocation.Y].Peca = peca;
            Casas[casa.AddressLocation.X, casa.AddressLocation.Y].Peca.PixelLocation = casa.PixelLocation;


        }
    }
}
