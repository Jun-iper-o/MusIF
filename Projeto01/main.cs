using System;

class Program{
  public static void Main(string[] args){
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("-   Olá, você está criando sua Playlist   -");
    Console.WriteLine("-------------------------------------------");

    int opA = 2;
    int opB = 0;

    do{
      opA = MenuA();
      switch(opA){
        case 1 : MusicaAdc(args); break;
        case 2 : break;
      } 
    } while (opA != 2);
    do{
      opB = MenuB();
      switch(opB){
        case 1 : Maior(); break;
        case 2 : Menor(); break;
        case 3 : Alfa(); break;
        case 4 : Artist(); break;
        case 5 : Gener(); break;
        case 6 : Year(); break;
        case 7 : Ident(); break;
      }
    } while (opB != 0);

  }
  public static void MusicaAdc(string[] args){
    Console.WriteLine();
    Console.WriteLine("-   Descreva a música   -");
    Console.WriteLine("Digite: Um número para a música, o nome, o gênero, o cantor, o tempo de duração e o ano de lançamento.");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string Nome = Console.ReadLine();
    Console.Write("Gênero: ");
    string Genero = Console.ReadLine();
    Console.Write("Cantor: ");
    string Cantor = Console.ReadLine();
    Console.Write("Tempo de duração: ");
    string Tempo = (Console.ReadLine());
    Console.Write("Ano de lançamento: ");
    int Lancamento = int.Parse(Console.ReadLine());


  }
  public static int MenuA(){
    Console.WriteLine("- Você deseja adicionar uma música? -");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("01 - Sim ");
    Console.WriteLine("02 - Não ");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine();
    Console.Write("Opção: ");

    int opA = int.Parse(Console.ReadLine());
    return opA;
  }
    public static int MenuB(){
    Console.WriteLine();
    Console.WriteLine("- Digite o número correspondente a opção de organização que deseja -");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("01 - Da maior para menor; ");
    Console.WriteLine("02 - Da menor para maior; ");
    Console.WriteLine("03 - Ordem alfabética; ");
    Console.WriteLine("04 - Músicas do mesmo cantor; ");
    Console.WriteLine("05 - Músicas do mesmo gênero; ");
    Console.WriteLine("06 - Músicas do mesmo ano de lançamento; ");
    Console.WriteLine("07 - Número de identificação; ");
    Console.WriteLine("00 - Não organizar. ");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine();
    Console.Write("Opção: ");

    int opB = int.Parse(Console.ReadLine());
    return opB;
  }

  public static void Listar(){

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
