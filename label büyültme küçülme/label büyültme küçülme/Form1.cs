using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int i = 8;
        int a = 10;
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            label1.Font = new Font("",i);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("", i);
            i--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            label2.Font = new Font("", a);
            a++;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALLAHIN İSMİ ASLA KÜÇÜLMEZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

       
        }
    }

