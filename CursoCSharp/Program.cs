using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos ", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos ", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos ", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados  - Fundamentos", LendoDados.Executar },
                {"Formatando Número  - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                
                // Estruras de Controle
                {" - Estrutura If - Estruturas de controle", EstruturaIf.Executar },
                {" - Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar },
                {" - Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar },
                {" - Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar },
                {" - Estrutura While - Estruturas de controle", EstruturaWhile.Executar },
                {" - Estrutura DoWhile - Estruturas de controle", EstruturaDoWhile.Executar },
                {" - Estrutura For - Estruturas de controle", EstruturaFor.Executar },
                {" - Estrutura Foreach - Estruturas de controle", EstruturaForEach.Executar },
                {" - Usando Break - Estruturas de controle", UsandoBreak.Executar },
                {" - Usando Continue - Estruturas de controle", UsandoContinue.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}