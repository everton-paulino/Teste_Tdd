using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents2
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listahistorico.Insert(0, "Resultado" + resultado);
            return resultado;
        }

        public int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            listahistorico.Insert(0, "Resultado" + resultado);
            return resultado;
        }

        public int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, "Resultado" + resultado);
            return resultado;
        }

        public int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            listahistorico.Insert(0, "Resultado" + resultado);
            return resultado;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
