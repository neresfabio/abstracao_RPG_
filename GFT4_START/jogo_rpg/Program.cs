using jogo_rpg.src.Entities;

namespace dotnet_poo;
class Program
{
    static void Main(string[] args)
    {
        Hero arus = new Hero("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "Write Wizard");
        
        Console.WriteLine(arus.Attack());
        Console.WriteLine(wizard.Attack(7));
    }

}
