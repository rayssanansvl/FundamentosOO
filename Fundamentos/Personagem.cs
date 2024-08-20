using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        // Atributos
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        // Metodos

        public virtual void apresentarSe() { }
        public virtual void evoluir() { }
        public virtual int atacar()
        {
            int pontosAtaque = 0;

            pontosAtaque = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 5;
            return pontosAtaque;
        }
        public virtual void defender() { }

        public abstract void batalha() { }

    }
}
