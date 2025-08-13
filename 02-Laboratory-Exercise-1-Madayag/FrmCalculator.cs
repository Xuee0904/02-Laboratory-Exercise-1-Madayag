using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Laboratory_Exercise_1_Madayag
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal = new CalculatorClass();
        double num1, num2;

        public FrmCalculator()
        {
            InitializeComponent();

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");

            CalculateButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            CalculateButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            CalcLabel.ForeColor = ColorTranslator.FromHtml("#000907");
            label1.ForeColor = ColorTranslator.FromHtml("#363636");
            label2.ForeColor = ColorTranslator.FromHtml("#363636");
            label3.ForeColor = ColorTranslator.FromHtml("#222021");
            label4.ForeColor = ColorTranslator.FromHtml("#363636");
            label5.ForeColor = ColorTranslator.FromHtml("#363636");

            AnswerText.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
