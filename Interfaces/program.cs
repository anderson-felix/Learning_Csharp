using System;
public interface Veiculo{
// AS INTERFACES SERVEM COMO BASE DE HERANÇA, PARA SER PASSADOS PARA COMPONENTES QUE POSTERIORMENTE VÃO NECESSITAR DAS MESMAS CARÁCTERISTICAS
    void info();
    void ligar();                   
    void desligar();
}
public interface Nitro{
    int nitro_power();
}
class Carro:Veiculo,Nitro{
// QUANDO A INTERFACE É CHAMADA, É PRECISO ATRIBUIR OS MÉTODOS QUE ESTÃO DENTRO DA INTERFACE, MESMO QUE ELES NÃO RETORNEM NADA
// neste caso foram chamadas duas interfaces, sendo necessário chamar todos os métodos de todas interfaces chamadas 
    public bool ligado;
    private int nitro_qtde;
    public Carro(){
    }
    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public int nitro_power(){
        return SetNitro(300);
    }
    public int SetNitro(int qtde){
        return this.nitro_qtde=qtde;
    }
    public void info(){
        Console.WriteLine("Carro de Corrida com Nitro");
        Console.WriteLine("Nitro restante : {0}",nitro_power());
    }
}
class program{
    static void Main(){
        Carro Fusca=new Carro();
        Fusca.info();
    }
}