using System;

class Descricao{
  private int id;
  private string cantor;
  private string genero;
  private int lancamento;
  
  public Descricao (int id, string cantor, string genero, int lancamento){
    this.id = id;
    this.cantor = cantor;
    this.genero = genero;
    this.lancamento = lancamento;
  }

  public void setId(int id){
        this.id = id;
  }
  public void setCantor(string cantor){
        this.cantor = cantor;
  }
  public void setGenero(string genero){
        this.genero = genero;
  }
  public void setLancamento (int lancamento){
        this.lancamento = lancamento;
  }
  public int getId(){
    return this.id;
  }
  public string getCantor(){
    return this.cantor;
  }
  public string getGenero(){
    return this.genero;
  }
  public int getLancamento(){
    return this.lancamento;
  }
  public override string ToString(){
    return $"{this.getId()} - {this.getCantor()} - {this.getGenero()} - {this.getLancamento()}";
  }
}
