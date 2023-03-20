using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
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
            //float proxelei, anodenascimento, res;

            //Console.WriteLine("Digite o ano da proxima eleiçao: ");
            //proxelei = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o ano em que você nasceu: " );
            //anodenascimento = float.Parse(Console.ReadLine());
            //res = proxelei * anodenascimento;
            //if (res < 16)
            //    Console.WriteLine("essa pessoa não pode votar.");
            //else
            //    Console.WriteLine("essa pesoa poderá votar");


            //EXERCIOCIO3
            //float l1, l2, l3;
            //Console.WriteLine("Digite o lado 1 do triangulo");
            //l1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o lado 2 do triangulo");
            //l2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o lado 3 do triangulo");
            //l3 = float.Parse(Console.ReadLine());

            //if (l1 == l2 && l2 == l3 && l1 == l3)
            //    Console.WriteLine("esse triangulo é equilatero");
            //else if (l1 != l2 && l2 != l3 && l1 != l3)
            //    Console.WriteLine("esse triangulo é escaleno");
            //else
            //    Console.WriteLine("Seu triangulo é isósceles");


            //EXERCIOCIO4


            //float a, b, c,res;
            //double raiz, x1, x2;
            //Console.WriteLine("vamos determinar as raizes de uma equaçao de 2º");
            //Console.WriteLine("de um valor para A:");
            //a = float.Parse(Console.ReadLine());
            //Console.WriteLine("de um valor para B:");
            //b = float.Parse(Console.ReadLine());
            //Console.WriteLine("de um valor para C:");
            //c = float.Parse(Console.ReadLine());

            //res = (b * b) - 4 * a * c;

            //raiz= Math.Sqrt(res1);

            //x1 = (-b + raiz) / 2f * a;
            //x2= (-b - raiz) / 2f * a;

            //Console.WriteLine("o valor de x1 é:" + x1);
            //Console.WriteLine("o valor de x2 é:" + x2);




            //Exerciocio5

            //float num, res3, res5;

            //Console.WriteLine("Digite um numero para saber se ele é divisivel por 3 : ");
            //num = int.Parse(Console.ReadLine());

            //res3 = num % 3f;
            //res5 = num % 5f;

            //if ((res3 == 0) && (res5 == 0))

            //Console.WriteLine("O numero é divisivel por 3 e 5");

            //else if (res3 == 0)
            //    Console.WriteLine(" O numero é divisivel apenas por 3");

            //else if (res5 == 0)
            //    Console.WriteLine(" O numero é divisivel apenas por 5");

            //else
            //    Console.WriteLine("O numeronao é divisivel por nenhum dos doids numeros");




            //EXERCICIO 6

            //float a1, a2, a3;

            //Console.WriteLine(" Digite o primeiro angulo:");
            //a1= float.Parse(Console.ReadLine());
            //Console.WriteLine(" Digite o primeiro angulo:");
            //a2= float.Parse(Console.ReadLine());
            //Console.WriteLine(" Digite o primeiro angulo:");
            //a3= float.Parse(Console.ReadLine());

            //if (a1 == 90 || a2 == 90 || a3 == 90)
            //    Console.WriteLine("seu triangulo é retangulo");

            //else if (a1 < 90 && a2 < 90 && a3 < 90)
            //    Console.WriteLine(" Seu angulo é Obtusângulo");

            //else
            //    Console.WriteLine("Seu angulo é Acutângulo:");




            //EXERCICIO7

            //int a, b, c, x;

            //Console.WriteLine("Entre com o valor de A: ");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o valor de B: ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o valor de C: ");
            //c = int.Parse(Console.ReadLine());


            //if (b < a)
            //{
            //    x = a;
            //    a = b;
            //    b = x;
            //}

            //if (c < a)
            //{
            //    x = a;
            //    a = c;
            //    c = x;
            //}

            //if (c < b)
            //{
            //    x = b;
            //    b = c;
            //    c = x;
            //}

            //Console.WriteLine("primeiro valor " + a + " Segundo valor " + b + " Terceiro valor " + c);







            //EXERCICIO8
            //float ano, res;

            //Console.WriteLine("Digite o ano desejado para saber se ele sera bissexto");
            //ano= float.Parse(Console.ReadLine());

            //res = ano % 4;

            //if (res == 0)
            //    Console.WriteLine("esse ano é bissexto");
            //else
            //    Console.WriteLine("Esse ano nao é bissexto");






            //EXERCICIO9
            //double num1, num2;


            //int operacao= 0;



            //Console.WriteLine("Digite o primeiro numero");

            //num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo numero");

            //num2 = double.Parse(Console.ReadLine());







            //Console.WriteLine("Para somar digite 1");

            //Console.WriteLine("Para subtrair digite 2");

            //Console.WriteLine("Para dividir digite 3");

            //Console.WriteLine("Para multiplicar digite 4");

            //Console.WriteLine("Para sair digite 5");

            //operacao = int.Parse(Console.ReadLine());

            //if (operacao == 1)

            //{

            //    Console.WriteLine("Soma = {0}", num1 + num2);

            //}

            //if (operacao == 2)

            //{

            //    Console.WriteLine("Subtração = {0}", num1 - num2);

            //}

            //if (operacao == 3)

            //{

            //    Console.WriteLine("Divisão = {0}", num1 / num2);

            //}

            //if (operacao == 4)

            //{

            //    Console.WriteLine("Multiplicação = {0}", num1 * num2);

            //}




            //EXERCICIO10

            //É importante lembrar que a classe Random utiliza um algoritmo para gerar números aleatórios baseados em um valor inicial,
            //chamado de semente.Se a semente não for alterada, os números gerados serão sempre os mesmos.Por isso, é recomendado que a semente
            //seja alterada antes de gerar números aleatórios, para garantir que os resultados sejam realmente aleatórios.Isso pode ser feito passando
            //um valor inteiro como parâmetro para o construtor da classe Random.Caso não seja necessário controlar a semente, pode - se utilizar o
            //construtor padrão da classe Random, que utiliza o relógio do sistema como semente.
            //exemplo: 
            //Random random = new Random();
            //int numero = random.Next(1, 11);

            //Random random = new Random();
            //double numero = random.NextDouble();










            Console.ReadKey();
        }
    }
}
