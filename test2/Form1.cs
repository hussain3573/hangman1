using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace test2
{
    public partial class Form1 : Form
    {

        private Bitmap[] hangImges = { test2.Properties.Resources.hang1 ,test2.Properties.Resources.hang2 ,
            test2.Properties.Resources.hang3 ,test2.Properties.Resources.hang4 ,test2.Properties.Resources.hang5
                , test2.Properties.Resources.hang6
        ,test2.Properties.Resources.hang7};
        private int wrong = 0;
        private string[] words;
        private string current = "";
        private string copycurrent = "";
        



        public Form1()
        {
            InitializeComponent();
        }
        private void loadwords()
        {
            char[] del = { ',' };
           string[] readText = File.ReadAllLines("coo.txt");
            
           

            words = new string[readText.Length];
            int index = 0;

            foreach (string s in readText)
             {
                 string[] line = s.Split(del);
                words[index++] = line[1];

             }
           
        }

        private void setup()
        {
            wrong = 0;
            b1.Image = hangImges[wrong];
            int gusIndex = (new Random()).Next(words.Length);
            current = words[gusIndex];

            copycurrent = "";

            for (int index=0 ; index < current.Length ; index++ )

            {

                copycurrent += "_";

            }
            dis();
        }
        private void dis()
        {
            l.Text += "";
            for (int index = 0;index < copycurrent.Length ; index++)
            {
                l.Text += copycurrent.Substring(index, 1);
                l.Text += " ";

            }

        }
        private void updateCopy(char guess)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

           Button choice = sender as Button;
            choice.Visible = false;
            if (current.Contains(choice.Text))
            {
                char[] temp = copycurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guess = choice.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guess)
                    {
                        temp[index]= guess;
                    }
                }
                    copycurrent = new string(temp);
                  dis();
                }
            else
                {

                    wrong++;
                }


                if (wrong < 7)
                {
                    b1.Image = hangImges[wrong];
                }
                else
                {
                    lab.Text = "you lose!";
                   // MessageBox.Show("YOU LOSE!!!");
                }
                if (copycurrent.Equals(current))
                {
                    lab.Text = "you Win!";
                }
            }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadwords();
            setup();
        }

        private void l_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
          

        }

        private void button25_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
