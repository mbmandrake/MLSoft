using System;
using System.Collections.Generic;

class relatorio {
  private List<estabelecimentos> _estabelecimento = new List<estabelecimentos>();

  public void addEstabelecimento (estabelecimentos e) {
    _estabelecimento.Add(e);
  }

  public void exibirIndicacoes() {
    int maior = 0;
    string nMaior = "";

    foreach (estabelecimentos e in _estabelecimento){
      maior = e.QtdIndicacao;
      nMaior = e.Nome;

      if (e.QtdIndicacao > maior){
        maior = e.QtdIndicacao;
        nMaior = e.Nome;
      }
    }

    Console.WriteLine("O posto com maior indicação é o " + nMaior);
    Console.WriteLine("");

    foreach (estabelecimentos e in _estabelecimento){
      Console.WriteLine("{0} tem um total de {1} indicações ", e.Nome, e.QtdIndicacao);
    }
    
  }

  public void exibirEstabelecimentos() {
    Console.WriteLine("\nEstabelecimentos cadastrados: ");
    foreach (estabelecimentos e in _estabelecimento){
      Console.WriteLine(e.Nome);
    }
  } 

  public void qtdIndicacao (estabelecimentos e) {
    Console.WriteLine("\n{0} tem um total de {1} indicações ", e.Nome, e.QtdIndicacao);
  }

  public void exibirRecomendacao (estabelecimentos e) {
    
    Console.WriteLine("\nInforme sua posição X:");
    int x = int.Parse(Console.ReadLine());
    
    Console.WriteLine("\nInforme sua posição Y:");
    int y = int.Parse(Console.ReadLine());
    
    var distance = Math.Sqrt((Math.Pow(x - e.PosX, 2) + Math.Pow(y - e.PosY, 2)));
    
    if (distance <= 10){
      Console.WriteLine("\nO posto informado tem uma distância próxima a localização infomada.");
      Console.WriteLine("Com uma distância de aproximadamente {0} metros", Math.Round(distance, 2));
    }
    else if ( distance > 10 && distance <= 30){
      Console.WriteLine("\nO posto informado tem uma distância mediana a localização infomada.");
      Console.WriteLine("Com uma distância de aproximadamente {0} metros", Math.Round(distance, 2));
    }
    else if (distance > 30){
      Console.WriteLine("\nO posto informado tem uma distância alta a localização infomada.");
      Console.WriteLine("Com uma distância de aproximadamente {0} metros", Math.Round(distance, 2));
    }
  }
}