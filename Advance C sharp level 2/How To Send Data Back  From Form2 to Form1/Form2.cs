using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_To_Send_Data_Back__From_Form2_to_Form1
{   
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object sender, string personID);
        public event DataBackEventHandler DateBack;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            DateBack?.Invoke(this, textBox1.Text);
            this.Close();
        }


    }
}
