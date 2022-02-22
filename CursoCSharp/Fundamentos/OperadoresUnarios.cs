using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!boleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);   // esse tipo de codigo pode geral confusão, nao se deve coloca-lo
            Console.WriteLine($"{numero1} {numero2}");


        


        }
    }
}
