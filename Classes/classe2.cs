using System; //      SOBRECARGA DE MÉTODOS
public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){ 
        energia=100;
        vivo=true;
        nome="Gamer";
    }
    public Jogador(string n){ 
        energia=100;
        vivo=true;
        nome=n;
    }
    public Jogador(string n, int e){ // Os métodos criados são chamados de "SOBRECARGA DE MÉTODOS".
        energia=e;                   // Isto é, o mesmo método criado com entrada de argumentos diferentes, para todos tipos de objetos dentro dele
        vivo=true;                   // Caso eu não passe nenhum argumento de entrada, o programa vai executar o método sem argumentos de entrada
        nome=n;                      // Caso eu passe apenas um argumento, ele vai executar o método com apenas um argumento de entrada, e assim por diante..
    }
    public Jogador(string n, int e, bool v){ 
        energia=e;
        vivo=v;
        nome=n;
    }
    public void info(){  // Aqui foi criado o método 'info' para exibir os objetos do método em cada chamada, economizando linhas no Main()
        Console.WriteLine("\nNome do jogador..: {0}", nome);
        Console.WriteLine("Energia do jogador.: {0}", energia);
        Console.WriteLine("Status do jogador..: {0}\n", vivo);
    }
}
class Classes{
    static void Main(){

        Jogador j1=new Jogador(); 
        Jogador j2=new Jogador("Anderson");
        Jogador j3=new Jogador("Nubia",80);
        Jogador j4=new Jogador("Cibelle",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}