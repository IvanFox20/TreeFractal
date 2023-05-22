using System;
using System.Windows.Forms;

namespace TreeFractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            int aplhaAngle = Convert.ToInt32(textBox_AlphaAngle.Text);
            int betaAngle = Convert.ToInt32(textBox_BetaAngle.Text);
            double coef = Convert.ToDouble(textBox_Coef.Text);
            int startLength = Convert.ToInt32(textBox_StartLength.Text);
            int stepsCount = Convert.ToInt32(textBox_StepsCount.Text);
            Graph form = new Graph(aplhaAngle, betaAngle, coef, startLength, stepsCount);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}