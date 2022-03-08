using System;
using System.Collections.Generic;

class Program
{
    private static List<Musica> Musicas = new List<Musica>();

    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-   Olá, você está criando sua Playlist   -");
        Console.WriteLine("-------------------------------------------");

        int opA = 2;
        int opB = 0;

        do
        {
            opA = MenuA();
            switch (opA)
            {
                case 1:
                  MusicaAdc();
                  break;
                case 2:
                  break;
            }
        } while (opA != 2);
        do
        {
            opB = MenuB();
            switch (opB)
            {
                case 1: ListarMusicasMaiorParaMenor(); break;
                case 2: ListarMusicasMenorParaMaior(); break;
                case 3: ListarMusicasOrdenadas(); break;
                case 4: ListarMusicasMesmoArtista(); break;
                case 5: ListarMusicasMesmoGenero(); break;
                case 6: ListarMusicasMesmoAno(); break;
                case 7: ListarMusicasMesmoId(); break;
            }
        } while (opB != 0);

    }
    public static void MusicaAdc()
    {
        Console.WriteLine();
        Console.WriteLine("-   Descreva a música   -");
        Console.WriteLine("Digite: Um número para a música, o nome, o gênero, o cantor, o tempo de duração e o ano de lançamento.");
        Console.WriteLine();
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string Nome = Console.ReadLine();
        Console.Write("Gênero: ");
        string Genero = Console.ReadLine();
        Console.Write("Cantor: ");
        string Cantor = Console.ReadLine();
        Console.Write("Tempo de duração: ");
        double Tempo = double.Parse(Console.ReadLine());
        Console.Write("Ano de lançamento: ");
        int Lancamento = int.Parse(Console.ReadLine());

        Musica musica = new Musica(id, Nome, Genero, Cantor, Tempo, Lancamento);

        AdicionarMusica(musica);
    }
    public static int MenuA()
    {
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
    public static int MenuB()
    {
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

    public static void ListarMusicas()
    {
      Musicas.ForEach(musica => {
        Console.WriteLine($"Nome: {musica.getNome()}");
      });
    }

    public static void AdicionarMusica(Musica musica)
    {
      Musicas.Add(musica);
    }
    public static void ListarMusicasMaiorParaMenor(int maior)
    {
      var musicasPorMaior = Musicas.Select(musica => musica.descricao.getTempo() == maior);

      musicasPorMaior.ForEach(musica => {
        Console.WriteLine(musica.ToString());
      });
    }
    public static void ListarMusicasMenorParaMaior(int menor)
    {
      var musicasPorMenor = Musicas.Select(musica => musica.descricao.getTempo() == menor);

      musicasPorMenor.ForEach(musica => {
        Console.WriteLine(musica.ToString());
      });
    }
    public static void ListarMusicasOrdenadas()
    {
      var musicasOrdenadas = Musicas.Sort();

      musicasOrdenadas.ForEach(musica => {
        Console.WriteLine($"Nome da Música: {musica.getNome()}")
        Console.WriteLine($"Tempo de duração: {musica.getTempo()}")
      });
    }
    public static void ListarMusicasMesmoArtista(string artist)
    {
      var musicasPorArtista = Musicas.Select(musica => musica.descricao.getCantor() == artist);

      musicasPorArtista.ForEach(musica => {
        Console.WriteLine(musica.ToString($"Cantor: {descricao.getCantor()}"));
      });
    }
    public static void ListarMusicasMesmoGenero(string gener)
    {
      var musicasPorGenero = Musicas.Select(musica => musica.descricao.getGenero() == gener);

      musicasPorGenero.ForEach(musica => {
        Console.WriteLine(musica.ToString($"Gênero: {descricao.get()}"));
      });
    }
    public static void ListarMusicasMesmoAno(int ano)
    {
      var musicasPorAno = Musicas.Select(musica => musica.descricao.getLancamento() == ano);

      musicasPorAno.ForEach(musica => {
        Console.WriteLine(musica.ToString($"Ano de lançamento: {descricao.getLancamento()}"));
      });
    }
    public static void ListarMusicasMesmoId(int ident)
    {
      var musicasPorId = Musicas.Select(musica => musica.descricao.getId() == ident);

      musicasPorId.ForEach(musica => {
        Console.WriteLine(musica.ToString($"id: {musica.getId()}"));
      });
    }
}
