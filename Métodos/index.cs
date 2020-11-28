using System; //                 INDEXADORES
class Familia{
    private string[] pessoas=new string[3]{"Anderson","Edith","Antonio"};
    public string this[int i]{ // O comando 'this' define a propriedade como indexadora atráves do indice de vetor [int i]
        get {
            return pessoas[i];
        }
        set{}
    }
}
class Program{
    static void Main(){
        Familia familia=new Familia();
        Console.WriteLine("\t MEMBROS DA FAMÍLIA");
        Console.WriteLine("01 : {0}",familia[0]);
        Console.WriteLine("02 : {0}",familia[1]);
        Console.WriteLine("03 : {0}",familia[2]);
    }
}