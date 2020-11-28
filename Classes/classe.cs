using System;  //        MÉTODOS CONSTRUTOR E DESTRUTOR
public class Jogador{
    public int energia;
    public bool vivo;  // Membros da classe
    public string nome;

    public Jogador(string n){ // Esse é o método construtor, que é instanciado automaticamente quando eu chamo esse objeto no Main.
        energia=100;          // O método construtor precisa ter o mesmo nome da classe, somente nele não é preciso especificar o tipo
        vivo=true;
        nome=n;
    }
    ~Jogador(){ //Esse é o método destrutor, ele é chamado quando o programa se encerra, destruindo assim os objetos criados pela classe
        Console.WriteLine("Jogador {0} foi destruído", nome);
    }
}
class Classes{
    static void Main(){
        string name;

        Console.WriteLine("Digite o nome do Jogador 2 : ");
        name=Console.ReadLine();

        Jogador j1=new Jogador("Nubia"); // Aqui são instanciados 3 objetos da classe 'Jogador'
        Jogador j2=new Jogador(name);    // O 'new' cria um espaço na memória ram para podermos trabalhar com o método

        j2.energia=50;

        Console.WriteLine("\nEnergia do Jogador 2 : {0}", j2.energia);
        Console.WriteLine("Nome do Jogador 2 : {0}\n", j2.nome);

        if(j2.energia<20){
            Console.WriteLine("Jogador 2 - Vida fraca");
        } else if(j2.energia<70){
            Console.WriteLine("Jogador 2 - Vida média");
        } else {
            Console.WriteLine("Jogador 2 - Vida cheia");
        }
    }
}