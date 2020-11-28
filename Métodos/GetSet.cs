using System;    //                  ACESSORS GET & SET
public class Login
{
    public string userName;
    private int password;
    public int erro = 404;
    public string teste
    {
        get
        {
            if (password == 1818)
            {
                return "Senha correta";
            }
            else
            {
                return "Senha Incorreta";
            }

        }
    }
    public Login(string userName, int password)
    {
        this.userName = userName;
        this.password = password;
    }
}
class Program
{
    static void Main()
    {
        string email;
        int senha;

        Console.WriteLine("Digite seu E-Mail : ");
        email = Console.ReadLine();
        Console.WriteLine("Digite sua Senha : ");
        senha = Convert.ToInt32(Console.ReadLine());

        Login derso = new Login(email, senha);

        Console.WriteLine("\n\tE-Mail : {0}", derso.userName);
        Console.WriteLine("\n\tSenha : {0}", derso.teste);
    }
}