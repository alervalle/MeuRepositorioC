using System;

namespace _12FevLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a lista 2");
            Console.WriteLine();


            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
            exercicio6();
            //exercicio7();




        }

        static void exercicio1()
        {
            //1. (IF) Solicite duas notas ao usuário, faça a média e imprima na tela “passou” se a média for maior ou igual a 6 e “não passou” caso contrário.

            Console.WriteLine("1. (IF) Solicite duas notas ao usuário, faça a média e imprima na tela “passou” se a média for maior ou igual a 6 e “não passou” caso contrário.");


            Console.WriteLine("Qual sua primeira nota?");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual sua segunda nota?");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            double somaDasNotas = nota1 + nota2;

            double media = somaDasNotas / 2;

            if (media > 6)
            {
                Console.WriteLine("Sua média é " + media + " Voce passou");
            }
            else
            {
                Console.WriteLine("Tente novamente, media insuficiente");
            }
        }

        static void exercicio2()
        {
            //2. (SWITCH) Imprima na tela “digite ‘i’ para inserir, ‘e’ para editar, ou ‘r’ para remover”.  
            //Se digitado ‘i’ imprima “inserindo”, se digitado ‘e’ imprima “editando”, se digitado ‘r’ imprima “removendo”.  
            //Se for digitado algo diferente, imprima “comando inválido”.

            Console.WriteLine("2. (SWITCH) Imprima na tela “digite ‘i’ para inserir, ‘e’ para editar, ou ‘r’ para remover”. Se digitado ‘i’ imprima “inserindo”, se digitado ‘e’ imprima “editando”, se digitado ‘r’ imprima removendo. Se for digitado algo diferente, imprima comando inválido");

            Console.WriteLine("Digite i para inserir, e para editar ou r para remover");
            //string caseSwitch = Console.ReadLine();

            string armazenaEntrada = Console.ReadLine();

            int caseSwitch = 1;

            if (armazenaEntrada == "i")
            {
                caseSwitch = 1;
            }
            else if (armazenaEntrada == "e")
            {
                caseSwitch = 2;

            }
            else if (armazenaEntrada == "r")
            {
                caseSwitch = 3;
            }


            switch (caseSwitch)
            {

                case 1:
                    Console.WriteLine("inserir");
                    break;
                case 2:
                    Console.WriteLine("editar");
                    break;
                case 3:
                    Console.WriteLine("remover");
                    break;
                default:
                    Console.WriteLine("Comando Invalido");
                    break;

            }
        }


        //problemas para imprimir o array
        static void exercicio3()
        {
            Console.WriteLine("3. (ARRAY e FOR) Solicite dez números ao usuário.Armazene esses números em um array de int.Ao final imprima os dez números na tela.");

            int[] newArray = new int[10];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(newArray);

        }

        static void exercicio4()
        {

            //4. (IF) Solicite ao usuário 3 números, guarde os 3 valores em variáveis, em seguida, imprima o maior, o menor e a média.

            


            Console.WriteLine("4. (IF) Solicite ao usuário 3 números, guarde os 3 valores em variáveis, em seguida, imprima o maior, o menor e a média.");

            Console.WriteLine("Seu primeiro numero random");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seu segundo numero random");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seu terceiro numero random");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("O primeiro número é o maior");

                if (b > c)
                {
                    Console.WriteLine("O terceiro número é o menor");
                    Console.WriteLine("A media entre eles é : " + (a + c)/2);


                }
                else if (c > b)
                {
                    Console.WriteLine("O segundo número é o menor");
                    Console.WriteLine("A media entre eles é : " + (a + b) / 2);

                }
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("O segundo número é o maior");

                if (a > c)
                {
                    Console.WriteLine("O terceiro número é o menor");
                    Console.WriteLine("A media entre eles é : " + (b + c) / 2);

                }
                else if (c > a)
                {
                    Console.WriteLine("O primeiro número é o menor");
                    Console.WriteLine("A media entre eles é : " + (b + a) / 2);

                }
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("O terceiro número é o maior");

                if (a > b)
                {
                    Console.WriteLine("O segundo número é o menor");
                    Console.WriteLine("A media entre eles é : " + (c + b) / 2);

                }
                else if (b > a)
                {
                    Console.WriteLine("O primeiro número é o menor");
                    Console.WriteLine("A media entre eles é : " + (c + a) / 2);


                }
            }

        }

        
        static void exercicio5()
        {

            //5. (FOR / ARRAY / IF) Dado o array[10, 20, 30, 40, 50] solicite ao usuário que digite um número e imprima ‘sim’ se o número estiver presente no array e ‘não’ se ele não estiver presente.
            // nao consegui fazer
            Console.WriteLine(" 5. (FOR / ARRAY / IF) Dado o array[10, 20, 30, 40, 50] solicite ao usuário que digite um número e imprima ‘sim’ se o número estiver presente no array e ‘não’ se ele não estiver presente.");

            int[] dezenas = new int[5] { 10, 20, 30, 40, 50 };


            Console.WriteLine("Qual número voce deseja buscar no array?");
            int userInput = Convert.ToInt32(Console.ReadLine());


            if (true)
            {

            }
            for (int i = 0; i < dezenas.Length; i++)
            {
                
            }

        }




        static void exercicio6()
        {


            //6. (IF)Um produto custa R$0, 50 centavos, mas se comprados pelo menos 100 o preço cai para R$0, 20 centavos.
            //Solicite ao usuário a quantidade desejada e imprima o valor total da compra.

            Console.WriteLine("6. (IF)Um produto custa R$0, 50 centavos, mas se comprados pelo menos 100 o preço cai para R$0, 20 centavos.Solicite ao usuário a quantidade desejada e imprima o valor total da compra.");

            Console.WriteLine("Quantas unidades você quer comprar?");
            double unidadesDeCompra = Convert.ToDouble(Console.ReadLine());

            if (unidadesDeCompra > 100)
            {
                Console.WriteLine("Para essa quantidade você pode pagar R$0,20. O valor total da compra é " + unidadesDeCompra * 0.2);
            }
            else
            {
                Console.WriteLine("Para essa quantidade você pode pagar R$0,50. O valor total da compra é " + unidadesDeCompra * 0.5);
            }

        }

 

        static void exercicio7()
        {
            //7.Solicite ao usuário duas datas, essas datas devem ser digitadas em três passos: ano, mês e dia.
            //Compare as datas e imprima na tela se a data2 é antes, depois ou a mesma data que data1.

            Console.WriteLine("7.Solicite ao usuário duas datas, essas datas devem ser digitadas em três passos: ano, mês e dia.Compare as datas e imprima na tela se a data2 é antes, depois ou a mesma data que data1.");

            Console.WriteLine("Quantas unidades você quer comprar?");
            double unidadesDeCompra = Convert.ToDouble(Console.ReadLine());

            if (unidadesDeCompra <= 100)
            {
                
                Console.WriteLine("Para essa quantidade o preço por unidade é R$0,50. O valor total da compra é " + unidadesDeCompra * 0.5);
            }
            else
            {
                Console.WriteLine("Para essa quantidade você pode pagar R$0,20. O valor total da compra é " + unidadesDeCompra * 0.2);
            }

            

        }

    }


}
