using System;
class Aula{
    static void Main(){
        Soma(5,5,5,5,5);
    }
    static void Soma(params int[]n){
        int res=0;
        if(n.Length==0){
            Console.WriteLine("Não existem valores a serem somados");
        } else if (n.Length==1){
            Console.WriteLine("Não é possível somar apenas um valor");
        } else {
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma dos valores é : {0}",res);
        }
    }
}
// O 'Params' atribuí de forma dinâmica os valores no método chamado, precisando de um cuidado especial nas funções dentro do método para saber se 
// existe zero, um ou mais de um valor passado como argumento, para aí sim realizar as funçoes necessárias.