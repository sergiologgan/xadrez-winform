using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.generic;
using XadrezProject.tabuleiro;

namespace XadrezProject.pecas
{
    public class Peca
    {
        public void Initialize(EnumPieceType pecatype, Tabuleiro tabuleiro)
        {
            PieceType = pecatype;
            AttackedParts = new List<Peca>();
            ProtectedParts = new List<Peca>();
            Adversary = new Peca();
        }
        private Tabuleiro tabuleiro;
        public Image Image { get; set; }
        public Point AddressLocation { get; set; }
        public Point PixelLocation { get; set; }
        public Cor Cor { get; set; }
        public bool IsProtected { get => (Adversary is null) ? true : false; }
        public EnumPieceType PieceType { get; set; }

        public List<Peca> ProtectedParts { get; set; } // peças que está protegendo
        public List<Peca> AttackedParts { get; set; } // peças atacadas
        public Peca Adversary { get; set; } // Adversário que está atacando essa peça

        public void MoveTo(Peca peca, string point)
        {
            int y = (int)point[1];
            int x = (char.ToLower(point[0]) - 64);
            tabuleiro.Casas[x, y].Peca = peca;
            tabuleiro.Casas[x, y].Peca.PixelLocation = tabuleiro.Casas[x, y].PixelLocation;
        }

        public void MoveTo(Peca peca, Point point)
        {
            tabuleiro.Casas[peca.AddressLocation.X, peca.AddressLocation.Y].Peca = null;
            tabuleiro.Casas[point.X, point.Y].Peca = peca;
            tabuleiro.Casas[point.X, point.Y].Peca.PixelLocation = tabuleiro.Casas[point.X, point.Y].PixelLocation;
        }
    }
}
