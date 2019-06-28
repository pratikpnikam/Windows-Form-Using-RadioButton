namespace RadioCalCulator
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
            this.radadd = new System.Windows.Forms.RadioButton();
            this.radsub = new System.Windows.Forms.RadioButton();
            this.radmul = new System.Windows.Forms.RadioButton();
            this.raddiv = new System.Windows.Forms.RadioButton();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radadd
            // 
            this.radadd.AutoSize = true;
            this.radadd.Location = new System.Drawing.Point(185, 186);
            this.radadd.Name = "radadd";
            this.radadd.Size = new System.Drawing.Size(58, 21);
            this.radadd.TabIndex = 0;
            this.radadd.TabStop = true;
            this.radadd.Text = "ADD";
            this.radadd.UseVisualStyleBackColor = true;
            this.radadd.CheckedChanged += new System.EventHandler(this.radadd_CheckedChanged);
            // 
            // radsub
            // 
            this.radsub.AutoSize = true;
            this.radsub.Location = new System.Drawing.Point(185, 261);
            this.radsub.Name = "radsub";
            this.radsub.Size = new System.Drawing.Size(103, 21);
            this.radsub.TabIndex = 1;
            this.radsub.TabStop = true;
            this.radsub.Text = "SUBTRACT";
            this.radsub.UseVisualStyleBackColor = true;
            this.radsub.CheckedChanged += new System.EventHandler(this.radsub_CheckedChanged);
            // 
            // radmul
            // 
            this.radmul.AutoSize = true;
            this.radmul.Location = new System.Drawing.Point(185, 341);
            this.radmul.Name = "radmul";
            this.radmul.Size = new System.Drawing.Size(96, 21);
            this.radmul.TabIndex = 2;
            this.radmul.TabStop = true;
            this.radmul.Text = "MULTIPLY";
            this.radmul.UseVisualStyleBackColor = true;
            this.radmul.CheckedChanged += new System.EventHandler(this.radmul_CheckedChanged);
            // 
            // raddiv
            // 
            this.raddiv.AutoSize = true;
            this.raddiv.Location = new System.Drawing.Point(185, 421);
            this.raddiv.Name = "raddiv";
            this.raddiv.Size = new System.Drawing.Size(73, 21);
            this.raddiv.TabIndex = 3;
            this.raddiv.TabStop = true;
            this.raddiv.Text = "DIVIDE";
            this.raddiv.UseVisualStyleBackColor = true;
            this.raddiv.CheckedChanged += new System.EventHandler(this.raddiv_CheckedChanged);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(355, 261);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 22);
            this.txtInput1.TabIndex = 4;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(358, 340);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 22);
            this.txtInput2.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(518, 299);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.raddiv);
            this.Controls.Add(this.radmul);
            this.Controls.Add(this.radsub);
            this.Controls.Add(this.radadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radadd;
        private System.Windows.Forms.RadioButton radsub;
        private System.Windows.Forms.RadioButton radmul;
        private System.Windows.Forms.RadioButton raddiv;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

