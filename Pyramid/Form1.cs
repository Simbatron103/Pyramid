using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = PyramidVolym(textBox4.Text);
           
        }
        public string PyramidVolym(string höjd)
        {
            double höjdDouble = double.Parse(textBox3.Text);
            double Area = PyramidArea(höjdDouble);
            double volym = (Area * höjdDouble) / 3;
            return volym.ToString();

        }
        public double PyramidArea(double Bas)
        {
            double längd = double.Parse(textBox1.Text);
            double bred = double.Parse(textBox2.Text);
                double Area = (längd * bred);
            textBox5.Text = Area.ToString();
            return Area;
          
            

        }
      
    }
}
