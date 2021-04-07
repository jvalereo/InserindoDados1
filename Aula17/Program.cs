using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treimamento  - Aula17, inseri dados, tipo string , concatenação
            //Jonas Valereo - Técnica em informática 

            //Declarando as variaveis tipo string 

            string nome;
            string sobrenome;


            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine();
  

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Informaçãoes do meu nome");
            Console.WriteLine();
            Console.WriteLine("Meu nome é: " + nome + " " + sobrenome);


            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
