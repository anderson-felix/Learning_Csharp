using System;
struct Carro{
    public string modelo, cor;
    public int ano;
    public Carro(string modelo, string cor, int ano){
        this.modelo=modelo;
        this.cor=cor;
        this.ano=ano;  
    }
    public void info(){
        Console.WriteLine("Modelo : {0}",this.modelo);
        Console.WriteLine("Cor... : {0}",this.cor);
        Console.WriteLine("Ano... : {0}",this.ano);
        Console.WriteLine("\n\n");
    }
}
struct Moto{
    public string modelo, cor;
    public int ano;
    public Moto(string modelo, string cor, int ano){
        this.modelo=modelo;
        this.cor=cor;
        this.ano=ano;  
    }
    public void info(){
        Console.WriteLine("Modelo : {0}",this.modelo);
        Console.WriteLine("Cor... : {0}",this.cor);
        Console.WriteLine("Ano... : {0}",this.ano);
        Console.WriteLine("\n\n");
    }
}
class Program{
    static void Main(){
        Carro c1=new Carro("Veloster","Preto",2010);
        Carro c2=new Carro("Fusca","Azul",1970);

        Moto[] motos=new Moto[3]; // ARRAY EM STRUCTS

        motos[0].modelo="Bros 150";
        motos[0].cor="Vermelha";
        motos[0].ano=2008;

        motos[1].modelo="Titan 160";
        motos[1].cor="Azul";
        motos[1].ano=2014;

        motos[2].modelo="CBR 1000";
        motos[2].cor="Preta";
        motos[2].ano=2015;

        c1.info();
        c2.info();

        for(int i = 0; i < motos.Length; i++){
            motos[i].info();
        }


    }
}