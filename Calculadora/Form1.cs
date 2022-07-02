namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string temporal = null;
        double valor1 = 0;
        double valor2 = 0;
        String operacion = null;

        private void numero_1_Click(object sender, EventArgs e)
        {
            temporal = temporal+"1";
        }

        private void numero_2_Click(object sender, EventArgs e)
        {
            temporal = temporal + "2";
        }

        private void numero_3_Click(object sender, EventArgs e)
        {
            temporal = temporal + "3";
        }

        private void numero_4_Click(object sender, EventArgs e)
        {
            temporal = temporal + "4";
        }

        private void numero_5_Click(object sender, EventArgs e)
        {
            temporal = temporal + "5";
        }

        private void numero_6_Click(object sender, EventArgs e)
        {
            temporal = temporal + "6";
        }

        private void numero_7_Click(object sender, EventArgs e)
        {
            temporal = temporal + "7";
        }

        private void numero_8_Click(object sender, EventArgs e)
        {
            temporal = temporal + "8";
        }

        private void numero_9_Click(object sender, EventArgs e)
        {
            temporal = temporal + "9";
        }

        private void numero_0_Click(object sender, EventArgs e)
        {
            temporal = temporal + "0";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            temporal = temporal + ".";
        }

        private void borrar_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            if(temporal != null)
            {
                if (valor1 == 0)
                {
                    valor1 = double.Parse(temporal.ToString());
                    presentar(valor1.ToString());
                    temporal = null;
                }
                else if (valor2 == 0)
                {
                    valor2 = double.Parse(temporal.ToString());
                    presentar(valor2.ToString());
                    temporal = null;
                }

                
            }
        }

        private void itbis_Click(object sender, EventArgs e)
        {
            if(valor1 > 0)
            {
                double itbis = valor1 * 0.18;
                resultado.Text = resultado.Text + " Resultado Itbis (18%): " + itbis.ToString() + System.Environment.NewLine;
                valor1 = 0;
            }
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (valor1 > 0)
            {
                double raiz_cuadrada = Math.Sqrt(valor1);
                resultado.Text = resultado.Text + " Raiz Cuadrada : " + raiz_cuadrada.ToString() + System.Environment.NewLine;
                valor1 = 0;
            }
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentar(String s)
        {
            resultado.Text = resultado.Text + " " + s + System.Environment.NewLine;
        }

        private void prevista(String s)
        {
            resultado.Text = resultado.Text + s;
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            if (operacion == "+")
            {
                //Sumamos
                double suma = valor1 + valor2;
                resultado.Text = resultado.Text + " Resultado: " + suma.ToString() + System.Environment.NewLine;
            }
            if (operacion == "*")
            {
                //Multiplicamos
                double mult = valor1 * valor2;
                resultado.Text = resultado.Text + " Resultado: " + mult.ToString() + System.Environment.NewLine;
            }
            if (operacion == "/")
            {
                //Dividimos
                double div = valor1 / valor2;
                resultado.Text = resultado.Text + " Resultado: " + div.ToString() + System.Environment.NewLine;
            }
            if (operacion == "-")
            {
                //Resta
                double resta = valor1 - valor2;
                resultado.Text = resultado.Text + " Resultado: " + resta.ToString() + System.Environment.NewLine;
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (operacion == null)
            {
                operacion = "*";
                presentar(operacion);
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (operacion == null)
            {
                operacion = "/";
                presentar(operacion);
            }
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            if (operacion == null)
            {
                operacion = "+";
                presentar(operacion);
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (operacion == null)
            {
                operacion = "-";
                presentar(operacion);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            operacion = null;
            temporal = null;
            resultado.Clear();
        }

        
    }
}