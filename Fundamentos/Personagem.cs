using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public virtual void evoluir()
        {
            this.Nivel += 2;
            this.Forca *= 2;
            this.Inteligencia *= 2;
            this.Agilidade *= 2;
            Console.WriteLine();
            Console.WriteLine("O jogador " + this.Nome + " após a batalha evoluiu para o nível " + this.Nivel + ". Seus novos valores depois da conquista são: \nAgilidade: " + this.Agilidade + "\nInteligência: " + this.Inteligencia + "\nForça : " + this.Forca);
        }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Nivel + this.Vida) / 6;
            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Houve um dano na vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo atualmente corresponde a " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Houve um dano na vida do Atacante em " + danoDeVida);
                Console.WriteLine("O nível de vida do Atacante atualmente corresponde a " + this.Vida);

                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                if (this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + " derrotou o oponente!");
                    vencedor = true;
                    p.evoluir();
                }
                if (p.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + this.Nome + " derrotou o oponente!");
                    vencedor = true;
                    this.evoluir();
                }
            }
        }

    }
}
