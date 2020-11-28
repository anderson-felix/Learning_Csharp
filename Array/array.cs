using System;
class Array{
    static void Main(){
        string[] veiculos={"Carro","Moto","Avião","Barco"};
        
        int[] n=new int [5] {111,222,333,444,555}; // Nesse tipo de array eu declaro o tamanho e posso atribuir os valores de cada posição aqui mesmo.

        int[] num={987,654,321}; // Aqui, o tamanho do array é definido automaticamente com base nos valores atribuídos para cada posição.
/* posições->       0   1   2   
        n[0]=11;
        n[1]=22;
        n[2]=33;  Outra maneira de atribuir valores no vetor 'n'
        n[3]=44;
        n[4]=55;
*/
        Console.WriteLine("Item na posição 2 do array (n) usando o 'new int' : {0}",n[1]);
        Console.WriteLine("Item na posição 2 do array (num) usando o array automático : {0}",num[1]);
        Console.WriteLine("Item na posição 2 do array (veiculos) usando o array automático : {0}",veiculos[1]);


    }
}