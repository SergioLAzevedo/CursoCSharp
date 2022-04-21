using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CursoCSharp.EstruturasDeControle {
    public class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestante = 5;
            int tentativas = 0;

            while (tentativasRestante > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestante--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} Tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;

                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor ... Tente novamente !");
                    Console.WriteLine("Tentativas restante: {0}", tentativasRestante);
                } else {
                    Console.WriteLine("Maior tentativa... Tente novamente");
                    Console.WriteLine("Tentativas restante {0}", tentativasRestante);
                }
            }

        }
    }
}

