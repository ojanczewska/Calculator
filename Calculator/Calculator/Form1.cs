using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String sign = "";
        Double num1 = 0;
       
        bool startNewNumber = false;
        private Form2 DigitalClock;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (startNewNumber))
                result.Clear();

            startNewNumber = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!result.Text.Contains(","))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (num1 != 0)
            {
                buttonEqual.PerformClick();
                startNewNumber = true;
                sign = b.Text;
                label1.Text = num1 + " " + sign;
            }
            else
            {
                sign = b.Text;
                num1 = Convert.ToDouble(result.Text);
                startNewNumber = true;
                label1.Text = num1 + " " + sign;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (sign)
            {
                case "+":
                    result.Text = (num1 + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (num1 - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (num1 * Double.Parse(result.Text)).ToString();
                    break;
                case "/": 
                    if (Double.Parse(result.Text) == 0)
                    {
                        result.Text = "Cannot be divided by 0";
                    }
                    else
                    {
                        result.Text = (num1 / Double.Parse(result.Text)).ToString();
                    }
                    break;
                default:
                    break;

            }
            num1 = Convert.ToDouble(result.Text);
            sign = "";

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";

        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Clear();
            num1 = 0;
            result.Text = "0";
        }

        private void buttonBAckspace_Click(object sender, EventArgs e)
        {
            if (result.Text.Length == 1)
            {
                result.Text = "0";
            }
            else
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(Convert.ToDouble(result.Text) * -1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "=":
                    buttonEqual.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonSubstract.PerformClick();
                    break;
                case "*":
                    buttonMultiply.PerformClick();
                    break;
                case "/":
                    buttonDivide.PerformClick();
                    break;
                case ".":
                    buttonComma.PerformClick();
                    break;
                default:
                   break;
            }
        }

        private void zmieńKolorKlawiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorGlg = new ColorDialog();
            if (colorGlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackground = colorGlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorGlg.Color;
            }
        }

        private void ChangeNumbersKeysColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorGlg = new ColorDialog();
            if (colorGlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.NumbersColor = colorGlg.Color;
                Properties.Settings.Default.Save();
                button0.BackColor = colorGlg.Color;
                button1.BackColor = colorGlg.Color;
                button2.BackColor = colorGlg.Color;
                button3.BackColor = colorGlg.Color;
                button4.BackColor = colorGlg.Color;
                button5.BackColor = colorGlg.Color;
                button6.BackColor = colorGlg.Color;
                button7.BackColor = colorGlg.Color;
                button8.BackColor = colorGlg.Color;
                button9.BackColor = colorGlg.Color;
            }
        }

        private void ChangeSignKeyColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorGlg = new ColorDialog();
            if (colorGlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SignColor = colorGlg.Color;
                Properties.Settings.Default.Save();
                buttonChange.BackColor = colorGlg.Color;
                buttonComma.BackColor = colorGlg.Color;
                buttonEqual.BackColor = colorGlg.Color;
                buttonAdd.BackColor = colorGlg.Color;
                buttonSubstract.BackColor = colorGlg.Color;
                buttonMultiply.BackColor = colorGlg.Color;
                buttonDivide.BackColor = colorGlg.Color;
                buttonBAckspace.BackColor = colorGlg.Color;
                buttonCE.BackColor = colorGlg.Color;
                buttonC.BackColor = colorGlg.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
            button0.BackColor = Properties.Settings.Default.NumbersColor;
            button1.BackColor = Properties.Settings.Default.NumbersColor;
            button2.BackColor = Properties.Settings.Default.NumbersColor;
            button3.BackColor = Properties.Settings.Default.NumbersColor;
            button4.BackColor = Properties.Settings.Default.NumbersColor;
            button5.BackColor = Properties.Settings.Default.NumbersColor;
            button6.BackColor = Properties.Settings.Default.NumbersColor;
            button7.BackColor = Properties.Settings.Default.NumbersColor;
            button8.BackColor = Properties.Settings.Default.NumbersColor;
            button9.BackColor = Properties.Settings.Default.NumbersColor;
            buttonComma.BackColor = Properties.Settings.Default.SignColor;
            buttonEqual.BackColor = Properties.Settings.Default.SignColor;
            buttonAdd.BackColor = Properties.Settings.Default.SignColor;
            buttonSubstract.BackColor = Properties.Settings.Default.SignColor;
            buttonMultiply.BackColor = Properties.Settings.Default.SignColor;
            buttonDivide.BackColor = Properties.Settings.Default.SignColor;
            buttonBAckspace.BackColor = Properties.Settings.Default.SignColor;
            buttonCE.BackColor = Properties.Settings.Default.SignColor;
            buttonC.BackColor = Properties.Settings.Default.SignColor;
            buttonChange.BackColor = Properties.Settings.Default.SignColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wyświetlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DigitalClock = new Form2();
            this.DigitalClock.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DigitalClock.Close();
        }

        private void zegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
