namespace CsevegesGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.KezdemenyezoCMB = new System.Windows.Forms.ComboBox();
            this.FogadoCMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kezdeményező";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fogadó (partner)";
            // 
            // RTB
            // 
            this.RTB.Location = new System.Drawing.Point(28, 198);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(266, 293);
            this.RTB.TabIndex = 2;
            this.RTB.Text = "";
            // 
            // KezdemenyezoCMB
            // 
            this.KezdemenyezoCMB.FormattingEnabled = true;
            this.KezdemenyezoCMB.Location = new System.Drawing.Point(155, 56);
            this.KezdemenyezoCMB.Name = "KezdemenyezoCMB";
            this.KezdemenyezoCMB.Size = new System.Drawing.Size(121, 23);
            this.KezdemenyezoCMB.TabIndex = 3;
            this.KezdemenyezoCMB.SelectedIndexChanged += new System.EventHandler(this.KezdemenyezoCMB_SelectedIndexChanged);
            // 
            // FogadoCMB
            // 
            this.FogadoCMB.FormattingEnabled = true;
            this.FogadoCMB.Location = new System.Drawing.Point(155, 94);
            this.FogadoCMB.Name = "FogadoCMB";
            this.FogadoCMB.Size = new System.Drawing.Size(121, 23);
            this.FogadoCMB.TabIndex = 4;
            this.FogadoCMB.SelectedIndexChanged += new System.EventHandler(this.FogadoCMB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Csevegések";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FogadoCMB);
            this.Controls.Add(this.KezdemenyezoCMB);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Csevegés GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox RTB;
        private ComboBox KezdemenyezoCMB;
        private ComboBox FogadoCMB;
        private Label label3;
    }
}