using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float menosdeumaduzia, maisqueumaduzia, num;

            //Console.WriteLine("Digite a quantidade e laranjas que voce comprou: ");
            //num = float.Parse(Console.ReadLine());

            //if (num < 12)
            //{
            //    menosdeumaduzia = num * 0.35f;
            //    Console.WriteLine("o total a se pagar é:" + menosdeumaduzia);
            //}
            //else
            //{
            //    maisqueumaduzia = num * 0.28f;
            //    Console.WriteLine("o total a se pagar é:" + maisqueumaduzia);

            //}



            //EXERCICIO2
            //float anoatual, anodenascimento, res;

            //Console.WriteLine("Digite o ano atual em que você esta: ");
            //anoatual = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o ano em que você nasceu: " );
            //anodenascimento = float.Parse(Console.ReadLine());
            //res = anoatual * anodenascimento;
            //if (res < 16)
            //    Console.WriteLine("essa pessoa não pode votar.");
            //else
            //    Console.WriteLine("essa pesoa poderá votar");


            //EXERCIOCIO3
            float l1, l2, l3;
            Console.WriteLine("Digite o lado 1 do triangulo");
            l1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 do triangulo");
            l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 3 do triangulo");
            l3 = float.Parse(Console.ReadLine());

            if (l1 == l2 && l2 == l3 && l1 == l3)
                Console.WriteLine("esse triangulo é equilatero");
            else if (l1 != l2 && l2 != l3 && l1 != l3)
                Console.WriteLine("esse triangulo é escaleno");
            else
                Console.WriteLine("Seu triangulo é isósceles");
            Console.ReadKey();
        }
    }
}
