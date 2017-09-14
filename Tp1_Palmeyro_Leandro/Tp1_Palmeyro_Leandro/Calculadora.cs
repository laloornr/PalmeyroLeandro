using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Palmeyro_Leandro
{
    public class Calculadora
    {

        /// <summary>
        /// Realiza la operacion indicada entre los objetos Numero que recibe y el operador
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion y en caso de division por 0 retorna 0</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;

            switch (validarOperador(operador))
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;

                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;

                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;

                case "/":
                    if (numero2.getNumero() != 0)
                    {
                        resultado = numero1.getNumero() / numero2.getNumero();
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
            }

            return resultado;
        }


        /// <summary>
        /// Valida los operadores recibidos
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Valida si el operador es uno de los indicados, en caso contrario retorna un "+"</returns>
        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }
            return operador; ;
        }
    }
}
