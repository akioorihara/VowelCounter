using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            int count_v = 0;
            int count_y = 0;

            string words = textBox1.Text;
            for (int i = 0; i < words.Length; i++)
            {
                //string c = words[i].ToString().ToLower(); //Not sure why above line does need ToString() 
                char c = char.ToLower(words[i]);  
                if ("aiueo".Contains(c))
                {
                    count_v += 1;     
                }
                if (checkBox1.Checked) {
                    if("y".Contains(c))
                        count_y += 1;
                }

            }
            if (count_v > 0)
                MessageBox.Show("You entered : " + words + "\n" + "Your total vowel is " + count_v);
            if (count_y > 0)
                MessageBox.Show("Y found found : " + count_y);
            else
            {
                MessageBox.Show("No Vowels Found");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
