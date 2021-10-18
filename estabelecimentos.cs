class estabelecimentos {
  private string _nome;
  private int _qtdIndicacao; 

  public string Nome {
    get {return _nome;}
    set {_nome = value;}
  }

  public int QtdIndicacao {
    get {return _qtdIndicacao;}
    set {_qtdIndicacao = value;}
  }

  public estabelecimentos(){}

  public void adicionarIndicacao() {
    _qtdIndicacao ++;
  }
}