using System;
sealed class Quarto{ // A classe Quarto é uma classe selada (SEALED), significa que não pode ser herdada
    public string cama;
    public float altura;
    public Quarto(string cama, float altura){
        this.cama=cama;
        this.altura=altura;
    }
}
abstract class Cueca{    //  A classe Cueca é uma classe abstrata (ABSTRACT), significa que serve apenas para herança
    public string cor;
    public Cueca(string cor){
        this.cor=cor;
    }
}
class NovaCueca:Cueca{ // A classe NovaCueca é uma classe derivada que vai herdar os elementos da classe Cueca
    public NovaCueca():base("Azul"){}
}
public class Sapato{
    public string name;
    public int num;
    protected string cor;
    public Sapato(string name, string cor, int num){
        this.name=name;
        this.num=num;
        this.cor=cor;
    }
    public string getCor(){
        return cor;
    }

}
class Program{
    static void Main(){
        Quarto meuQuarto=new Quarto("Cama de pallet",0.68f);
        NovaCueca novaCueca=new NovaCueca();
        Sapato sapato=new Sapato("Nike Fusion air","Preto",41);

        Console.WriteLine("Tipo de cama.......... : {0}",meuQuarto.cama);
        Console.WriteLine("Altura da cama........ : {0}",meuQuarto.altura);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Marca e nome do sapato : {0}", sapato.name);
        Console.WriteLine("Cor do sapato......... : {0}", sapato.getCor());
        Console.WriteLine("Tamanho do sapato..... : {0}", sapato.num);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Cor da cueca.......... : {0}", novaCueca.cor);
}

}