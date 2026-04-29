using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double xmin, xmax, dx, k, beta;

            try
            {
                xmin = double.Parse(textBoxXmin.Text);
                xmax = double.Parse(textBoxXmax.Text);
                dx = double.Parse(textBoxDx.Text);
                k = double.Parse(textBoxK.Text);
                beta = double.Parse(textBoxBeta.Text);
            }
            catch
            {
                MessageBox.Show("Помилка вводу даних!");
                return;
            }

            if (dx <= 0)
            {
                MessageBox.Show("dx має бути > 0");
                return;
            }

            for (double x = xmin; x <= xmax; x += dx)
            {
                try
                {
                    if (x <= 0)
                        throw new Exception("ln(x) не існує при x <= 0");

                    double sinValue = Math.Sin(beta * x);

                    if (sinValue == 0)
                        throw new Exception("sin(βx) = 0");

                    double y = Math.Sqrt(Math.Log(x)) + (k * x) / sinValue;

                    listBox1.Items.Add($"x={x:F2}   y={y:F6}");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"x={x:F2}   ERROR: {ex.Message}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}