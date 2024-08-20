using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o Mago: " + this.Nome + " eu possuo atualmente o nível: " + this.Nivel + " ,tenho uma força equivalente a: " + this.Forca + " ,minha agilidade corresponde a: " + this.Agilidade + " ,e a inteligencia é de: " + this.Inteligencia + " por fim, a minha vida tem um total de: " + this.Vida);
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
        }
        public override void evoluir()
        {
            Console.WriteLine("O personagem ")
        }
    }
}
