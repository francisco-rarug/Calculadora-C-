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
                MessageBox.Show("El botón no tiene un número asociado.");
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
                MessageBox.Show("Por favor, ingresa un número válido.");
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
                        MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Por favor, ingresa un número válido.");
                return;
            }

            Button btn = sender as Button;

            if (btn != null && btn.Tag != null)
            {
                // Intentamos convertir el Tag a int
                if (int.TryParse(btn.Tag.ToString(), out int operacionTag))
                {
                    operacion = (Operacion)operacionTag;
                    tbDisplay.Text = "";
                }
                else
                {
                    MessageBox.Show("El botón no tiene una operación asociada válida.");
                }
            }
            else
            {
                MessageBox.Show("El botón no tiene una operación asociada.");
            }
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

