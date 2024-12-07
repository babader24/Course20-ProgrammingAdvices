using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Controls_Expose_Property
{
    public partial class ucSimpleCalc : UserControl
    {
        public ucSimpleCalc()
        {
            InitializeComponent();
        }

        public float GetResult
        {
            get { return (float)Convert.ToDouble(lResult.Text); }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lResult.Text = "";
            lResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
