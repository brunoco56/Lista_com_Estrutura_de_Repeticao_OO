using System;
using System.Collections.Generic;

namespace Arduino
{
    class Program
    {
        static void Main(string[] args)
        {
            char resposta = 'N';
            DateTime data = DateTime.Now;

            List<Pessoa> usuarios = new List<Pessoa>();

            do
            {
                Pessoa pessoa = new Pessoa();

                Console.WriteLine("*************");
                Console.WriteLine("Digite seu nome:");
                pessoa.nome = Console.ReadLine();
                Console.WriteLine("Digite o ano do seu Nascimento:");
                pessoa.idade = data.Year - int.Parse(Console.ReadLine());
                pessoa.andar1(pessoa.idade);
                Console.WriteLine("***************");
                usuarios.Add(pessoa);
                Console.WriteLine("Deseja finalizar? S/N ");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine("***********************");

            } while (resposta == 'N');

            foreach (var item in usuarios)
            {
                Console.WriteLine(item.nome);
                Console.WriteLine(item.idade);
                Console.WriteLine(item.andar);
            }


            Console.ReadKey();
        }
    }
}
