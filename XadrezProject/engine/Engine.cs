using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.pecas;
using XadrezProject.tabuleiro;

namespace XadrezProject.engine
{
    public class Engine
    {
        private Tabuleiro tabuleiro;
        public Engine(Tabuleiro tabuleiro)
        {
            this.tabuleiro = tabuleiro;
        }

        public void Engine01()
        {
            
            IEnumerable<Peca> pecas = tabuleiro.Pecas.Where(x => x.Cor == enums.Cor.WHITE);

            var t = pecas.ElementAt(0);

        }
        public void Engine02()
        {

        }
    }
}
