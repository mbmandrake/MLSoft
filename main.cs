using System;

class Program {
  public static void Main (string[] args) {
    privado posto1 = new privado("Posto 1", 0, 1, 1, "cartão" );
    publico posto2 = new publico("Posto 2", 0, 3, 3, "ES" );
    relatorio r = new relatorio();

    posto1.addIndicacao();
    posto2.addIndicacao();
    posto2.addIndicacao();

    r.addEstabelecimento(posto1);
    r.addEstabelecimento(posto2);

    r.exibirIndicacoes();

    r.exibirEstabelecimentos();
    
    r.exibirRecomendacao(posto1);
    r.exibirRecomendacao(posto2);
  }
}