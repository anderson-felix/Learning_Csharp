using System;
public interface Pessoa{
    void dados();
}
public interface PJ{
    void dadosPj();
}
class Cadastro:Pessoa{
    public string name;
    public int nasc;
    public long cpf;
    public string estCivil;
    
    public void dados(){
        name="anderson";
        nasc=18/07/1997;
        cpf=43887041801;
        estCivil="solteiro";
    }
}
class Program{
    static void Main(){
        Cadastro novo1=new Cadastro();
        Console.WriteLine("\tDados\nNome : {0}\nDt.Nascimento : {1}\nCPF : {2}\nEst.Civil : {3}",novo1.name,novo1.nasc,novo1.cpf,novo1.estCivil);
    }
}