using System;
class Matriz{
    static void Main(){
        string[,] veiculos=new string[2,3]{{"Carro","Moto","Bike"},{"Avião","Barco","Helicóptero"}};
//                                                                     Cada bloco{} representa uma linha, cada item no bloco representa uma coluna.
        int[,] n=new int [5,3] {{1,2,3},{4,5,6},{7,8,9},{10,11,12},{13,14,15}}; 

        Console.WriteLine("Item na linha 0, coluna 2 da Matriz (veiculos) : {0}",veiculos[0,2]);
        Console.WriteLine("Item na linha 4, coluna 2 da Matriz (n) : {0}",n[4,2]);



    }
}