using System;
using System.Windows.Forms;
using PrackticumCL;
namespace Prakticum
{
    public partial class Task1Form : Form
    {
        Task3 task3 = new Task3();
        public Task1Form()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                

                task3 = new Task3(textBoxInputNumber.Text);
                if (task3.ResultTaskFactors.ToString() == (((-4 + Math.Sqrt(4 * 4 - 4 * 3 * 5)) / (2 * 3)).ToString() + " " + ((-4 - Math.Sqrt(4 * 4 - 4 * 3 * 5)) / (2 * 3)).ToString()))
                {
                   textBoxResult.Text = "NOT";
                }
                else
                {
                    textBoxResult.Text = task3.ResultTaskFactors.ToString();
                }

            }
            catch (Exception)
            {
                textBoxResult.Text = "incorrect number";
            }
        }

        private void Task1Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonResultFig_Click(object sender, EventArgs e)
        {
            task3 = new Task3(textBoxInputNumber.Text, true);
            string[] mas = task3.ResultTaskFactors.Split('!'); 
            for (int i = 0; i < mas.Length - 1; i++)
            {
                textBoxResult.Text += mas[i] + Environment.NewLine;
            }

        }
    }
}
