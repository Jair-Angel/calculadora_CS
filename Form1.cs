using System;
using System.Windows.Forms;

namespace calculadora_deskapp
{
    //todo: mirar por que no van bien las restas. 
    // mirar el stack de los numeros dobles despues de elegir operacion
    //funciona como el ojete
    public partial class calcForm : Form
    {
        double tmpVal = 0;
        double resultadoFinal = 0;
        string operacion = "";
        string historial = "";
        public calcForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //NUMEROS
        private void number_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultadoTxt.Text = resultadoTxt.Text + button.Text;

        }

        //RESULTADO
        private void calcularResultado(object sender, EventArgs e)
        {
            if (ControlLogico())
            {
                return;
            }
            switch (operacion)
            {
                case "+":
                    resultadoFinal = tmpVal + double.Parse(resultadoTxt.Text);
                    break;
                case "-":
                    resultadoFinal = tmpVal - double.Parse(resultadoTxt.Text);
                    break;
                case "*":
                    resultadoFinal = tmpVal * double.Parse(resultadoTxt.Text);
                    break;
                case "/":
                    resultadoFinal = tmpVal / double.Parse(resultadoTxt.Text);
                    break;
                default:
                    resultadoFinal = 0;
                    break;
            }
            historialOperaciones.Text = historialOperaciones.Text + double.Parse(resultadoTxt.Text) + " = " + resultadoFinal.ToString();
            resultadoTxt.Text = resultadoFinal.ToString();
            tmpVal = 0;
            operacion = "=";
        }

        //SUMAR
        private void sumar(object sender, EventArgs e)
        {

            if (ControlLogico())
            {
                return;
            }
            tmpVal += double.Parse(resultadoTxt.Text);
            operacion = "+";

            GrabarHistorial(operacion);
            LimpiarPantalla();
        }

        //RESTAR
        private void restar(object sender, EventArgs e)
        {
            if (ControlLogico())
            {
                return;
            }
            if (tmpVal == 0)
            {
                tmpVal = double.Parse(resultadoTxt.Text);
            }
            else
            {
                tmpVal -= double.Parse(resultadoTxt.Text);
            }

            operacion = "-";
            GrabarHistorial(operacion);
            LimpiarPantalla();
        }

        //MULTIPLICAR
        private void multiplicar(object sender, EventArgs e)
        {
            //ControlLogico();
            if (ControlLogico())
            {
                return;
            }
            if (tmpVal == 0)
            {
                tmpVal = double.Parse(resultadoTxt.Text);
            }
            else
            {
                tmpVal *= double.Parse(resultadoTxt.Text);
            }

            //historialOperaciones.Text = tmpVal.ToString();
            operacion = "*";
            GrabarHistorial(operacion);
            LimpiarPantalla();
        }

        //DIVIDIR
        private void dividir(object sender, EventArgs e)
        {
            if (ControlLogico())
            {
                return;
            }
            tmpVal = double.Parse(resultadoTxt.Text);
            if (resultadoTxt.Text != "0" && tmpVal != 0)
            {
                tmpVal /= double.Parse(resultadoTxt.Text);
                operacion = "/";
            }
            else
            {
                MessageBox.Show("No se puede dividir por 0!", "Error Matemático", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            GrabarHistorial(operacion);
            LimpiarPantalla();
        }

        //LIMPIAR PANTALLA
        private void limpiar(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        //RESET
        private void reset(object sender, EventArgs e)
        {
            ResetearOperaciones();
        }

        private void LimpiarPantalla()
        {
            resultadoTxt.Text = "";
        }

        private void ResetearOperaciones()
        {
            resultadoTxt.Text = "";
            historialOperaciones.Text = "";
            tmpVal = 0;
        }

        private bool ControlLogico()
        {
            if (resultadoTxt.Text == "" || resultadoTxt.Text == null)
            {
                // throw new System.ArgumentException("Introduce un número válido");
                MessageBox.Show("Introduce un número válido", "Error Matemático", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ResetearOperaciones();
                return true;
            }
            return false;
        }

        private void GrabarHistorial(string operacion)
        {

            historial = resultadoTxt.Text + " " + operacion;
            historialOperaciones.Text = historialOperaciones.Text + historial;
        }
    }
}
