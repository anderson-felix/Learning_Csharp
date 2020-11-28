using System;

class Program {
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){ // O enum cria elementos de um tipo próprio com valores pré definidos, que são acessados pelo índice usado no main.
        
        DiasSemana ds = DiasSemana.Sexta;// criando uma variável 'ds' que recebe o elemento 'sexta' do enum 'DiasSemana'.

        DiasSemana ds1 = (DiasSemana)3;// criando outra variável 'ds1', e acessando o enum 'DiasSemana' no índice 3 (Quarta).

        int ds2 = (int)DiasSemana.Sexta;// na variável 'ds2', buscamos o valor de 'DiasSemana' no índice 'Sexta' e convertemos para um tipo inteiro
        //                                                                                                                               usando um Typecast.
        Console.WriteLine(ds);
        Console.WriteLine(ds1);
        Console.WriteLine(ds2);
    }
}