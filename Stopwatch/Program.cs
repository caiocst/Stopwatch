﻿using System;
using System.Threading;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }


    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Quanto tempo deseja contar?");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("s = Segundo -> 10s = 10 segundos");
      Console.WriteLine("m = Minuto -> 10m = 10 minutos");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("-------------------------------------");


      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring((data.Length - 1), 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplicador = 1;

      if (type == 'm')
        multiplicador = 60;

      if (time == 0)
        System.Environment.Exit(0);

      PreStart(time * multiplicador);

    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Preparar...");
      Thread.Sleep(1000);
      Console.WriteLine("Apontar...");
      Thread.Sleep(1000);
      Console.WriteLine("Vai!");
      Thread.Sleep(1000);
      Start(time);
    }
    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Cronômetro finalizado.");
      Thread.Sleep(2500);
      Menu();
    }
  }
}