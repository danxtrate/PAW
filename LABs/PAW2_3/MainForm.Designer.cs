namespace PAW2_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gbNewParticipant = new System.Windows.Forms.GroupBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbNewParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewParticipant
            // 
            this.gbNewParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewParticipant.Controls.Add(this.btnAddParticipant);
            this.gbNewParticipant.Controls.Add(this.tbFirstName);
            this.gbNewParticipant.Controls.Add(this.tbLastName);
            this.gbNewParticipant.Controls.Add(this.dtpBirthDay);
            this.gbNewParticipant.Controls.Add(this.lbBirthDate);
            this.gbNewParticipant.Controls.Add(this.lbFirstName);
            this.gbNewParticipant.Controls.Add(this.lbLastName);
            this.gbNewParticipant.Location = new System.Drawing.Point(12, 12);
            this.gbNewParticipant.Name = "gbNewParticipant";
            this.gbNewParticipant.Size = new System.Drawing.Size(776, 164);
            this.gbNewParticipant.TabIndex = 0;
            this.gbNewParticipant.TabStop = false;
            this.gbNewParticipant.Text = "New Participant";
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddParticipant.Location = new System.Drawing.Point(593, 128);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(147, 23);
            this.btnAddParticipant.TabIndex = 6;
            this.btnAddParticipant.Text = "Add Participant";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(86, 67);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(86, 25);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(86, 128);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDay.TabIndex = 3;
            this.dtpBirthDay.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthDay_Validating);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(8, 135);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lbBirthDate.TabIndex = 2;
            this.lbBirthDate.Text = "Birth Date";
            this.lbBirthDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(7, 67);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(7, 33);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Last Name";
            this.lbLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // lvParticipants
            // 
            this.lvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvParticipants.GridLines = true;
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(12, 182);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(776, 206);
            this.lvParticipants.TabIndex = 1;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LastName";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BirthDay";
            this.columnHeader3.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.gbNewParticipant);
            this.Name = "MainForm";
            this.Text = "Admitere";
            this.gbNewParticipant.ResumeLayout(false);
            this.gbNewParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewParticipant;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ListView lvParticipants;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

