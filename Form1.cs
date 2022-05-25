using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTeste
{
    public partial class Form1 : Form
    {
        private decimal valor1 = 0, valor2 = 0;
        private string operacao = "";

        public Form1()
        {
            InitializeComponent();
            txtResultado2.Visible = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num1 = 1;
            txtResultado.Text += num1;
            num1 = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num2 = 2;
            txtResultado.Text += num2;
            num2 = 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num3 = 3;
            txtResultado.Text += num3;
            num3 = 0;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num4 = 4;
            txtResultado.Text += num4;
            num4 = 0;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num5 = 5;
            txtResultado.Text += num5;
            num5 = 0;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num6 = 6;
            txtResultado.Text += num6;
            num6 = 0;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num7 = 7;
            txtResultado.Text += num7;
            num7 = 0;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num8 = 8;
            txtResultado.Text += num8;
            num8 = 0;
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num9 = 9;
            txtResultado.Text += num9;
            num9 = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado2.Visible = false;
            var num0 = 0;
            txtResultado.Text += num0;
            num0 = 0;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            var ponto = ".";
            txtResultado.Text += ponto;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado2.Visible = false;
                Calcular();
                LimparResultado1();
            }
            catch (Exception ex)
            {
                lblOperacao.Text = ex.Message;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = ($"{valor1} - ");
            }
            catch (Exception)
            {
                lblOperacao.Text = "Existem valores nulos";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "X";
                lblOperacao.Text = ($"{valor1} X ");
            }
            catch (Exception)
            {
                lblOperacao.Text = "Existem valores nulos";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = ($"{valor1} / ");
            }
            catch (Exception)
            {
                lblOperacao.Text = "Existem valores nulos";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor1 != null && valor2 != null)
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = "";
                    operacao = "SOMA";
                    lblOperacao.Text = ($"{valor1} + ");
                }
            }
            catch (Exception)
            {
                lblOperacao.Text = "Existem valores nulos";
            }
        }

        private void LimparResultado1()
        {
            txtResultado2.Visible = true;
            txtResultado2.Text = txtResultado.Text;
            txtResultado.Text = "";
        }

        private void Clear()
        {
            valor1 = 0;
            valor2 = 0;
            txtResultado.Text = "";
        }

        private void Calcular()
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = (valor1 + valor2).ToString("N15");
                lblOperacao.Text = ($"{valor1} + {valor2}  =  ");
            }
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = (valor1 - valor2).ToString("N15");
                lblOperacao.Text = ($"{valor1} - {valor2}  =  ");
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = (valor1 * valor2).ToString("N15");
                lblOperacao.Text = ($"{valor1} X {valor2}  =  ");
            }
            else
            {
                txtResultado.Text = (valor1 / valor2).ToString("N15");
                lblOperacao.Text = ($"{valor1} / {valor2}  =  ");
            }
        }
    }
}