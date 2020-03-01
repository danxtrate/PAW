namespace PAW2_1
{
    partial class SumatorSiAtat
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
            this.btnAdunare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTermen1 = new System.Windows.Forms.TextBox();
            this.tb_Termen2 = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdunare
            // 
            this.btnAdunare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdunare.Location = new System.Drawing.Point(68, 153);
            this.btnAdunare.Name = "btnAdunare";
            this.btnAdunare.Size = new System.Drawing.Size(101, 20);
            this.btnAdunare.TabIndex = 0;
            this.btnAdunare.Text = "=";
            this.btnAdunare.UseVisualStyleBackColor = false;
            this.btnAdunare.Click += new System.EventHandler(this.btnAdunare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTermen1
            // 
            this.tbTermen1.Location = new System.Drawing.Point(68, 46);
            this.tbTermen1.Name = "tbTermen1";
            this.tbTermen1.Size = new System.Drawing.Size(100, 20);
            this.tbTermen1.TabIndex = 2;
            this.tbTermen1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTermen1_KeyDown);
            this.tbTermen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTermen1_KeyPress);
            // 
            // tb_Termen2
            // 
            this.tb_Termen2.Location = new System.Drawing.Point(68, 115);
            this.tb_Termen2.Name = "tb_Termen2";
            this.tb_Termen2.Size = new System.Drawing.Size(100, 20);
            this.tb_Termen2.TabIndex = 3;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(68, 194);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.ReadOnly = true;
            this.tbRezultat.Size = new System.Drawing.Size(100, 20);
            this.tbRezultat.TabIndex = 4;
            // 
            // SumatorSiAtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 295);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tb_Termen2);
            this.Controls.Add(this.tbTermen1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdunare);
            this.Name = "SumatorSiAtat";
            this.Text = "SumatorSiAtat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdunare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTermen1;
        private System.Windows.Forms.TextBox tb_Termen2;
        private System.Windows.Forms.TextBox tbRezultat;
    }
}

