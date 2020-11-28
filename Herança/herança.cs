using System;
class Piloto{
    public string nome;//              PUBLIC
    private int idade;//               PRIVATE
    protected bool especialista;//     PROTECTED
    public Piloto(string nome, int idade){
        this.nome=nome;
        this.idade=idade;
        especialista=true;
    }
    public int getIdade(){
        return idade;
    }
    public string getXP(){
        return (especialista?"Sim":"Não");
    }
}
class Amador:Piloto{
    public Amador():base("Anderson",23){
        especialista=false;
    }
}
class Veiculo{// Classe Base ou Classe Pai
    public string nome;
    public int rodas;
    public string cor;
    public int velMax;
    public bool ligado;
    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public void Ligar(){
        ligado=true;
    }
    public void Desligar(){
        ligado=false;
    }
    public string getLigado(){

        return (ligado?"sim":"não"); // Esse é o OPERADOR TERNÁRIO, tem a mesma função do if abaixo, porém funciona da seguinte maneira : 
/*                                              O ponto de interrogação representa o if quando a variável for 'bool'
        if(ligado==true){                                    Os dois pontos separam as opções booleanas entre 'true:false'
            return "sim";                                                Se ligado for true retorna:sim, caso contrário retorna:não
        } else {
            return "não";
        }
*/
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        } else if(rodas>30){
            this.rodas=30;
        } else {
            this.rodas=rodas;
        }
    }
}
class Carro:Veiculo{ // Classe Derivada ou Classe Filha
    public Carro(string name, string color):base(4){
        Desligar();
        velMax=220;
        nome=name;
        cor=color;
    }
}
class CarroCombate:Carro{// Aqui foi criada uma classe derivada, que tem como classe base outra classe derivada, e a base dessa duas classes é a classe Veiculo
    public int municao;
    public CarroCombate():base("Carro de Combate","Rosa"){
        municao=100;
        setRodas(8);
        velMax=100;
    }
}
class Program{
    static void Main(){
        Amador p1=new Amador();
        CarroCombate cc1 = new CarroCombate();
        Carro c1 = new Carro("Veloster","Preto");
        c1.Ligar();
        
        Console.WriteLine("Nome : {0}",c1.nome);
        Console.WriteLine("Cor : {0}",c1.cor);
        Console.WriteLine("Velocidade máxima : {0}",c1.velMax);
        Console.WriteLine("Rodas : {0}",c1.getRodas());
        Console.WriteLine("Ligado : {0}",c1.getLigado());
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Nome : {0}",cc1.nome);
        Console.WriteLine("Cor : {0}",cc1.cor);
        Console.WriteLine("Velocidade máxima : {0}",cc1.velMax);
        Console.WriteLine("Rodas : {0}",cc1.getRodas());
        Console.WriteLine("Ligado : {0}",cc1.getLigado());
        Console.WriteLine("Munição : {0}",cc1.municao);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Nome do piloto : {0}",p1.nome);
        Console.WriteLine("Idade do piloto : {0}",p1.getIdade());
        Console.WriteLine("Especialista : {0}",p1.getXP());
    }
}