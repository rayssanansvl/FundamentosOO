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
        public string Apresentar { get; set; }
        public int Evoluir { get; set; }
        public int Atacar { get; set; }
        public int Defender { get; set; }

        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou:" + this.Nome + " eu possuo o nível:" + this.Nivel + " tenho uma força equivalente a:" + this.Forca + " minha agilidade corresponde a:" + this.Agilidade + " e a inteligencia é de:" + this.Inteligencia + " por fim, a minha vida é um total de:" + this.Vida);
        }

        public override void atacar()
        {
            this.Atacar;
            Console.WriteLine("O meu poder de ataque, consumiu cerca de");
        }

        public override void batalha()
        {

        }

        public override void defender()
        {

        }

        public override void evoluir()
        {

        }
    }
}
