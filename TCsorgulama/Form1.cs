using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UInt64[] bas = new UInt64[12];
            UInt64 tcNo,b1,b2,b3,bol=1,kontrol1,kontrol2;
            tcNo = Convert.ToUInt64(textBox1.Text);
            label1.Text = tcNo.ToString();

            for (int i = 11; i >= 1; i--)
            {
                bas[i] = tcNo/bol % 10;
                listBox1.Items.Add(bas[i]);
                bol = bol * 10;
            }
            kontrol1=(bas[1]+bas[3]+bas[5]+bas[7]+bas[9])*7-(bas[2]+bas[4]+bas[6]+bas[8]);
            kontrol1 = kontrol1 % 10;
            label2.Text = kontrol1.ToString();
            kontrol2 = (bas[1] + bas[2] + bas[3] + bas[4] + bas[5] + bas[6]+bas[7] + bas[8] + bas[9] + bas[10]);
            kontrol2= kontrol2 % 10;
            label3.Text=kontrol2.ToString();

            if (kontrol1 == bas[10] &&  kontrol2==bas[11])
            {
                MessageBox.Show("dogru");
            }
            else
            {
                MessageBox.Show("yanlış");
            }
            /*
            b1 = tcNo / 10;
            b1 = b1 % 10;
            listBox1.Items.Add(b1);

            b1 = tcNo / 100 % 10;
            listBox1.Items.Add(b1);
             */ 
        }
    }
}
