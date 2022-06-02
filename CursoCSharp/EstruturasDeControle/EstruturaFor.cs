using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
     class EstruturaFor {
        public static void Executar() {
            //int i = 1;

            //while(i <= 10) {
            //    Console.WriteLine($"O valor de i é {i}.");

            // EXEMPLO EM WHILE

            //for(int i = 0; i <= 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}. ");

            //}
            //MESMO EXEMPLO EM FOR

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da Turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno{0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}",media);

        }
    }
}
