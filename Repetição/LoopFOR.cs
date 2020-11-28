using System;
class Loop{
    static void Main(){
        int[] cont=new int[10];   
        string[] nome=new string[10]{"Anderson","Nubia","Edith","Antonio","Clélio","Monica","Cibelle","Lais","Felipe","Pedro"};
        for(int i=0;i<cont.Length;i++){
            Console.WriteLine("Posição [{0}] : {1} ",i,nome[i]);
            
        }
    }
}