using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CL1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader textFile;
        string fileName = @"..";
        private void button1_Click(object sender, EventArgs e)
        {
            textFile = new StreamReader(fileName);
            listBox1.Items.Clear();
            while (true)
            {
                string s = textFile.ReadLine();
                if (s = null) break;
                string[] arr = s.Split(' ');
                double x = double.Parse(arr[1]);
                double y = double.Parse(arr[2]);
                Dimensions fig = null;
                if (arr[0] == "Эллипс")
                    fig = new Ellipse(x, y);
                if (arr[0] == "Треугольник")
                    fig = new Triangle(x, y);
                string line = fig.description();
                if (radioButton1.Checked == true & arr[0] == "Треугольник")
                    listBox1.Items.Add(line);
                if (radioButton2.Checked == true & arr[0] == "Эллипс")
                    listBox1.Items.Add(line);
                if (radioButton3.Checked == true)
                    listBox1.Items.Add(line);
            }
        }
    }
}
