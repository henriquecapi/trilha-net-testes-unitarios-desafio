using System;
using System.Collections.Generic;
using TestesUnitarios.Desafio.Services;

namespace TestesUnitarios.Desafio.Models
{
    public class ValidacoesComStrings
    {
         public static void ValidaStrings()
        {
            string texto = "Henrique_Capibaribe";
            int numeroDeCaracters = 0;
            bool temCaracter, terminaCom = false;

            ValidacoesString Vds = new ValidacoesString();

            numeroDeCaracters = Vds.RetornarQuantidadeCaracteres(texto);
            Console.WriteLine($"Quantos caracteres tem na palavra ({texto}): {numeroDeCaracters} caracteres");
            Console.WriteLine("----------------------------------------------------------------------------");

            temCaracter = Vds.ContemCaractere(texto,"X");
            Console.WriteLine($"A palavra ({texto}) contem o caracter (X): {temCaracter}");
            temCaracter = Vds.ContemCaractere(texto,"C");
            Console.WriteLine($"A palavra ({texto}) contem o caracter (C): {temCaracter}");
            Console.WriteLine("----------------------------------------------------------------------------");

            terminaCom = Vds.TextoTerminaCom(texto,"Capibaribe");
            Console.WriteLine($"A palavra ({texto}) termina com a palavra (Capibaribe): {terminaCom}");
            terminaCom = Vds.TextoTerminaCom(texto,"Henrique");
            Console.WriteLine($"A palavra ({texto}) termina com a palavra (Henrique): {terminaCom}");


        }
    }
}