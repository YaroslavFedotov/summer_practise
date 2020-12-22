using System;
using System.Windows.Forms;
using PrackticumCL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            string[] Buf = { " " };
            Buf[0] = " ";
            String sNumbers;
            try
            {
                StreamReader sr = new StreamReader("Task 1.txt");
                sNumbers = sr.ReadLine();
                Buf = sNumbers.Split(' ');
                sr.Close();
                textBoxInputNumber.Text = Buf[0];
            }
            catch (Exception)
            {
                textBoxResult.Text = "incorrect number";
            }
            try
            {
                if (int.Parse(Buf[0]) < 0)
                {
                    textBoxResult.Text = "incorrect number";
                }
                else
                {
                    task1 = new Task1(int.Parse(Buf[0]));
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Buf;
            String sNumbers;
            try
            {
                StreamReader sr = new StreamReader("Task 1.txt");
                sNumbers = sr.ReadLine();
                Buf = sNumbers.Split(' ');
                sr.Close();
                textBoxInputNumber.Text = Buf[0];
            }
            catch
            {
                textBoxResult.Text = "Ошибка чтения файла!";
            }      
        }
    }
}
