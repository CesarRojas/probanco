using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN.NEGOCIO
{
    public class Entero
    {

                private int numero;

        public int Numero { set { numero = value; } get { return numero; } }

        public Entero()
        {

        }

        public Entero(int numero)
        {
            this.numero = numero;
        }

        public int Suma(int numero1, int numero2) {
            return numero1 + numero2;
        }

        public int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return (numero1 * numero2);
        }

        public int Dividir(int numero1, int numero2) 
        {
            return (int)(numero1 / numero2);
        }
       
        public Boolean EsPrimo(int numero)
        {
            if (numero == 0)
                return false;
            if (numero == 1)
                return false;
            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    if (i != numero)
                        return false;
                }
            }
            return true;
        }

        public int EliminarPrimos()
        {
            int num2 = Numero, resultado = 0;
            int cantCeros = CantCerosFinal(num2);
            int invertir = InvertirNumero();
            int resto;
            while (invertir != 0)
            {
                resto = invertir % 10;
                if (!EsPrimo(resto))
                {
                    resultado = resultado * 10 + resto;
                }
                invertir = invertir / 10;
            }
            resultado = resultado * (int)Math.Pow(10, cantCeros);
            return resultado;
        }

        public int CantCerosFinal(int numero)
        {
            int cont = 0;
            int resto;
            Boolean sw = false;
            while (numero != 0)
            {
                resto = numero % 10;
                if (resto == 0)
                {
                    if (sw == false)
                        cont++;
                }
                else
                    sw = true;

                numero = numero / 10;

            }
            return cont;
        }
        public int InvertirNumero()
        {
            int invertir = 0,
                resto,
                num2 = Numero;
            while (num2 != 0)
            {
                resto = num2 % 10;
                invertir = invertir * 10 + resto;
                num2 = num2 / 10;
            }
            return invertir;

        }

        public long Factorial()
        {
            int copia = Numero;
            long factorial = 1;
            if (Numero > 0)
            {
                for (int i = 1; i < copia + 1; i++)
                {
                    factorial = factorial * i;
                }
            }
            return factorial;
        }

        public long FactorialRecursivo(int numero)
        {
            if (numero > 0)
            {
                long valor = numero * FactorialRecursivo(numero - 1);
                return valor;
            }
            else
                return 1;
        }


    }

    
}
