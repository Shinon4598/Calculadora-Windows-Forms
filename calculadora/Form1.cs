
using System.Drawing;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double numero;
        private char operador;
        private double respuesta;
        private bool primerNumero = true;
        private bool primerOperador = true;


        public Form1()
        {
            InitializeComponent();
        }


        private void MostrarPantalla(string caracter, bool simbolo = false, bool igual = false)
        {
            string operadores = "+-/x";

            //Si repite un operador, que lo ignore
            if (simbolo && lblPantalla.Text == caracter && !igual)
                return;

            //Para que borre el operador de la pantalla cuando pongan un número
            if (operadores.Contains(lblPantalla.Text[0]))
            {
                lblPantalla.Text = lblPantalla.Text.TrimStart(lblPantalla.Text[0]);
            }

            //Esperando el tercer numero para la operación luego de que aparezca el segundo simbolo
            else if (!primerNumero && simbolo && !primerOperador)
            {
                if (double.TryParse(lblPantalla.Text, out double numA))
                {
                    this.numero = numA;

                    if (!igual)
                    {
                        Calcular();
                        this.operador = char.Parse(caracter);
                    }
                    else
                    {
                        Calcular(true);
                        //Esperar el siguiente operador
                        this.primerOperador = true;
                    }
                }
                else
                {
                    MessageBox.Show(lblPantalla.Text, "no funciona :(", MessageBoxButtons.OK);
                }
            }

            //Esperando el primer numero de todos
            if (primerNumero && simbolo)
            {
                respuesta = double.Parse(lblPantalla.Text);
                primerNumero = false;
            }

            //Esperando el primer operador de todos
            if (!primerNumero && simbolo && primerOperador && !igual)
            {
                this.operador = char.Parse(caracter);
                primerOperador = false;
            }

            //Borrar los números por si hay un operador/simbolo
            if (lblPantalla.Text == "0" || (simbolo && lblPantalla.Text != caracter))
                lblPantalla.Text = "";

            //Mostrar el resultado o el caracter presionado
            lblPantalla.Text = igual ? respuesta.ToString() : lblPantalla.Text + caracter;
        }

        private void Calcular(bool igual = false)
        {
            switch (this.operador)
            {
                case '+': Sumar(); break;
                case '-': Restar(); break;
                case 'x': Multiplicar(); break;
                case '/': Dividir(); break;
            }
        }

        private void Sumar()
        {
            this.respuesta += this.numero;
        }

        private void Restar()
        {
            this.respuesta -= this.numero;
        }

        private void Multiplicar()
        {
            this.respuesta *= this.numero;
        }

        private void Dividir()
        {
            this.respuesta /= this.numero;
        }

        private void lblPantalla_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn9.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn7.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn4.Text);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn5.Text);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn6.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn3.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn0.Text);
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btnMas.Text, true);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            MostrarPantalla(this.respuesta.ToString(), true, true);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btn8.Text);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btnResta.Text, true);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btnMultiplicar.Text, true);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btnDividir.Text, true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.numero = 0;
            this.primerNumero = true;
            this.primerOperador = true;
            lblPantalla.Text = "0";
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length > 1)
            {
                lblPantalla.Text = lblPantalla.Text.Remove(lblPantalla.Text.Length - 1);
            }
            else if (!string.IsNullOrEmpty(lblPantalla.Text))
            {
                lblPantalla.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblPantalla.Text, out decimal resultado))
                lblPantalla.Text = (resultado * -1).ToString();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            MostrarPantalla(btnComa.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "0";
        }
    }
}
