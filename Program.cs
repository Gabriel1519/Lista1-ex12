using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double Pag;
            double Troco;

            Console.Write("Insira o Valor do 1º Item: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o Valor do 2º Item: ");
            p2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o Valor do 3º Item: ");
            p3 = double.Parse(Console.ReadLine());

            Console.Write("Insira o Valor do 4º Item: ");
            p4 = double.Parse(Console.ReadLine());

            Console.Write("Insira o Valor do 5º Item: ");
            p5 = double.Parse(Console.ReadLine());

            Console.Write("Insira o Valor entregue no pagamento: ");
            Pag = double.Parse(Console.ReadLine());

            Troco = Pag - (p1 + p2 + p3 + p4 + p5);

           Console.WriteLine("A Quantia em Reais a ser devolvido de troco é {0}.", Troco);
        }
    }
}
