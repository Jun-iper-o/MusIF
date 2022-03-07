using System;

  class Program{
    public static void Main(string[] args){
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-   Olá, você está criando sua Playlist   -");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Digite: Um número para a música, o nome, o gênero, o cantor, o tempo de duração e o ano de lançamento.");
    Console.WriteLine("-----------------------------------------");
    // mensagem inicial

    int id = int.Parse(Console.ReadLine());
    string Nome = Console.ReadLine();
    string Genero = Console.ReadLine();
    string Cantor = Console.ReadLine();
    string Tempo = (Console.ReadLine());
    int Lancamento = int.Parse(Console.ReadLine());
    Console.WriteLine("Id: "+ id);
    Console.WriteLine("Nome: "+ Nome);
    Console.WriteLine("Gênero: "+ Genero);
    Console.WriteLine("Cantor: "+ Cantor);
    Console.WriteLine("Tempo de duração: "+ Tempo );
    Console.WriteLine("Ano de lançamento: "+ Lancamento);
      
    // se o o usuario colocar todos os dados da música perguntar '- Você deseja adicionar outra música? -', se não perguntar - Gostaria de organizar sua Playlist? -, se não imprima as músicas adicionadas na ordem em que foram colocadas e no final perguntar - gostaria de listar novamente? -, se não mostrar a mensagem - Obrigada por usar o Musif ;p - e fecha o programa.
    
  int op = 1;
    do{
      
      op = Menu();
      switch(op){
        case 1 : Maior(); break;
        case 2 : Menor(); break;
        case 3 : Alfa(); break;
        case 4 : Artist(); break;
        case 5 : Gener(); break;
        case 6 : Year(); break;
        case 7 : Ident(); break;
      }
    } while (op != 1);
    // menu de organização de dados
  }

    public static int Menu(){
      Console.WriteLine();
      Console.WriteLine("- Digite o número correspondente a opção de organização que deseja -");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("01 - Da maior para menor; ");
      Console.WriteLine("02 - Da menor para maior; ");
      Console.WriteLine("03 - Ordem alfabética; ");
      Console.WriteLine("04 - Músicas do mesmo cantor; ");
      Console.WriteLine("05 - Músicas do mesmo gênero; ");
      Console.WriteLine("06 - Músicas do mesmo ano de lançamento; ");
      Console.WriteLine("07 - Número de identificação. ");
      Console.WriteLine("---------------------------------------");
      int op = int.Parse(Console.ReadLine());
      return op;
    // menu de listagem 
    }
    public static void Adicionar() {
    // adicionar mais músicas
    }
    public static void Maior() {
    // listar as músicas da maior pra menor
    }
    public static void Menor() {
    // listar as músicas da menor pra maior
    }
    public static void Alfa() {
    // listar as músicas em ordem alfabética
    }
    public static void Artist() {
    // listar as músicas que tem mesmo cantor
    }
    public static void Gener() {
    // listar as músicas que tem mesmo gênero
    }
    public static void Year() {
    // listar as músicas que tem mesmo ano de lançamento
    }
    public static void Ident() {
    // listar as músicas que tem mesmo número de identificação 
    }
  }
