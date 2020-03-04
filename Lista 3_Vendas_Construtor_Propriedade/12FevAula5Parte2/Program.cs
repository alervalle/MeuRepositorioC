using System;

namespace _12FevAula5Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //# Lógica de Programação - 3

            //### Classes, propriedades, metodos, instancia, modificadores de acesso.

            //1.Crie uma classe pública com o nome que desejar.


            //2.Crie 3 propriedades sendo um privado, um readonly e um público.

            //3.Dentro da mesma classe, crie um método que altere o valor da propriedade privada.

            //4.Dentro da mesma classe, crie um método que imprima todos as propriedades.

            //5.Agora no método Main da sua classe principal, instâncie sua classe e set os valores das propriedades(utilize construtor).

            //6.Imprima todas as propriedades utilizando o método de impressão.

            //7.Atualize o valor da propriedade privada utilizando o método de atualização.

            //8 - Crie uma classe static com o nome que desejar e elabore um metodo para ser acessado por sua classe.Este método deverá retornar alguma alteração para uma das propriedades da sua classe.Imprima o antes e o depois desta propriedade.

            //9.Qual a mensagem de erro ao tentarmos atualizar um atributo do tipo 'const' ?
            // a menssagem de erro demonstra que ja existe um valor declarado para a constante anteriormente

            //10.Qual a mensagem de erro ao tentarmos atualizar um atributo do tipo 'readonly' ?
            // a mensagem de erro e que a propriedade nao consegue atribuir um valor j'a que 'e readonly 


            Vendas empresa1 = new Vendas("Ford", 123, "Spotify", 1000);
            empresa1.gerarRelatorio();

            empresa1.NovoValor(1500);
            empresa1.NovoID(321);

            empresa1.gerarRelatorio();

        }


        public class Vendas
        {

            public string Campanha { get; }
            public int Identificador { get; set; }
            public string Veiculo { get; set; }
            private double Preco { get; set; }

            

            public Vendas(string campanhaVindaDoConstrutor, int identificadorVindoDoConstrutor, string v, double p)
            {
                Campanha = campanhaVindaDoConstrutor;
                Identificador = identificadorVindoDoConstrutor;
                Veiculo = v;
                Preco = p;
            }


            public void gerarRelatorio()
            {
                Console.WriteLine($"\nNome:{Campanha} \nIdentificador:{Identificador} \nEmail:{Veiculo} \nSaldo{Preco.ToString("C")}");
            }

            //recebendo novo valor que poderia vir do console por exemplo

      
           public void NovoValor(int novoPreco)
                {
                Preco = novoPreco;
                }

            public void NovoID(int novoID)
            {
                Identificador = novoID;
            }

          

        }

    }
}
