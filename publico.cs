class publico : estabelecimentos {
  string cidade {get; set;}

  public publico (string n, int qi, int x, int y, string c) : base (n, qi, x, y) {
    cidade = c;
  }
}