using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucCalcWithEvent1_OnCalculationComplete(int obj)
        {
            MessageBox.Show("The Result IS:" + obj.ToString());
        }
    }
}
