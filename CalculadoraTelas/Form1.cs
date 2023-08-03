using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculadoraTelas
{
    public partial class Form1 : Form
    {
        Model Modelo;
        
        public Form1()
        {
            InitializeComponent();
            this.Modelo = new Model();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//titulo principal

        private void label2_Click(object sender, EventArgs e)
        {

        }//informe o primeiro numero

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Raiz(Convert.ToDouble(maskedTextBox1.Text));

        }//Raiz

      
        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }//Subtrair

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));

        }//Soma

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Potencia(Convert.ToDouble(maskedTextBox1.Text));

        }//Potencia

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Dividir(Convert.ToDouble(maskedTextBox1.Text));
        }//Dividir

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Multiplicar(Convert.ToDouble(maskedTextBox1.Text));
        }//Multiplicar

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Modelo.Limpa(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
