using System;

namespace Exercicio03Cap04
{
    class Aluno
    {
        public double Nota01, Nota02,  Nota03, Faltante;
        public double NotaDoAluno()
        {
            double TotalDasNotas = Nota01 + Nota02 + Nota03;
            Faltante = 60 - TotalDasNotas;
            
            return TotalDasNotas;
        }
        public override string ToString()

        {
            if (NotaDoAluno() < 60)
            {

               return "Aluno Reprovado \nSua nota foi de "
                + NotaDoAluno()
                + "\nFaltam "
                + Faltante
                +" para ser aprovado";
            }
            else
            {
               return "Aluno Aprovado \nSua nota foi de "
                + NotaDoAluno();

            }
        }
    }
}
