using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
       {
          
             int Numero;
             string NumExt, tecla;
           do
             {
               Console.Clear();
               Console.WriteLine("  -----Numero por extenso-----\n");
               Console.Write("Entre com o numero a ser escrito : ");
               Numero = Convert.ToInt32(Console.ReadLine());
               NumExt = Numero.ToWords();
                                   
                   
              int tamanho = NumExt.Length;               //tamanho do string
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              string lin = new string('*', tamanho+4);   // monta linha de *
              string Esp = new string(' ', tamanho);     // espaço vazio onde sera impresso o titulo
              Console.WriteLine(lin);                    // linha superior
              Console.WriteLine("* "+Esp+" *");
             
              Console.WriteLine(lin);                    // linha inferior

              Console.ResetColor();
              Console.ForegroundColor = ConsoleColor.White;
              Console.SetCursorPosition(2,4);
              Console.WriteLine(NumExt);                 // Imprime o numero dentro da caixa
              Console.SetCursorPosition(0,8);
              Console.WriteLine(lin);
              Console.SetCursorPosition(0,7);

               Console.ResetColor();
               Console.Write("\n\n(S)air?:");           
               tecla = Console.ReadLine().ToUpper();
              }
               while (tecla != "S" );
               Console.Clear();
            
       }     
    }
}

             
           
        


