using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_To_Send_Data_From_Form1_to_Form2
{
    public partial class Form2 : Form
    {
        //private int _PersonID;
        //private string _PersonName;

        public Form2(int personID)
        {
            InitializeComponent();
            label1.Text = personID.ToString();
           
        }

        public Form2(string PersonName)
        {
            InitializeComponent();
            label1.Text = PersonName;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = _PersonName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
