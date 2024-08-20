using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Animal
    {
        // Declaração de Atributo
        public string Especie { get; set; }
        public string Nome { get; set; }

        // Declaração de um método

        public abstract void emitirSom();
    }
}
