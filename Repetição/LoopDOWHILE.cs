using System;
class LoopDoWhile{
    static void Main(){
        string password="993822781af";
        string passwordtest;
        int chances=5;

        do{
            Console.Clear();
            Console.WriteLine("\t\t\tChances : {0}", chances);
            Console.WriteLine("Digite sua senha : ");
            passwordtest=Console.ReadLine();
            chances--;
        } while(password != passwordtest);
        Console.Clear();
        Console.WriteLine("Senha Correta!");

    }
}