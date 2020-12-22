using System;
using System.Windows.Forms;
using PrackticumCL;
namespace Prakticum
{
    public partial class Task1Form : Form
    {
        Task1 task1 = new Task1();
        public Task1Form()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxInputNumber.Text) < 0)
                {
                    textBoxResult.Text = "incorrect number";
                }
                else
                {
                    task1 = new Task1(int.Parse(textBoxInputNumber.Text));
                    textBoxResult.Text = task1.ResultTaskFactors.ToString();
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
    }
}
