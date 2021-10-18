using System;
using System.Collections.Generic;

class relatorio {
  private List<estabelecimentos> _estabelecimento {get; set;}

  public void exibirEstabelecimentos() {
    foreach (estabelecimentos e in _estabelecimento){
      Console.WriteLine(e.Nome);
    }
  } 

  public void exibirIndicacoes() {
    foreach (estabelecimentos e in _estabelecimento){
      Console.WriteLine(e.Nome + " : " + e.QtdIndicacao);
    }
  }
}