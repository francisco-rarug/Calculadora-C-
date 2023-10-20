namespace Rarug.Francisco.Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private Operacion operacion;
        private bool resultadoMostrado = false;


        private enum Operacion
        {
            Ninguna,
            Suma,
            Resta,
            Multiplicacion,
            Division
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                tbDisplay.Text = "";
                resultadoMostrado = false;
            }

            Button btn = sender as Button;

            if (btn != null && btn.Tag != null) 
            {
                tbDisplay.Text += btn.Tag.ToString();
            }
            else
            {
                MessageBox.Show("El bot�n no tiene un n�mero asociado.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            operacion = Operacion.Ninguna;
            resultadoMostrado = false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbDisplay.Text, out valor2))
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
                return;
            }

            switch (operacion)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    resultado = valor1 / valor2;
                    break;
            }
            tbDisplay.Text = resultado.ToString();
            resultadoMostrado = true;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                valor1 = resultado;
                resultadoMostrado = false;
            }
            else if (!double.TryParse(tbDisplay.Text, out valor1))
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
                return;
            }

            Button btn = sender as Button;
            operacion = (Operacion)btn.Tag;
            tbDisplay.Text = "";
        }


        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }
    }
}

