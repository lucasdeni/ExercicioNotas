using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Aluno
    {
        public static string Nome;
        public static double Nota1;
        public static double Nota2;
        public static double Nota3;

        public static double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public static double Resto()
        {
            return 60 - (Nota1 + Nota2 + Nota3);
        }
    }
}
