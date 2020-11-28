using System;
class LoopForEach
{
    static void Main()
    {
        string[] nome = { "Anderson", "Nubia", "Cibelle", "Pedro" };
        foreach (string i in nome)
        {
            Console.WriteLine(i);
        }
    }
} // O FOREACH É USADO APENAS PARA LER OS ELEMENTOS DE UM VETOR, SENDO ASSIM MAIS SIMPLES E PRÁTICO.