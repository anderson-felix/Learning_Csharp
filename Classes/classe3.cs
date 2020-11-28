using System;  //   CLASS STATIC
static public class Jogador{  // Ao criar uma classe static, todos objetos nela contidos também devem ser static, porém objetos static são validos para classes não statics
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void ini(string n){ 
        energia=100;
        vivo=true;
        nome=n;
    }
    static public void info(){  
        Console.WriteLine("\nNome do jogador..: {0}", nome);
        Console.WriteLine("Energia do jogador.: {0}", energia);
        Console.WriteLine("Status do jogador..: {0}\n", vivo);
    }
}
class Inimigo{
    static public bool alerta;//Nessa classe não estática, foi criado um objeto static chamado 'alerta'. Os objetos estáticos utilizam o mesmo espaço na memória
    public string nome;       //por ele ser estático, quando o valor dele for alterado mudará o valor de todos elementos da classe que usam esse objeto
    public Inimigo(string n){
        alerta=false;
        nome=n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("-----------------------");
    }
}
class Program{
    static void Main(){
        
        Jogador.ini("Anderson");
        Jogador.info();

        Inimigo i1=new Inimigo("Noob");
        Inimigo i2=new Inimigo("Pato");
        Inimigo i3=new Inimigo("Cuzão");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();
    }
}