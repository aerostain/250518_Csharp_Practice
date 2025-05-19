using System.Security.Cryptography.X509Certificates;

namespace Csharp_Practice;

class Program
{
    static void Main(string[] args)
    {
        myAct(10);
        Console.WriteLine($"\n{myFunc(10)}");
    }

    // Un Action es un delegado: encapsula un metodo void
    public static Action<int> myAct = (x) => Console.WriteLine($"\n{DateTime.Now.AddDays(x)}\n");
    // Un Func es un delegado: encapsula un metodo con retorno
    public static Func<int, double> myFunc = (x) => x * Math.PI;

    static void Test_4()
    {
        List<int> numsAleatorios = new();
        Random numale = new();
        for (int i = 0; i < 10; i++)
        {
            numsAleatorios.Add(numale.Next(0, 10));
        }
        numsAleatorios.ForEach(Console.WriteLine);
    }

    static void Test_1()
    {
        Func<int, int> myFunc = (z) => z * 2;

        Console.Write($"Ingresa un numeró: ");
        var tmp = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"Resultado: {myFunc(tmp)}");
    }
}
