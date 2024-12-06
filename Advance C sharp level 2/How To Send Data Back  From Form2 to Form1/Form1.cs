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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.DateBack += GetDataBAckFronmForm2;
            frm.ShowDialog();
        }

        private void GetDataBAckFronmForm2(object sender, string data)
        {
            label1.Text = data;
        }
    }
}
