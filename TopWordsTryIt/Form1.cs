using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopWordsTryIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string[] words = new string[10];

            TopWords.ServiceClient top = new TopWords.ServiceClient();

            words = top.GetWords(url);

            string disp = "";

            for(int i = 0; i < words.Length; i++)
            {
                disp += words[i];
                disp += "\n";
            }

            richTextBox1.Text = disp;
        }
    }
}
