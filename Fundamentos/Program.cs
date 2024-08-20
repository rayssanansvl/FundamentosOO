using Fundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        ////Instanciar um Objeto do Tipo Aluno
        //Aluno aluno1 = new Aluno();
        //Aluno aluno2 = new Aluno();
        //Aluno aluno3 = new Aluno();
        //Aluno aluno4 = new Aluno();

        ////Preencher os atributos do objeto
        //aluno1.Nome = "Cristiano de Paula";
        //aluno1.RM = "1234TI";
        //aluno1.Email = "cristiano.paula@sp.senai.br";
        //aluno1.Nascimento = new DateOnly(1981, 07, 16);

        ////Imprimir na Tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("E-mail: " + aluno1.Email);
        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("==============================================");

        ////Preencher os atributos do objeto
        //aluno2.Nome = "Rayssa Nanclares da Silveira";
        //aluno2.RM = "1234TI";
        //aluno2.Email = "rayssa.silveira@aluno.senai.br";
        //aluno2.Nascimento = new DateOnly(2007, 12, 19);

        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("E-mail: " + aluno2.Email);
        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("==============================================");

        //aluno3.Nome = "Ítalo Francesco";
        //aluno3.RM = "1234TI";
        //aluno3.Email = "italo.francesco@aluno.senai.br";
        //aluno3.Nascimento = new DateOnly(2008, 03, 28);

        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("E-mail: " + aluno3.Email);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("==============================================");

        //aluno4.Nome = "Emanuelly Vitoria dos Santos Lima";
        //aluno4.RM = "1234TI";
        //aluno4.Email = "emanuelly.lima@aluno.senai.br";
        //aluno4.Nascimento = new DateOnly(2008, 01, 25);

        //Console.WriteLine("Aluno 4");
        //Console.WriteLine("Nome: " + aluno4.Nome);
        //Console.WriteLine("RM: " + aluno4.RM);
        //Console.WriteLine("E-mail: " + aluno4.Email);
        //Console.WriteLine("Nascimento: " + aluno4.Nascimento);
        //Console.WriteLine("==============================================");


        ////Instanciar um Objeto do tipo Produto
        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;
        ////Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;
        ////Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //// Instanciar um objeto do tipo Carro
        //Carro carro1 = new Carro();

        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //Pessoa pessoa1 = new Pessoa();

        //pessoa1.Nome = "Rayssa";
        //pessoa1.Idade = 16;

        //pessoa1.Envelhecer(1);
        //pessoa1.Envelhecer(1);

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Luis Santos";
        //func1.Idade = 20;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 1400.00;
        //func1.ApresentarSe();

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //// Instanciar um objeto
        //Animal animal1 = new Animal();

        //// Inserindo dados no atributo;
        //animal1.Especie = "Cachorro";

        ////Chamando o Metodo do objeto
        //animal1.emitirSom();

        //// Imprimindo a informação na tela
        //Console.WriteLine("O animal " + animal1.Especie + " emitiu um som.");

        //Gato gato = new Gato();
        //gato.Nome = "Frajola";
        //Console.WriteLine(gato.Nome + " faz: ");
        //gato.emitirSom();

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //Galinha galinha = new Galinha();
        //galinha.Nome = "Lilica";
        //Console.WriteLine(galinha.Nome + " faz: ");
        //galinha.emitirSom();

        //Console.WriteLine("==============================================");
        //Console.WriteLine();

        //Porco porco = new Porco();
        //porco.Nome = "Peppa";
        //Console.WriteLine(porco.Nome + " faz: ");
        //porco.emitirSom();

        Mago merlin = new Mago();

        merlin.Nome = "Dumbledore";
        merlin.Vida = 100;
        merlin.Inteligencia = 87;
        merlin.Agilidade = 55;
        merlin.Forca = 62;
        merlin.Nivel = 1;

        Elfo elfo = new Elfo();
        elfo.Nome = "Hobbit";
        elfo.Vida = 100;
        elfo.Inteligencia = 83;
        elfo.Agilidade = 60;
        elfo.Forca = 90;
        elfo.Nivel = 1;

        merlin.apresentarSe();
        elfo.apresentarSe();

        merlin.batalhar(elfo);
    }
}