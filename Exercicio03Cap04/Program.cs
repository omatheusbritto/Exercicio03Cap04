﻿// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
// (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
// ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
// para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
// este problema

using System;
using System.Globalization;

namespace Exercicio03Cap04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Programa Para ler nota do aluno \n");
            Console.Write("Entre com a primeira nota do aluno: ");
            aluno.Nota01 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota do aluno: ");
            aluno.Nota02 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota do aluno: ");
            aluno.Nota03 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(aluno);
        }

    }
}