using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        double acumula = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisual.Text += "0";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(txtVisual.Text);
                txtVisual.Text = "";
                operacao = "*";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(txtVisual.Text);
                txtVisual.Text = "";
                operacao = "/";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(txtVisual.Text);
                txtVisual.Text = "";
                operacao = "-";
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(txtVisual.Text);
                txtVisual.Text = "";
                operacao = "+";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(txtVisual.Text);
                txtVisual.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(txtVisual.Text);
                txtVisual.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(txtVisual.Text);
                txtVisual.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(txtVisual.Text) != 0)
                {
                    acumula /= double.Parse(txtVisual.Text);
                    txtVisual.Text = acumula.ToString();
                }
                else
                {
                    txtVisual.Text = "Dividindo por zero";
                }
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            txtVisual.Text = "";
            operacao = "";
        }
    }
}
