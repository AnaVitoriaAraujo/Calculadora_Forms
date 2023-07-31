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
                
        }//botao igual

        private void label3_Click(object sender, EventArgs e)
        {

        }//segundo numero

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = ("" +this.Modelo.Subtrair());
        }//Subtrair

        private void button6_Click(object sender, EventArgs e)
        {
            double getnum1 = Convert.ToInt32(maskedTextBox2.Text);
            double getnum2 = Convert.ToInt32(maskedTextBox1.Text);
            double resultado = getnum1 + getnum2;
            maskedTextBox1.Text = ("Esse é o resultado: " + resultado);

        }//Soma

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = ("Esse é o resultado: " + this.Modelo.Somar());

        }//Potencia

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = ("Esse é o resultado: " + this.Modelo.Somar());
        }//Dividir

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = ("Esse é o resultado: " + this.Modelo.Multiplicar());
        }//Multiplicar
    }
}
