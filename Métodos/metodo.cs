using System;
class Metodo{
    static void Main(){
        int soma1,soma2,sub1,sub2,dobro,dividendo,divisor,resto;
        Console.WriteLine("\n\tSOMA\n");
        Console.WriteLine("Indique o primeiro valor : ");
        soma1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indique o segundo valor : ");
        soma2 = Convert.ToInt32(Console.ReadLine());

        Soma(soma1, soma2); //Chamei o metodo criado passando os argumentos soma1 e soma2

        Console.WriteLine("\n\tSUBTRAÇÃO\n");
        Console.WriteLine("Indique o primeiro valor : ");
        sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indique o segundo valor : ");
        sub2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A subtração dos valores {0} e {1} é : {2}", sub1, sub2, Sub(sub1,sub2)); // Chamei o método Sub() como parâmetro
        
        Console.WriteLine("\n\tDOBRAR O VALOR\n");
        Console.WriteLine("Indique o valor : ");
        dobro = Convert.ToInt32(Console.ReadLine());

        Multi(ref dobro);// Passagem por referência usa o endereço de memória da variável e atribuí um novo valor a ela, economizando espaço na memória

        Console.WriteLine("O dobro do valor passado é : {0}", dobro); // Perceba que aqui não chamei o método Multi(), mas sim o valor da variável
    //                                                                             'dobro' que foi modificada ao usar o argumento como referência

        Console.WriteLine("\n\tDIVISÃO E SEU RESTO\n");
        Console.WriteLine("Indique o dividendo : ");
        dividendo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indique o divisor : ");
        divisor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A divisão de {0} por {1} tem quociente = {2} e resto = {3}",dividendo, divisor, Div(dividendo,divisor,out resto), resto);
//                                            A variável 'resto' foi modificada ao usar o argumento 'out', recebendo o valor passado no método Div()

    }
    
    static void Soma(int valor1, int valor2){ // Criei o método void Soma()
        int res = valor1+valor2;
        Console.WriteLine("A soma de {0} com {1} é : {2}", valor1, valor2, res);
    }
    static int Sub(int n1, int n2){ // Criei o método int Sub(), por ser inteiro precisa retornar um valor
        return n1-n2;
    }
    static int Multi(ref int n1){// Aqui se passa argumentos por referência(ref), que vai modificar os valores originais das variáveis
        return n1*=2;
    }
    static int Div(int n1,int n2, out int resto){ // O argumento de saída 'out' serve pro método retornar mais de um valor por fora do 'return'
        resto=n1%n2;
        return n1/n2;
    }
}