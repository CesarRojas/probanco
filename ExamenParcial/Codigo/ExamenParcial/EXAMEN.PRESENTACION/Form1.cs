using EXAMEN.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN.PRESENTACION
{
    public partial class Form1 : Form
    {
        private Entero numero1, numero2;
        private int control, operador;
        private String cinta, numero2s;
        private bool sw = false; 

        public Form1()
        {
            InitializeComponent();
            numero1 = new Entero();
            numero2 = new Entero();
            control = 0;
            cinta = "";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "1";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "2";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "3";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "4";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "5";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "6";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "7";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "8";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "9";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "9";
            }
        }

        public void Limpiar()
        {
            lblPantalla.Text = "";
            numero1 = new Entero();
            numero2 = new Entero();
            numero2s = "";
            cinta = "";
            control = 0;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (control > 2)
            {
                Limpiar();
            }
            cinta = cinta + "0";
            lblPantalla.Text = cinta;
            if (control == 1)
            {
                numero2s = numero2s + "0";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                int numero11;
                if (int.TryParse(cinta, out numero11))
                {
                    numero1.Numero = numero11;
                    control++;
                    operador = 0;
                    cinta = cinta + "+";
                    lblPantalla.Text = cinta;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero por favor");
                    lblPantalla.Text = "";
                }
            }

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                int numero11;
                if (int.TryParse(cinta, out numero11))
                {
                    numero1.Numero = numero11;
                    control++;
                    cinta = cinta + "*";
                    operador = 2;
                    lblPantalla.Text = cinta;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero por favor");
                    lblPantalla.Text = "";
                }
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                int numero11;
                if (int.TryParse(cinta, out numero11))
                {
                    numero1.Numero = numero11;
                    control++;
                    operador = 1;
                    cinta = cinta + "-";
                    lblPantalla.Text = cinta;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero por favor");
                    lblPantalla.Text = "";
                }
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                int numero11;
                if (int.TryParse(cinta, out numero11))
                {
                    numero1.Numero = numero11;
                    control++;
                    operador = 3;
                    cinta = cinta + "/";
                    lblPantalla.Text = cinta;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero por favor");
                    lblPantalla.Text = "";
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (control == 1)
            {
                int numero11;
                if (int.TryParse(numero2s, out numero11))
                {
                    numero2.Numero = numero11;
                    control++;
            switch (operador)
            {
                case 0:
                    lblPantalla.Text = "";
                    int resultado = numero1.Suma(numero1.Numero, numero2.Numero);
                    Limpiar();
                    lblPantalla.Text = resultado.ToString();
                    sw = true;
                    break;
                case 1:
                    lblPantalla.Text = "";
                    resultado = numero1.Resta(numero1.Numero, numero2.Numero);
                    Limpiar();
                    lblPantalla.Text = resultado.ToString();
                    sw = true;
                    break;
                case 2:
                    lblPantalla.Text = "";
                    resultado = numero1.Multiplicar(numero1.Numero, numero2.Numero);
                    Limpiar();
                    lblPantalla.Text = resultado.ToString();
                    sw = true;
                    break;
                case 3:
                    if (numero2.Numero != 0)
                    {
                        lblPantalla.Text = "";
                        resultado = numero1.Dividir(numero1.Numero, numero2.Numero);
                        Limpiar();
                        lblPantalla.Text = resultado.ToString();
                    }
                            else
                            {
                        Limpiar();
                        MessageBox.Show("No se puede dividir entre 0");
                    }
                    sw = true;
                    break;
                default:
                    break;
            }
        }
                else
                {
                    MessageBox.Show("Debe ingresar un numero por favor");
                    lblPantalla.Text = "";
                    Limpiar();
                }
            }

        }

        private void btnEliminarPrimo_Click(object sender, EventArgs e)
        {
            int numero11;
            if (int.TryParse(lblPantalla.Text, out numero11))
            {
                numero2.Numero = numero11;
                int resultado = numero2.EliminarPrimos();
                lblPantalla.Text = resultado.ToString();
                control = 10;
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero por favor");
                lblPantalla.Text = "";
                Limpiar();
            }
        }

        private void lblPantalla_Click(object sender, EventArgs e)
        {

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            int numero11;
            if (int.TryParse(lblPantalla.Text, out numero11))
            {
                numero2.Numero = numero11;
                int resultado = numero2.InvertirNumero();
                lblPantalla.Text = resultado.ToString();
                control = 10;
            }
            else
        {
                MessageBox.Show("Debe ingresar un numero por favor");
                lblPantalla.Text = "";
                Limpiar();
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int numero11;
            if (int.TryParse(lblPantalla.Text, out numero11))
            {
                numero2.Numero = numero11;
                long resultado = numero2.FactorialRecursivo(numero2.Numero);
                lblPantalla.Text = resultado.ToString();
                control = 10;
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero por favor");
                lblPantalla.Text = "";
                Limpiar();
            }
        }

        
    }
}
