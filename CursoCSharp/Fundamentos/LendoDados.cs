using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {

     class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");


        }
    }
}
