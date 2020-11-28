using System;
class Base
{                                                                           //     MÉTODOS VIRTUAIS
    public Base()                                                           
    {
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){} // Esse é elemento virtual, que vai ser substitúido por outro elemento 'override' com o mesmo nome em outra classe. 
}
class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Contrutor da classe Derivada 1");
    }
    override public void info() // Elemento que vai substituir o info() "virtual"
    {
        Console.WriteLine("Derivada 1");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Contrutor da classe Derivada 2");
    }
    override public void info() // Elemento que vai substituir o info() "virtual"
    {
        Console.WriteLine("Derivada 2");
    }
}
class Program
{
    static void Main()
    {
        Base Ref;  // For criada uma referencia (Ref) Para a clase base, que por sua vez vai executar o método info()
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref=derivada1;
        Ref.info();

    }
}