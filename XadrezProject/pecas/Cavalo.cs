using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.enums;
using XadrezProject.tabuleiro;

namespace XadrezProject.pecas
{
    public class Cavalo : Peca
    {
        private Tabuleiro tabuleiro;
        public Cavalo(Tabuleiro tabuleiro)
        {
            Initialize(EnumPieceType.CAVALO, tabuleiro);
            this.tabuleiro = tabuleiro;
        }

        public void CasasDisponiveis()
        {
            int x = this.AddressLocation.X;
            int y = this.AddressLocation.Y;
            List<Casa> casas = new List<Casa>();

            // horizontal esquerda acima
            if (x - 2 > 0 && y + 1 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x - 2, y + 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // horizontal esquerda abaixo
            if (x - 2 > 0 && y - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x - 2, y - 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // horizontal direita acima
            if (x + 2 < tabuleiro.QtdX && y + 1 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x + 2, y + 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // horizontal direita abaixo
            if (x + 2 < tabuleiro.QtdX && y - 1 > 0)
            {
                Casa c = tabuleiro.Casas[x + 2, y - 1];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // vertical acima esquerda
            if (x - 1 > 0 && y + 2 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x - 1, y + 2];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // vertical acima direita
            if (x + 1 > 0 && y + 2 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x + 1, y + 2];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // vertical abaixo esquerda
            if (x - 1 > 0 && y - 2 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x - 1, y - 2];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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

            // vertical abaixo direita
            if (x + 1 > 0 && y - 2 < tabuleiro.QtdY)
            {
                Casa c = tabuleiro.Casas[x + 1, y - 2];
                if (c.IsEmpty)
                {
                    casas.Add(c);
                }
                else if (c.Peca.Cor != Cor)
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
