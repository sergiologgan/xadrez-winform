using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.tabuleiro;

namespace XadrezProject.pecas
{
    public class Rei : Peca
    {
        private Tabuleiro tabuleiro;
        public Rei(Tabuleiro tabuleiro)
        {
            Initialize(EnumPieceType.REI, tabuleiro);
            this.tabuleiro = tabuleiro;
        }

        public void CasasDisponiveis()
        {
            int x = this.AddressLocation.X;
            int y = this.AddressLocation.Y;
            List<Casa> casas = new List<Casa>();

            // acima horizontal esquerda
            if (x - 1 > 0 && y + 1 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x - 1, y + 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // acima horizontal direita
            if (x + 1 < tabuleiro.QtdX && y + 1 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x + 1, y + 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // abaixo horizontal esquerda
            if (x - 1 > 0 && y - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x - 1, y - 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // abaixo horizontal direita
            if (x + 1 < tabuleiro.QtdX && y - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x + 1, y - 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // horizontal esquerda
            if (x - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x - 1, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // horizontal direita
            if (x + 1 < tabuleiro.QtdX)
            {
                Casa c = tabuleiro.Casas[x + 1, y];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // acima
            if (y + 1 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x, y + 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

            // abaixo
            if (y - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x, y - 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (!c.Peca.IsProtected && c.Peca.Cor != this.Cor)
                {
                    casas.Add(c);
                    AttackedParts.Add(c.Peca);
                    c.Peca.Adversary = this;
                }
                else if (c.Peca.Cor == Cor)
                {
                    ProtectedParts.Add(c.Peca);
                }
            }

        }
    }
}
