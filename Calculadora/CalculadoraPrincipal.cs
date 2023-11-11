using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CalculadoraPrincipal
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public void InsertNaLista(int result)
        {
            listaHistorico.Insert(0, "Res: " + result + " data: " + data);
        }

        public int Somar(int num1, int num2)
        {
            var result = num1 + num2;
            InsertNaLista(result);
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            var result = num1 - num2;
            InsertNaLista(result);

            return result;
        }

        public int Multiplicar(int num1, int num2)
        {
            var result = num1 * num2;
            InsertNaLista(result);

            return result;
        }

        public int Dividir(int num1, int num2)
        {
            var result = num1 / num2;
            InsertNaLista(result);

            return result;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3 , listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}