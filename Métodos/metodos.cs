using System;
class Metodos
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[10];
        int[,] matriz = new int[2, 7] { { 10, 20, 30, 40, 50, 60, 70 }, { 15, 25, 35, 45, 55, 65, 75 } };

        Random teste = new Random();// Criando a variável do tipo 'Random' de nome 'teste'
        for (int i = 0; i < vetor1.Length; i++)
        {                              // Percorrendo todas as posições do array 'vetor1'
            vetor1[i] = teste.Next(20);// Nas posições percorridas em 'i', se usa o metodo 'Next' em 'Random teste' para adicinar um valor randômico
        }//                                                                   com um valor máximo estipuladonos parâmetros, também se pode indicar
        Console.WriteLine("\tRandom \nVetor1");//                                            os tamanho máximo e minimo pra esse método. ex:(5,20)
        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("--------------------------");

        //public static BinarySearch(array,valor);
        Console.WriteLine("\tBinarySearch");//O BinarySearch é um método da classe Array que verifica se um determinado valor se encontra em alguma  
        int procurado = 3; //                                   posição do vetor, com base em uma variável que contenha um valor para ser procurado
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("O valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("----------------------------------");

        //public void Copy(Array_Origem,Array_destino,qtde_elementos);
        Console.WriteLine("\tCopy \nVetor2");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int i in vetor2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("--------------------------");

        //public void CopyTo(Array_destino,a_partir_desta_pos);
        Console.WriteLine("\tCopyTo \nVetor3");
        vetor1.CopyTo(vetor3, 5);
        foreach (int i in vetor3)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("--------------------------");

        //public long GetLongLength(dimensão_da_matriz/vetor); Me retorna a quantidade de elementos do vetor/matriz
        Console.WriteLine("\tGetLongLength");
        long qtdeVetor = vetor1.GetLongLength(0);
        long qtdeMatriz = matriz.GetLongLength(1);
        Console.WriteLine("Vetor1 - Quantidade de elementos/posições : {0}", qtdeVetor);
        Console.WriteLine("\nMatriz - Quantidade de elementos/posições : {0}", qtdeMatriz);
        Console.WriteLine("-----------------------------------------------");

        //public int GetLowerBound(dimensão_da_matriz/vetor); Me retorna a primeira posição do vetor/matriz
        Console.WriteLine("\tGetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Vetor1 - Menor índice/posição do Vetor1 : {0}", menorIndiceVetor);
        Console.WriteLine("\nMatriz - Menor índice/posição da Matriz : {0}", menorIndiceMatriz);
        Console.WriteLine("-----------------------------------------------");

        //public int GetUpperBound(dimensão_da_matriz/vetor); Me retorna a última posição do vetor/matriz
        Console.WriteLine("\tGetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Vetor1 - Maior índice/posição do Vetor1 : {0}", MaiorIndiceVetor);
        Console.WriteLine("\nMatriz - Maior índice/posição da Matriz : {0}", MaiorIndiceMatriz);
        Console.WriteLine("-----------------------------------------------");

        //public int GetValue(índice_da_matriz/vetor); Me retorna o valor encontrado na posição que eu indicar do vetor ex:(3) ou na matriz ex:(1,5)
        Console.WriteLine("\tGetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 5));
        Console.WriteLine("Vetor1 - Valor na posição 3 do Vetor1 : {0}", valor0);
        Console.WriteLine("\nMatriz - Valor da linha 1 coluna 5 da Matriz : {0}", valor1);
        Console.WriteLine("-----------------------------------------------");

        //public static int IndexOf(array,valor); Eu indico um valor(3) e ele me retorna a posição do primeiro valor encontrado no vetor
        Console.WriteLine("\tIndexOF");//                                                               caso tenha outros valores iguais
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Vetor1 - Indice do primeiro valor 3 : {0}", indice1);
        Console.WriteLine("-----------------------------------------------");

        //public static int LastIndexOf(array,valor); Eu indico um valor(2) e ele me retorna a posição do último valor encontrado no vetor
        Console.WriteLine("\tLastIndexOf");//                                                             caso tenha outros valores iguais
        int indice2 = Array.LastIndexOf(vetor1, 2);
        Console.WriteLine("Vetor1 - Indice do primeiro valor 2 : {0}", indice2);
        Console.WriteLine("-----------------------------------------------");

        //public static void Reverse(array); O Reverve vai inverter a ordem dos elementos do vetor que eu indicar
        Console.WriteLine("\t Reverse");
        Array.Reverse(vetor1);
        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }

        //public void SetValue(object valor, long pos); O SetValue vai setar um valor na posição que eu indicar, no caso o valor'99' vai ser 
        vetor2.SetValue(99, 0); //                                                                                  adicionado na posição'0'
        Console.WriteLine("\tVetor2-SetValue : 99");
        foreach (int i in vetor2)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i); // E usando nesse caso, vou setar o valor'0' em todas posições percorridas pelo for
        }
        Console.WriteLine("\tVetor2-SetValue : 0");
        foreach (int i in vetor2)
        {
            Console.WriteLine(i);
        }

        //public static void Sort(array); Esse método vai ordenar todos elementos do vetor em ordem crescente, caso eu queira em ordem decrescente 
        Array.Sort(vetor1); //                                                          basta usar o 'Reverse' em seguida, como mostrado no vetor3
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Array.Reverse(vetor3);
        Console.WriteLine("\t Metodo Sort - vetor 1");
        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\t Metodo Sort - vetor 2");
        foreach (int i in vetor2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\t Metodo Sort -vetor 3");
        foreach (int i in vetor3)
        {
            Console.WriteLine(i);
        }
    }
}