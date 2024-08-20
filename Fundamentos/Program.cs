using Fundamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        //Livro livro1 = new Livro();
        //livro1.Titulo = "Harry potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "J.K";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Programando em C#";
        //livro2.Editora = "Editora nova";
        //livro2.AnoLancamento = 1982;
        //livro2.Autor = "guxta castello";

        //Livro livro3 = new Livro();
        //livro3.Titulo = "pai rico pai pobre";
        //livro3.Editora = "Editora velha";
        //livro3.AnoLancamento = 1980;
        //livro3.Autor = "mano Cris";

        //preencher os atributos do objeto
        //Aluno aluno1 = new Aluno();
        //aluno1.Nome = "Rato";
        //aluno1.RM = "12345678";
        //aluno1.Email = "ratinProprio@gmail.com";
        //aluno1.Nascimento = new DateOnly(2000, 08, 14);

        ////imprimir na tela
        //Console.WriteLine("Aluno1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM : " + aluno1.RM);
        //Console.WriteLine("Email : " + aluno1.Email);
        //Console.WriteLine("Nascimento: : " + aluno1.Nascimento);


        //Console.WriteLine("");
        //Console.WriteLine("");


        //Aluno aluno2 = new Aluno();
        //aluno2.Nome = "ManoJJ";
        //aluno2.RM = "8765432";
        //aluno2.Email = "Manojotajota@gmail.com";
        //aluno2.Nascimento = new DateOnly(1876, 05, 24);

        ////imprimir na tela
        //Console.WriteLine("Aluno2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM : " + aluno2.RM);
        //Console.WriteLine("Email : " + aluno2.Email);
        //Console.WriteLine("Nascimento: : " + aluno2.Nascimento);

        //Console.WriteLine("");
        //Console.WriteLine("");


        //Aluno aluno3 = new Aluno();
        //aluno3.Nome = "Carlao";
        //aluno3.RM = "657483902";
        //aluno3.Email = "carlaodolavas@gmail.com";
        //aluno3.Nascimento = new DateOnly(1690, 11, 09);

        ////imprimir na tela
        //Console.WriteLine("Aluno3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM : " + aluno3.RM);
        //Console.WriteLine("Email : " + aluno3.Email);
        //Console.WriteLine("Nascimento: : " + aluno3.Nascimento);

        ////instanciar um objeto do tipo produto
        //Produto p1 = new Produto();
        //p1.Nome = "Coca-Cola";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;

        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;
        //p1.QuantidadeEstoque();

        //Console.WriteLine("==================================================================");
        //Console.WriteLine("==================================================================");

        //Carro carro1 = new Carro();
        //carro1.Modelo = "R8";
        //carro1.Marca = "Audi";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();
        //carro1.Acelerar();
        //carro1.Freiar();

        //Console.WriteLine("==================================================================");
        //Console.WriteLine("==================================================================");

        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.Nome = "cleito";
        //pessoa1.Idade = 23;

        //pessoa1.Envelhecer(5);
        //pessoa1.Envelhecer(2);
        //pessoa1.Envelhecer(6);


        //Console.WriteLine("==================================================================");
        //Console.WriteLine("==================================================================");

        //Funcionario f1 = new Funcionario();
        //f1.Nome = "Guadalberto";
        //f1.Idade = 23;
        //f1.Cargo = "jogador";
        //f1.Salario = 1000.00;
        //f1.ApresentarSe();

        //Animal animal1 = new Animal();

        //animal1.Especie = "Cachorro";

        //animal1.emitirSom();

        //Console.WriteLine("O animal " + animal1.Especie + " emitiu um som");
        Gato gato = new Gato();
        gato.Nome = "jorjin";
        Console.WriteLine(gato.Nome + " faz: ");

        gato.emitirSom();

        Porco porco = new Porco();
        porco.Nome = "al bilai";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();

        Galinha galinha = new Galinha();
        galinha.Nome = "Pupu";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();

    }
}