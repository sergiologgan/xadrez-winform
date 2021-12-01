using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.tabuleiro;

namespace XadrezProject.pecas
{
    public class Torre : Peca
    {
        private Tabuleiro tabuleiro;
        public Torre(Tabuleiro tabuleiro)
        {
            Initialize(EnumPieceType.TORRE, tabuleiro);
            this.tabuleiro = tabuleiro;
        }

        public void CasasDisponiveis()
        {
            int x = this.AddressLocation.X;
            int y = this.AddressLocation.Y;
            List<Casa> casas = new List<Casa>();

            //horizontal direita
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (x < tabuleiro.QtdX)
            {
                x++;
                Casa c = tabuleiro.Casas[x, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                    break;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                    break;
                }
            }

            //horizontal esquerda
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (x > 0)
            {
                x--;
                Casa c = tabuleiro.Casas[x, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                    break;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                    break;
                }
            }

            //vertical up
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (y < tabuleiro.QtdY)
            {
                y++;
                Casa c = tabuleiro.Casas[x, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                    break;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                    break;
                }
            }

            //vertical down
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (y > 0)
            {
                y--;
                Casa c = tabuleiro.Casas[x, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                    break;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                    break;
                }
            }
        }
    }
}
