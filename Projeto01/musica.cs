using System;

class Musica
{
    private int id;
    private string nome;
    private double tempo;
    public Descricao descricao;

    public Musica(int id, string nome, string genero, string cantor, double tempo, int lancamento)
    {
        this.id = id;
        this.nome = nome;
        this.tempo = tempo;
        this.descricao = new Descricao(id, genero, cantor, lancamento);
    }

    public void setId(int id)
    {
        this.id = id;
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public void setTempo(double tempo)
    {
        this.tempo = tempo;
    }
    public int getId()
    {
        return this.id;
    }
    public string getNome()
    {
        return this.nome;
    }
    public double getTempo()
    {
        return this.tempo;
    }
    public override string ToString()
    {
        return $"Nome: {this.getNome()}\nTempo: {this.getTempo()}";
    }
}

