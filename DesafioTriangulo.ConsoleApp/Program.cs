using System;

//Triângulo escaleno: Todos os lados e ângulos são diferentes.
//Triângulo isósceles: dois lados iguais e os ângulos opostos a esses lados iguais.
//Triângulo equilátero: Todos os lados e ângulos iguais. Concluímos que seus ângulos serão de 60°.

namespace DesafioTriangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sair = "";
            while (sair != "sair")
            {            
                int valorA = 0;
                int valorB = 0;
                int valorC = 0;
                while (valorA <= 0 || valorB <= 0 || valorC <= 0)
                {

                    Console.WriteLine("Desafio Triangulo Academia do Programador 2022");
                    Console.WriteLine("DIGITE OS LADOS A B C DO TRIANGULO RESPECTIVAMENTE");
                    Console.WriteLine("ESCREVA UM VALOR PARA A: ");
                    valorA = int.Parse(Console.ReadLine());
                    Console.WriteLine("ESCREVA UM VALOR PARA B: ");
                    valorB = int.Parse(Console.ReadLine());
                    Console.WriteLine("ESCREVA UM VALOR PARA C: ");
                    valorC = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Os valores atribuidos foram: ");
                    Console.WriteLine("A: " + valorA);
                    Console.WriteLine("B: " + valorB);
                    Console.WriteLine("C: " + valorC);

                    if (valorA <= 0 || valorB <= 0 || valorC <= 0)
                    {
                        Console.WriteLine("FALHA AO EXECUTAR, TRIANGULO INVALIDO, CONFIRA SE OS VALORES SAO NUMEROS INTEIROS POSITIVOS");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (valorA == valorB && valorB == valorC)
                    {                        
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Seu triangulo é EQUILÁTERO");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("ESCREVA 'sair' para encerrar o programa!");
                        Console.WriteLine("Ou aperte ENTER para reiniciar o programa!");
                        sair = Console.ReadLine();
                        Console.Clear();
                    }
                    else if ((valorA == valorB && valorA != valorC) || (valorA != valorB && valorB == valorC))
                    {
                        if (valorA + valorB >= 2 * valorC)
                        {
                            Console.WriteLine("Para construir um triângulo é necessário que a medida");
                            Console.WriteLine("de qualquer um dos lados seja menor que a soma dos outros dois lados.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Seu triangulo é ISÓSCELES");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("ESCREVA 'sair' para encerrar o programa!");
                        Console.WriteLine("Ou aperte ENTER para reiniciar o programa!");
                        sair = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (valorA != valorB && valorA != valorC && valorB != valorC)
                    {
                        if (valorA + valorB >= 2 * valorC || valorA + valorC >= 2*valorB || valorB + valorC >= 2 * valorA)
                        {
                            Console.WriteLine("Para construir um triângulo é necessário que a medida");
                            Console.WriteLine("de qualquer um dos lados seja menor que a soma dos outros dois lados.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Seu triangulo é ESCALENO");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("ESCREVA 'sair' para encerrar o programa!");
                        Console.WriteLine("Ou aperte ENTER para reiniciar o programa!");
                        sair = Console.ReadLine();
                        Console.Clear();
                    }
                }
            }           
        }
    }
}
