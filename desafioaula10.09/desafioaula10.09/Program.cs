using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace desafioaula10._09
{
    class Program
    {

        //CHAMA A TELA INICIAL
        static void Main(string[] args)
        {

                telainicial();
        }


        //METODO DE COMPOSICAO DO MENU
        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja efetuar?");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-SAIR");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    soma();
                    break;
                case 2:
                    subtracao();
                    break;
                case 3:
                    multiplicacao();
                    break;
                case 4:
                    divisao();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
            }
        }

            //METODO DE FUNCAO DE MULTIPLICACAO
            private static void multiplicacao()
            {
            float num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Gigite o primeiro numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Gigite o segundo numero");
                num2 = float.Parse(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine("Resultado de " + num1 + " Vezes " + num2 + " é igual a " + resultado + "");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                Console.ReadKey();
            }

        //METODO DE FUNCAO DE DIVISAO
        private static void divisao()
            {
            float num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Gigite o primeiro numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Gigite o segundo numero");
                num2 = float.Parse(Console.ReadLine());
                resultado = num1 / num2;
                Console.WriteLine("Resultado de " + num1 + " Dividio por " + num2 + " é igual a " + resultado + "");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                Console.ReadKey();
            }

        //METODO DE FUNCAO DE SUBTRACAO
        private static void subtracao()
        {
            float num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Gigite o primeiro numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Gigite o segundo numero");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 - num2;
            Console.WriteLine("Resultado de " + num1 + " Menos " + num2 + " é igual a " + resultado + "");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //METODO DE FUNCAO DE SOMA
        private static void soma()
            {

                float num1 = 0, num2 = 0, resultado = 0;
                Console.WriteLine("Gigite o primeiro numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Gigite o segundo numero");
                num2 = float.Parse(Console.ReadLine());
                resultado = num1 + num2;
                Console.WriteLine("Resultado de " + num1 + " Mais " + num2 + " é igual a " + resultado + "");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                Console.ReadKey();
            }

        //METODO CRIA TELA INICIAL
        private static void telainicial()
            {
                Console.Clear();
                Console.WriteLine("Quantas vezes deseja utilizar a Calculadora?");
                var contador = int.Parse(Console.ReadLine());

                for (int quantidade = 1; quantidade <= contador; quantidade++)
                {

                    menu();
                    Console.WriteLine("Execução numero : " + quantidade + " ");
                    Console.WriteLine("--------------------");
                    Console.WriteLine(" ");
                    Console.ReadKey();
                }
                Console.WriteLine("Fim da Aplicação");
                Console.WriteLine("--------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Deseja aplicar a rotina novamente?");
                Console.WriteLine("1 para SIM");
                Console.WriteLine("2 para NÃO");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    telainicial();
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
    }
}