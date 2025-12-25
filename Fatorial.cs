using System;

class Program 
{
  static void Main(string[] args){

    //CALCULANDO O FATORIAL DE UM NUMERO USANDO O LAÇO FOR
    
    int numero, contador, fatorial;

    fatorial = 1;

    Console.WriteLine("DIGITE UM NUMERO POSITIVO:");
    numero = int.Parse(Console.ReadLine());

    if(numero < 0)
    {
       Console.WriteLine("<<<<<<<<<<<<<< [ERROR] >>>>>>>>>>>>>");
       Console.WriteLine("====================================");
       Console.WriteLine("APENAS NUMEROS POSITIVOS SÃO ACEITOS"); 
    }
    else if(numero == 0 || numero == 1 )
    {
      Console.WriteLine($"O fatorial de {numero} é 1");   
    }
        else
        {
            for(contador = numero;contador >= 1;contador--)
            {
                fatorial = fatorial * contador;
            }
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
        }    
 }
}
 

