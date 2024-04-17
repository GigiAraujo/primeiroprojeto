using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Olá Mundo");

              int idade = 23;
              Console.WriteLine("A minha idade é: " + idade);


              *//*OPERAÇÕES MATEMÁTICAS*//*
              int numero1 = 9;
              int numero2 = 3;

              int soma = numero1 + numero2;
              int subtracao = numero1 - numero2;
              int multiplicacao = numero1 * numero2;
              int divisao = numero1 / numero2;

              Console.WriteLine(divisao);
              Console.WriteLine(multiplicacao);
              Console.WriteLine(subtracao);
              Console.WriteLine(soma);

              double salario = 1500.86;
              Console.WriteLine(salario);
*/


            /*int reais = 35;
            int horas = 8;

            int multiplicacao = reais * horas;

            Console.WriteLine(multiplicacao);*/

            /* int unidade = 27;
             int caixa = 16;

             int multiplicacao = caixa * unidade;

             Console.WriteLine(multiplicacao);*/

            /* int numero1 = 1;
             int numero2 = 3;

             int soma = numero1 + numero2;

             Console.WriteLine(soma);*/

            /*  int garrafa = 300;
              int caixa = 20;

              int divisao = garrafa / caixa;

              Console.WriteLine(divisao);*/

            int instalacao = 300;
            int limpeza = 150;
            double manutencao = 499.99;
            int desconto = 50;

            double termal = (instalacao + limpeza + manutencao) - desconto;
           
            Console.WriteLine(termal);
           
        }
    }
}

