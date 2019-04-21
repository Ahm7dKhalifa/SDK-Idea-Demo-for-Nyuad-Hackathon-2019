using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDK_of_PythonOpenCV_for_CsharpDevelopers.OpencvSDK;

namespace SDK_of_PythonOpenCV_for_CsharpDevelopers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.Create SDK
            OpencvSdk OpencvSdk = new OpencvSdk(@"C:\Users\Options\Anaconda3\python.exe");

            //2.Apply Edge Detection in Python-Opencv Algorithms
            OpencvSdk.EdgeDetection(@""+ textBox1.Text);
        }
    }
}
