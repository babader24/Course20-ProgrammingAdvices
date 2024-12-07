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
    public partial class ucCalcWithEvent : UserControl
    {

        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int ID)
        {
            Action<int> handler = OnCalculationComplete;

            if (handler != null)
            {
                handler(ID);
            }
        }

        public ucCalcWithEvent()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lResult.Text = "";
            lResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();

            textBox1.Text = "";
            textBox2.Text = "";

            if (OnCalculationComplete != null)
                CalculationComplete(int.Parse(lResult.Text));

       
        }
    }
}
