namespace EXERCICIOS;

class Program
{
  static void Main(string[] args)
  { 
    bool controle = true;

     while(controle)
     {   
        Console.WriteLine("//--------- MENU ---------\\");
        Console.WriteLine("| ESCOLHA O EXERCICIO:      |");
        Console.WriteLine("| 1°) MAIOR OU MENOR IDADE  |");
        Console.WriteLine("| 2°) NEGATIVO OU POSITIVO  |");
        Console.WriteLine("| 3°) CALCULAR A MEDIA      |");
        Console.WriteLine("| 4°)                       |");
        Console.WriteLine("| 5°)                       |");
        Console.WriteLine("| 6°)                       |");
        Console.WriteLine("| 7°)                       |");
        Console.WriteLine("\\_________________________//");
        Console.WriteLine();
        Console.WriteLine("==============================");

        int opcao = int.Parse(Console.ReadLine());
          switch(opcao)
          { 
            //EXERCICIO 1
            //Crie um programa que:
            //Peça a idade do usuário
            //Verifique se ele é maior ou menor de idade
            //Mostre uma mensagem correspondente            
                
            case 1:
              int idade;
              Console.WriteLine("=======================");
              Console.WriteLine("| MAIOR E MENOR IDADE |");
              Console.WriteLine("=======================");
              Console.ReadLine();

              Console.WriteLine("DIGITE SUA IDADE:");
              idade = int.Parse(Console.ReadLine());

              if(idade >= 18)
              {
                Console.WriteLine("Você é maior de idade");  
              }
              else
              {
                Console.WriteLine("Você é menor de idade");
              }
              Console.ReadLine();

            break;
            
            case 2:
              //Crie um programa que:
              //Leia um número inteiro
              //Informe se o número é:
              //Positivo
              //Negativo
              //Zero
              
              Console.WriteLine("========================");
              Console.WriteLine("| NEGATIVO OU POSITIVO |");
              Console.WriteLine("========================");
              Console.ReadLine();
              int num;
              Console.WriteLine("INFORME UM NUMERO");
              num = int.Parse(Console.ReadLine());

              if(num < 0)
                {
                  Console.WriteLine($"O número {num} é Negativo");
                }
              else if(num == 0)
                {
                  Console.WriteLine($"{num} não é positivo nem negativo.");
                }  
              else
                {
                  Console.WriteLine($"O número {num} é positivo");
                } 
            break;

            case 3:
                // Crie um programa que:
                // Leia duas notas (0 a 10)
                // Calcule a média
                // Se a média for:
                // ≥ 7 → “Aprovado”
                // ≥ 5 e < 7 → “Recuperação”
                // < 5 → “Reprovado”

              Console.WriteLine("======================");
              Console.WriteLine("| CALCULANDO A MEDIA |");
              Console.WriteLine("======================");
              Console.ReadLine();

              double PrimeiraNota, SegundaNota, media;
            

              Console.WriteLine("DIGITE SUA PRIMEIRA NOTA:");
              PrimeiraNota = double.Parse(Console.ReadLine());

              Console.WriteLine("DIGITE SUA SEGUNDA NOTA:");
              SegundaNota = double.Parse(Console.ReadLine());

              if(PrimeiraNota > 10 || SegundaNota > 10)
                {
                  Console.WriteLine("ERROR: Apenas notas ate 10");
                }
              
                  media = (PrimeiraNota + SegundaNota) / 2;

              Console.WriteLine($"Primeira nota:{PrimeiraNota} Segunda Nota:{SegundaNota}");
              Console.WriteLine($"MEDIA:{media}"); 

              

              if(media > 7)
                {
                  Console.WriteLine("Aprovado"); 
                }
              else if(media > 5 && media < 7)
                {
                  Console.WriteLine("Recuperação");
                }
              else if(media < 5)
                {
                  Console.WriteLine("Reprovado");
                } 
               Console.ReadLine(); 


              break;            

             

         }        
     }     
                    
  }
}  
