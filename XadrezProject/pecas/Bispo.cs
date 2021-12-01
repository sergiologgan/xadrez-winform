using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.tabuleiro;

namespace XadrezProject.pecas
{
    public class Bispo : Peca
    {
        private Tabuleiro tabuleiro;
        public Bispo(Tabuleiro tabuleiro)
        {
            Initialize(EnumPieceType.BISPO, tabuleiro);
            this.tabuleiro = tabuleiro;
        }

        public void CasasDisponiveis()
        {
            int x = this.AddressLocation.X;
            int y = this.AddressLocation.Y;
            List<Casa> casas = new List<Casa>();

            //diagonal acima direita
            while (x < tabuleiro.QtdX && y < tabuleiro.QtdY)
            {
                x++;
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

            //diagonal acima esquerda
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (x > 0 && y < tabuleiro.QtdY)
            {
                x--;
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

            //diagonal abaixo esquerda
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (x > 0 && y > 0)
            {
                x--;
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

            //diagonal abaixo direita
            x = AddressLocation.X;
            y = AddressLocation.Y;
            while (x < tabuleiro.QtdX && y > 0)
            {
                x++;
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
