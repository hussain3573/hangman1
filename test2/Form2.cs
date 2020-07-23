using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string path = Environment.CurrentDirectory + "/" + "ll.txt";
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(path))

            {

                sw.WriteLine("gigbubuo");




            }
        }

    }
}