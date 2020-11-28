using System; //        PUBLIC VS PRIVATE
class Jogador
{
    private int energia;
    private string nome;
    public Jogador(string nome)
    {
        this.nome = nome;   // O 'this' serve pra especificar que o objeto chamado pertence a classe e não ao construtor.
        energia = 100;
    }
    public int getEnergia()
    { // Como agora estou a usar métodos privados, foi preciso criar novos métodos para fazer a leitura e modificação dos objetos
        return energia;      // já que os objetos não podem ser lidos nem modificados diretamente quando são 'private'
    }
    public string getNome()
    {
        return nome;
    }
    public void setEnergia(int e)// O metodo setEnergia foi criado para alterar os valores de uma classe privada. (Atenção as regras matemáticas)
    {
        if (e < 0)
        {
            if (energia + e < 0) 
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        else if (e > 0)
        {
            if (energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }

    }
}
class Program
{
    static void Main()
    {
        Jogador j1 = new Jogador("Anderson");

        j1.setEnergia(-30);
        j1.setEnergia(-30);

        Console.WriteLine("Nome...: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}