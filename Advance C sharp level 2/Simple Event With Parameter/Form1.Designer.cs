namespace Simple_Event_With_Parameter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucCalcWithEvent1 = new Simple_Event_With_Parameter.ucCalcWithEvent();
            this.SuspendLayout();
            // 
            // ucCalcWithEvent1
            // 
            this.ucCalcWithEvent1.Location = new System.Drawing.Point(39, 67);
            this.ucCalcWithEvent1.Name = "ucCalcWithEvent1";
            this.ucCalcWithEvent1.Size = new System.Drawing.Size(593, 133);
            this.ucCalcWithEvent1.TabIndex = 0;
            this.ucCalcWithEvent1.OnCalculationComplete += new System.Action<int>(this.ucCalcWithEvent1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucCalcWithEvent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucCalcWithEvent ucCalcWithEvent1;
    }
}

