using System;

namespace Lista4
{
    class Program
    {
        //   Lógica de Programação - 4

        //### Classes, metodos, heranca e polimorfismo.

        //1. Crie uma classe Principal que conterá seu método Main.Esta classe deverá conter um while que deverá imprimir o menu abaixo.O programa só deverá fechar caso seja digitado 0.

        //## Escolhe uma opçao ##
        //1 - Criar conta max
        //2 - Criar conta universitaria
        //3 - Imprimir conta
        //4 - Investir
        //0 - Sair

        //2. Após executar a opção 1, 2, 3, 4 o menu deverá ser reimpresso para nova escolha.

        //3. Crie os métodos de Criar Conta Max, Criar Conta Universitaria e Imprimir Conta dentro da classe Principal. Requisite ao usuário todas as informações contidas na classe Conta abaixo.

        //4. Crie uma classe base chamada Conta com os dados abaixo:
        //Saldo, Nome, Cpf, Email, Modificado e Criado. (Define os tipos que você entender ser mais apropriado).

        //5. Crie duas classes que herdam de Conta.Estas duas classes devem se chamar ContaMax e ContaUniversitaria.Ambas devem ter um método público de impressão de todos os dados do cliente.Exceto a taxa mencionada no item 6 e 7).

        //6. ContaMax também deverá ter um atributo readonly contante do tipo double chamado Taxa.O valor deverá ser 1.3

        //7. Contauniversitária também deverá ter um atributo readonly contante do tipo double chamado Taxa.O valor deverá ser 1.1

        //8. As contas criadas devem ser armazenadas em um array de 3 posições.Ao escolher no menu a opção 3, todas as contas criadas deverão ser impressas.Diferencie quais são Max e quais são Univerisitária.

        //9. Caso ao adicionar uma nova conta não haja mais espaço no array, imprima a mensagem de lista cheia.

        //10. Crie uma classe estática chamada Investimento e adicione um método estático chamado Investir.O método estático deverá receber um parametro do tipo Conta. Dentro do método de investir crie uma lógica que utilize a propriedade Saldo e a constante Taxa que retorne um valor double como resultado de um investimento.

        //11. Armazene o resultado do investimento dentro do saldo da conta em contexto.Após a tela voltar para o menu, caso seja clicado em 3 Imprimir, o novo valor deverá ser mostrado para a conta que foi realizado o cálculo.
    


        static void Main(string[] args)
        {

            Menu();

        }

        public static void Menu()
        {
            Console.WriteLine("Seja bem vindo, o que podemos fazer por você hoje?");
            Console.WriteLine("1 - Criar conta max");
            Console.WriteLine("2 - Criar conta universitaria");
            Console.WriteLine("3 - Imprimir conta");
            Console.WriteLine("4 - Investir");
            Console.WriteLine("0 - Sair");



            int inputUsuario = Convert.ToInt32(Console.ReadLine());

            if (inputUsuario == 1)
            {
                Console.WriteLine("Sera um prazer criar sua conta max");
                CriarContaMax();
            }
            else if (inputUsuario == 2)
            {
                Console.WriteLine("Sera um prazer criar sua conta universitaria");
              
            }
            else if (inputUsuario == 3)
            {
                Console.WriteLine("Imprimindo conta");
            }
            else if (inputUsuario == 4)
            {
                Console.WriteLine("Investir");
            }
            else if (inputUsuario == 5)
            {
                Console.WriteLine("Sair");
            }
            else if (inputUsuario == 10)
            {
                Console.WriteLine("Voce chegou aqui");

            }


        }

        public static void CriarContaMax()
        {
            Conta conta1 = new Conta(123, "ContaTeste", 410, "Criado");
            
            Console.WriteLine("Pode informar seu cpf");

            int recebendoCPF = int.Parse(Console.ReadLine());

            conta1.NovoCPF(recebendoCPF);


           
        }







        //public class Conta
        //{

        //    public string Saldo { get; }
        //    public int Nome { get; set; }
        //    public string CPF { get; set; }
        //    private double Email { get; set; }
        //    public string Modificado { get; set; }




        //    public Vendas(string campanhaVindaDoConstrutor, int identificadorVindoDoConstrutor, string v, double p)
        //    {
        //        Campanha = campanhaVindaDoConstrutor;
        //        Identificador = identificadorVindoDoConstrutor;
        //        Veiculo = v;
        //        Preco = p;
        //    }


        //    public void gerarRelatorio()
        //    {
        //        Console.WriteLine($"\nNome:{Campanha} \nCPF:{Identificador} \nEmail:{Veiculo} \nSaldo{Preco.ToString("C")}");
        //    }

        //    //recebendo novo valor que poderia vir do console por exemplo


        //    public void NovoValor(int novoPreco)
        //    {
        //        Preco = novoPreco;
        //    }

        //    public void NovoID(int novoID)
        //    {
        //        Identificador = novoID;
        //    }

        //}
    }
        
    public class Conta
    {

        //    public Vendas(string campanhaVindaDoConstrutor, int identificadorVindoDoConstrutor, string v, double p)
        //    {
        //        Campanha = campanhaVindaDoConstrutor;
        //        Identificador = identificadorVindoDoConstrutor;
        //        Veiculo = v;
        //        Preco = p;
        //    }
        public int Saldo { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Status { get; set; }

        public Conta(int saldoVindoDoConstrutor, string nomeVindoDoConstrutor, int cpfVindoDoConstrutor, string statusVindoDoConstrutor)
        {
            Saldo = saldoVindoDoConstrutor;
            Nome = nomeVindoDoConstrutor;
            CPF = cpfVindoDoConstrutor;
            Status = statusVindoDoConstrutor;

        }

        public void NovoNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void NovoCPF(int novoCPF)
        {
            CPF = novoCPF;
        }

        public void GerarRelatorio()
        {
            Console.WriteLine($"\nNome:{Nome} \nIdentificador:{CPF} \nEmail:{CPF} \nSaldo{Status}");
        }
    }


}
