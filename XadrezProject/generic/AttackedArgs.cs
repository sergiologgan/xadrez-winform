using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezProject.pecas;

namespace XadrezProject.generic
{
    /// <summary>
    /// Vê o que o adversário está atacando nas peças atuais
    /// </summary>
    public class AttackedArgs
    {
        /// <summary>
        /// Atacante
        /// </summary>
        public Peca Attacker { get; set; } // atacante
        /// <summary>
        /// Peças atacadas
        /// </summary>
        public List<Peca> PartsAttacked { get; set; } // pecas que está atacando
    }
}
