using System;

namespace Exercicio03Cap04
{
    class Aluno
    {
        public double Nota01, Nota02,  Nota03;
        public double NotaDoAluno()
        {
            double TotalDasNotas = Nota01 + Nota02 + Nota03;
            return TotalDasNotas;
        }
        public override string ToString()

        {
            if (NotaDoAluno() < 60)
            {
               return "Aluno Reprovado \nSua nota foi de "
                + NotaDoAluno();
            }
            else
            {
               return "Aluno Aprovado \nSua nota foi de "
                + NotaDoAluno();

            }
        }
    }
}