using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");

        int num = 20;
                         // O operador BitWise << DOBRA o valor da variável, e o >> divide o valor da variável pela METADE.
        num = num << 2;                                         
                         // O numero inserido após o operador de BitWise vai determinar a quantidade de vezes que a variável vai dobrar ou dividir.

        Console.WriteLine("Resultado usando BitWise : {0}", num);

    }
}