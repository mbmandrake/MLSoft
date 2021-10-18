class privado : estabelecimentos, Ipagamento {
  public string meioPagamento {get; set;}
  
  public privado (string n, int qi, int x, int y, string mp) : base (n, qi, x, y) {
    meioPagamento = mp;
  }
}