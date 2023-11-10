using System;
using System.Windows.Forms;

namespace Actividad_4

{
    public partial class Form1 : Form
    {
        private CalculadoraServidor calculadoraServidor = new CalculadoraServidor();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores de los controles
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                // Realiza el cálculo
                int resultado = calculadoraServidor.Sumar(x, y);

                // Muestra el resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                // Muestra el mensaje de la excepción
                MessageBox.Show("Falta rellenar campos");
            }
        }


        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores de los controles
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                // Realiza el cálculo
                int resultado = calculadoraServidor.Restar(x, y);

                // Muestra el resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                // Muestra el mensaje de la excepción
                MessageBox.Show("Falta rellenar campos");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores de los controles
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                // Realiza el cálculo
                int resultado = calculadoraServidor.Multiplicar(x, y);

                // Muestra el resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                // Muestra el mensaje de la excepción
                MessageBox.Show("Falta rellenar campos");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores de los controles
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                // Realiza el cálculo
                int resultado = calculadoraServidor.Dividir(x, y);

                // Muestra el resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception )
            {
                // Muestra el mensaje de la excepción
                MessageBox.Show("Falta rellenar campos");
            }
        }
    }
}