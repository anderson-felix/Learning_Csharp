using System;
class Program
{
    static void Main()
    {
        string nome = "Anderson";
        var name = "Nubia";
        int idade = 22;
        float altura = 1.78f;
        var date = DateTime.Now;

        Console.WriteLine("O nome é : {0} \nA idade é : {1} \nA altura é : {2} \n\nO nome da namorada é : {3} ", nome, idade, altura, name);

        bool res = name == "Nubia";
        bool val = (5 > 7) && (5 > 0);
        Console.WriteLine(res);
        Console.WriteLine(val);
        Console.WriteLine("------------------------------------------------------------------\n\n");
        Console.WriteLine("Hello world, as {date:d} to {date:t}");
        Console.WriteLine("------------------------------------------------------------------\n\n");

        double valorCompra, valorVenda, lucro=0.5;
        string produto;

        Console.WriteLine("Informe o tipo/nome do produto : ");
        produto=Console.ReadLine();
        Console.WriteLine("Informe o valor da compra : ");
        valorCompra=double.Parse(Console.ReadLine());// Esse é o comando de leitura, ele lê automaticamente o teclado apenas em strings, para converter para outro tipo
        valorVenda=valorCompra+(valorCompra*lucro);  //                                     basta informar o tipo.Parse()      Ex: var1 = int.Parse(Console.Readline())

        Console.WriteLine("Produto......:{0,15}", produto);// O termo {0,15} significa que eu estou usando a variável do indice 0 (produto), o '15' é o espaço que eu quero adicionar antes da variável.    
        Console.WriteLine("Val.Compra...:{0,15:c}", valorCompra);// O termo ':c' serve para adicionar o formato monetário (R$) antes da variável.
        Console.WriteLine("Lucro........:{0,15:p}", lucro);// O termo ':p' serve para adicionar o formato porcentagem (%) depois da variável.
        Console.WriteLine("Val.Venda....:{0,15:c}", valorVenda);
    }
}