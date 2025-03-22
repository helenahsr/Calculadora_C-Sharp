using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double n1 = 0, n2 = 0, total = 0;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + "9";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtnum.Text = txtnum.Text + ".";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtnum.Text);
            operador = "SOMAR";
            txtnum.Text = "";
            lbloperador.Text = "+";
        }

        private void btnsubt_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtnum.Text);
            operador = "SUBTRAIR";
            txtnum.Text = "";
            lbloperador.Text = "-";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtnum.Text);
            operador = "MULTIPLICAR";
            txtnum.Text = "";
            lbloperador.Text = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtnum.Text);
            operador = "DIVIDIR";
            txtnum.Text = "";
            lbloperador.Text = "/";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtnum.Text);

            if (operador == "SOMAR")
            {
                total = n1 + n2;
                txtnum.Text = total.ToString();
                lbloperador.Text = "";
            }
            else if (operador == "SUBTRAIR")
            {
                total = n1 - n2;
                txtnum.Text = total.ToString();
                lbloperador.Text = "";
            }
            else if (operador == "MULTIPLICAR")
            {
                total = n1 * n2;
                txtnum.Text = total.ToString();
                lbloperador.Text = "";
            }
            else
            {
                total = n1 / n2;
                txtnum.Text = total.ToString();
                lbloperador.Text = "";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
            lbloperador.Text = "";
            n1 = 0;
            n2 = 0;
            operador = "";
        }
    }
}
