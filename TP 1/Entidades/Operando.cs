using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Setea el numero previa validación.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// Constructor por defecto que inicializa a numero en 0.
        /// </summary>
        public Operando() : this(0)
        {
            
        }

        /// <summary>
        /// Constructor de tipo double que setea el valor enviado.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de tipo string que setea el valor enviado.
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Validar que el valor recibido sea un número.
        /// </summary>
        /// <param name="strNumero">Numero de tipo string que va validarse.</param>
        /// <returns>Devuelve el número validado, si no es valido devuelve 0.</returns>
        private static double ValidarOperando(string strNumero)
        {
            double numero;

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }

        /// <summary>
        /// Valida si un número de tipo string es binario.
        /// </summary>
        /// <param name="binario">Número de tipo string a validar.</param>
        /// <returns>Devuelve el número binario si es valida, sino no</returns>
        private bool esBinario(string binario)
        {
            if (!string.IsNullOrWhiteSpace(binario))
            {
                for (int i = 0; i < binario.Length - 1; i++)
                {
                    if (binario[i] != '0' && binario[i] != '1')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="binario">Valor de tipo string a convertir.</param>
        /// <returns>Retorna un valor de tipo string con el número decimal.</returns>
        public string BinarioDecimal(string binario)
        {
            string numeroBinario = string.Empty;
            double num = 0;
            int cantidadCaracteres = binario.Length;

            if (esBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;

                    if (caracter == '1')
                    {
                        num = num + Math.Pow(2, cantidadCaracteres);
                    }
                }
                numeroBinario = num.ToString();
            }
            else
            {
                numeroBinario = "Valor Invalido";
            }

            return numeroBinario;
        }

        /// <summary>
        /// Convierte un número decimal(entero positivo) de tipo double a binario.
        /// </summary>
        /// <param name="numero">Valor de tipo double a convertir.</param>
        /// <returns>Retorna un valor de tipo string con el numero binario.</returns>
        public string DecimalBinario(double numero)
        {
            string str = string.Empty;
            int resultDiv = (int)Math.Abs(numero);
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = (int)resultDiv % 2;
                    resultDiv = (int)resultDiv / 2;
                    str = restoDiv.ToString() + str;

                } while (resultDiv > 0);
            }
            else
            {
                str = "Valor Invalido.";
            }

            return str;
        }

        /// <summary>
        /// Convierte el valor recibido(número decimal y entero positivo) como string a binario.
        /// </summary>
        /// <param name="numero">Valor(numero decimal) a convertir</param>
        /// <returns>Retorna el valor de tipo string con el número binario.</returns>
        public string DecimalBinario(string numero)
        {
            double numeroD;
            string strNumero = "Valor Invalido";

            if (double.TryParse(numero, out numeroD))
            {
                strNumero = DecimalBinario(numeroD);
            }

            return strNumero;
        }

        /// <summary>
        /// Sobrecarga del operador suma. 
        /// </summary>
        /// <param name="num1">Valor 1 de tipo Operando</param>
        /// <param name="num2">Valor 2 de tipo Operando</param>
        /// <returns>Retorna la suma de 2 números</returns>
        public static double operator + (Operando num1, Operando num2)
        {
            return (num1.numero + num2.numero);
        }

        /// <summary>
        /// Sobrecarga del operador resta.
        /// </summary>
        /// <param name="num1">Valor 1 de tipo Operando</param>
        /// <param name="num2">Valor 2 de tipo Operando</param>
        /// <returns>Retorna la resta de 2 números</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return (num1.numero - num2.numero);
        }

        /// <summary>
        /// Sobrecarga del operador multiplicación.
        /// </summary>
        /// <param name="num1">Valor 1 de tipo Operando</param>
        /// <param name="num2">Valor 2 de tipo Operando</param>
        /// <returns>Retorna la multiplicación de 2 números</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return (num1.numero * num2.numero);
        }

        /// <summary>
        /// Sobrecarga del operador división.
        /// </summary>
        /// <param name="num1">Valor 1 de tipo Operando</param>
        /// <param name="num2">Valor 2 de tipo Operando</param>
        /// <returns>Retorna la división de 2 números, y
        /// en el caso de que sea 0 devuelvo un valor minimo.</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            double valorMinimo = double.MinValue;

            if (num2.numero != 0)
            {
                valorMinimo = num1.numero / num2.numero;
            }

            return valorMinimo;
        }


    }
}
