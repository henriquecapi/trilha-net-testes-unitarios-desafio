using System;
using System.Collections.Generic;
using TestesUnitarios.Desafio.Services;

namespace TestesUnitarios.Desafio.Models
{
    public class ValidacoesComListas
    {
        public static void ValidaListas()
        {
            List<int> numero = new List<int>();
            Random random = new Random();

            // Preencher minha lista de números
            Console.WriteLine("Imprime 25 numeros aleatórios intercalados positivos e negativos:");
            for (int x = 0; x <= 24; x++)
            {
                int numeroAleatorio = random.Next(1, 100) * IndiceMult(x);
                numero.Add(numeroAleatorio); // Adiciona o número aleatório à lista
                Console.Write(numero[x]+" ,");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            ValidacoesLista Vdl = new ValidacoesLista();
            numero = Vdl.RemoverNumerosNegativos(numero);

            // Imprime numeros agora só positivos;
            Console.WriteLine("Imprime numeros agora só positivos:");
            foreach (var item in numero)
            {
                Console.Write(item+" ,");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // Verifica se a lista contém Determinados números;
            Console.WriteLine("Verifica se a lista contém Determinados números:");
            for (int x = 0; x <= 11; x++)
            {
                int numeroAleatorio = random.Next(1, 100);
                Console.Write($"{numeroAleatorio} {Vdl.ListaContemDeterminadoNumero(numero,numeroAleatorio)} ,");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // Multiplica numero da lista por 2;
            List<int> numeroX2 = new List<int>();
            numeroX2 = Vdl.MultiplicarNumerosLista(numero,2);
            Console.WriteLine("Multiplica cada numero da lista por 2:");
            foreach (var item in numeroX2)
            {
                Console.Write(item+" ,");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // Retorna o maior numero da lista;
            Console.WriteLine("Retorna o maior numero da lista:");
            Console.WriteLine(Vdl.RetornarMaiorNumeroLista(numeroX2));

            Console.WriteLine("");

            // Retorna o menor numero da lista;
            Console.WriteLine("Retorna o maior menor da lista:");
            Console.WriteLine(Vdl.RetornarMenorNumeroLista(numeroX2));

        }
         static int IndiceMult(int nun)
        {
            if (nun % 2 == 0)
                return 1;
            else
                return -1;
        }
    }
}