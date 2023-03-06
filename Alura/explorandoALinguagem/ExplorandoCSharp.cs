using System;

class ExplorandoCSharp
{
    public static void Main(string[] args)
    {
        int numero = 6;

       Console.WriteLine( verificaFatorial(numero));
    

    }

   static public int verificaFatorial(int numero)
    {
       if(numero > 0)
        {
            return numero * verificaFatorial(numero - 1);
        }   else
        {
            return 1;
        }

    }
}
