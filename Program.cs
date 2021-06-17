using System;

namespace Apuracao_votos
{
    class Program
    {
        static void Main(string[] args)
        {
            apuracao x;
            x = new apuracao();
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Informe a quantidade total de eleitores: ");
            x.totalEleitor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos válidos: ");
            x.valido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos brancos: ");
            x.branco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos nulos: ");
            x.nulo = double.Parse(Console.ReadLine());
            a = (x.valido / x.totalEleitor)*100;
            Console.WriteLine("Votos válidos: "+a+"%");
            b = (x.branco / x.totalEleitor)*100;
            Console.WriteLine("Votos brancos: " + b + "%");
            c = (x.nulo / x.totalEleitor)*100;
            Console.WriteLine("Votos nulos: " + c + "%");










        }
    }
}
