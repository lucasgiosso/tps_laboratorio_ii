using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador ingresado.
        /// </summary>
        /// <param name="operador">Operador seleccionado</param>
        /// <returns>Devuelve el operador seleccionado, sino devuelve '+'</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorCalculadora;

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                operadorCalculadora = operador;
            }
            else
            {
                operador = '+';
            }
            return operador;
        }

        /// <summary>
        /// Realizar la operacion entre 2 números.
        /// </summary>
        /// <param name="num1">Primer Operando</param>
        /// <param name="num2">Segundo Operando</param>
        /// <param name="operador">Operador seleccionado</param>
        /// <returns>Retorna el resultado de la operación.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorCalculadora;

            operadorCalculadora = ValidarOperador(operador);

            switch (operadorCalculadora)
            {
                case '-':
                    return num1 - num2;

                case '*':
                    return num1 * num2;
                    
                case '/':
                    return num1 / num2;
                    
                default:
                    return num1 + num2;     
            }
        }
    }
}
