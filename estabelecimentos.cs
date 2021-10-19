class estabelecimentos {
  private string _nome;
  private int _qtdIndicacao; 
  private int _posX;
  private int _posY;

  public estabelecimentos (string n, int qi, int x, int y) {
    _nome = n;
    _qtdIndicacao = qi;
    _posX = x;
    _posY = y;
  }

  public string Nome {
    get {return _nome;}
    set {_nome = value;}
  }

  public int QtdIndicacao {
    get {return _qtdIndicacao;}
    set {_qtdIndicacao = value;}
  }

  public int PosX {
    get {return _posX;}
    set {_posX = value;}
  }

  public int PosY {
    get {return _posY;}
    set {_posY = value;}
  }

  public void addIndicacao() {
    _qtdIndicacao ++;
  }

  public virtual void editCidade (string n) {}
}