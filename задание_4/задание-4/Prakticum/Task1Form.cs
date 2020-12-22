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
        Task4 task4 = new Task4();
        public Task1Form()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("birthday.in.txt");
                String[] S1data = sr.ReadLine().Split(' ');
                String[] S2data = sr.ReadLine().Split(' ');
                sr.Close();
                if (int.Parse(S2data[2]) > 3000 | int.Parse(S2data[2]) < 1920)
                {
                    StreamWriter sw = new StreamWriter("birthday.out.txt");
                    sw.WriteLine("Неверный год");
                    sw.Close();
                }
                else
                {
                    task4 = new Task4(S1data, S2data);
                    StreamWriter sw = new StreamWriter("birthday.out.txt");
                    sw.WriteLine(task4.ResultTaskFactors);
                    sw.Close();
                }
                
            }
            catch (Exception)
            {
                StreamWriter sw = new StreamWriter("birthday.out.txt");
                sw.WriteLine("Неверный формат файла");
                sw.Close();
            }
        }
        private void Task1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
