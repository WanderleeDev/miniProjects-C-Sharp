// See https://aka.ms/new-console-template for more information

System.Random  random = new();

string takeCard = "y";
int limitNumber = 21;
int cpuCard = 0;
int playerCard = 0;
int card = new Random().Next(1, 11);
bool initGame;;

Console.WriteLine("Blackjack en C#");

Console.WriteLine("¿Comenzar a jugar? (y or n)");
initGame = Console.ReadLine()?.ToLower() == "y";

if (initGame)
{
  do
  {
    Console.WriteLine("1. Tomar un carta (y)");
    Console.WriteLine("2. No tomar carta (n)");
    takeCard = Console.ReadLine()?.ToLower();

    if (takeCard == "y")
    {
      playerCard += card;
      Console.WriteLine($"Tomaste una carta, tu carta es {card} y tu puntaje es {playerCard}");
      
      Console.WriteLine("La CPU tomo una carta también");
      cpuCard += card;
    }
    else if (takeCard == "n")
    {
      Console.WriteLine("Finalizando juego");
    }
    else
    {
      Console.WriteLine("Entrada no reconocida. Entradas validas (y) (n)");
    }

  } while (takeCard == "y");

  if (playerCard > limitNumber)
  {
    Console.WriteLine("Has superado el limite de 21");
  }
  else if (playerCard > cpuCard && playerCard <= limitNumber)
  {
    Console.WriteLine($"Ganaste con el número {playerCard}");
  }
  else if(playerCard == cpuCard)
  {
    Console.WriteLine($"Empataste con la cpu ambos tienen {cpuCard}");
  }
  else  {
    Console.WriteLine("Perdiste");
  }
}
else 
{
  Console.WriteLine("Finalizando juego");
}
