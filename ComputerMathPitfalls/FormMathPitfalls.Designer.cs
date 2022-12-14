namespace ComputerMathPitfalls
{
    partial class FormMathPitfalls
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
            this.BtnProblem1 = new System.Windows.Forms.Button();
            this.BtnProblem2 = new System.Windows.Forms.Button();
            this.BtnProblem3 = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnProblem4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(66, 52);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(164, 60);
            this.BtnProblem1.TabIndex = 0;
            this.BtnProblem1.Text = "Problem 1";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.BtnProblem1_Click);
            // 
            // BtnProblem2
            // 
            this.BtnProblem2.Location = new System.Drawing.Point(67, 145);
            this.BtnProblem2.Name = "BtnProblem2";
            this.BtnProblem2.Size = new System.Drawing.Size(163, 59);
            this.BtnProblem2.TabIndex = 1;
            this.BtnProblem2.Text = "Problem 2";
            this.BtnProblem2.UseVisualStyleBackColor = true;
            this.BtnProblem2.Click += new System.EventHandler(this.BtnProblem2_Click);
            // 
            // BtnProblem3
            // 
            this.BtnProblem3.Location = new System.Drawing.Point(66, 239);
            this.BtnProblem3.Name = "BtnProblem3";
            this.BtnProblem3.Size = new System.Drawing.Size(162, 64);
            this.BtnProblem3.TabIndex = 2;
            this.BtnProblem3.Text = "Problem 3";
            this.BtnProblem3.UseVisualStyleBackColor = true;
            this.BtnProblem3.Click += new System.EventHandler(this.BtnProblem3_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(307, 52);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(415, 352);
            this.TxtResult.TabIndex = 3;
            // 
            // BtnProblem4
            // 
            this.BtnProblem4.Location = new System.Drawing.Point(66, 343);
            this.BtnProblem4.Name = "BtnProblem4";
            this.BtnProblem4.Size = new System.Drawing.Size(161, 61);
            this.BtnProblem4.TabIndex = 4;
            this.BtnProblem4.Text = "Problem 4";
            this.BtnProblem4.UseVisualStyleBackColor = true;
            this.BtnProblem4.Click += new System.EventHandler(this.BtnProblem4_Click);
            // 
            // FormMathPitfalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProblem4);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnProblem3);
            this.Controls.Add(this.BtnProblem2);
            this.Controls.Add(this.BtnProblem1);
            this.Name = "FormMathPitfalls";
            this.Text = "Math Pitfalls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem1;
        private System.Windows.Forms.Button BtnProblem2;
        private System.Windows.Forms.Button BtnProblem3;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnProblem4;
    }
}

