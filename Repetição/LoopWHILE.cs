using System;
class LoopWhile{
    static void Main(){
        int[] cont=new int[10]{0,1,2,3,4,5,6,7,8,9};
        int i=cont.Length-1;
        int n=0;
        while(i>=0){
            Console.WriteLine("int 'i' : [{0}]", i);
            i--;
        }
        Console.Write("\n\n");
        while(n<cont.Length){
            Console.WriteLine("Vetor 'cont' : [{0}]", cont[n]);
            n++;
        }
    }
}