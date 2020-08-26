using System;

class MainClass {
 
 
  public static int Conta (int n1,int n2,char op)
  {
    int N = 0 ;
    switch (op)
    {
      case '+' :
        N = n1 + n2;
        break;
      case '-' :
        N = n1 - n2 ;
        break;
      case '*' :
        N = n1 * n2 ;
        break;
      case '/' :
        N = n1 / n2 ;
        break;
    }
   return N;
  }
  public static void Main (string[] args) {
    int n1,n2;
    char op;
    Console.WriteLine("Digite o primeiro numero inteiro");
      n1  = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero inteiro");
      n2  = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha a operaçao");
      op = char.Parse(Console.ReadLine());

    double Total = Conta(n1,n2,op);
      Console.WriteLine("Sua conta é {0}",Total);
  }
}