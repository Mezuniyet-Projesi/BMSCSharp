namespace Project.HR
{
    partial class NewEmployee
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.departmentTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.locationTb = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DimGray;
            this.comboBox2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.comboBox2.Location = new System.Drawing.Point(381, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 24);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.Text = "Blood Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(381, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "BIRTH DATE";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBox1.Location = new System.Drawing.Point(381, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(385, 258);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(381, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "STARTING DATE";
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.DimGray;
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameTb.Location = new System.Drawing.Point(42, 17);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(276, 25);
            this.nameTb.TabIndex = 46;
            this.nameTb.Text = "Name";
            this.nameTb.Enter += new System.EventHandler(this.nameTb_Enter);
            this.nameTb.Leave += new System.EventHandler(this.nameTb_Leave);
            // 
            // surnameTb
            // 
            this.surnameTb.BackColor = System.Drawing.Color.DimGray;
            this.surnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.surnameTb.Location = new System.Drawing.Point(42, 70);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(276, 25);
            this.surnameTb.TabIndex = 47;
            this.surnameTb.Text = "Surname";
            this.surnameTb.Enter += new System.EventHandler(this.surnameTb_Enter);
            this.surnameTb.Leave += new System.EventHandler(this.surnameTb_Leave);
            // 
            // ageTb
            // 
            this.ageTb.BackColor = System.Drawing.Color.DimGray;
            this.ageTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.ageTb.Location = new System.Drawing.Point(42, 123);
            this.ageTb.Multiline = true;
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(276, 25);
            this.ageTb.TabIndex = 48;
            this.ageTb.Text = "Age";
            this.ageTb.Enter += new System.EventHandler(this.ageTb_Enter);
            this.ageTb.Leave += new System.EventHandler(this.ageTb_Leave);
            // 
            // IdTb
            // 
            this.IdTb.BackColor = System.Drawing.Color.DimGray;
            this.IdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IdTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.IdTb.Location = new System.Drawing.Point(42, 176);
            this.IdTb.Multiline = true;
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(276, 25);
            this.IdTb.TabIndex = 49;
            this.IdTb.Text = "Identification No";
            this.IdTb.Enter += new System.EventHandler(this.IdTb_Enter);
            this.IdTb.Leave += new System.EventHandler(this.IdTb_Leave);
            // 
            // departmentTb
            // 
            this.departmentTb.BackColor = System.Drawing.Color.DimGray;
            this.departmentTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departmentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmentTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.departmentTb.Location = new System.Drawing.Point(42, 229);
            this.departmentTb.Multiline = true;
            this.departmentTb.Name = "departmentTb";
            this.departmentTb.Size = new System.Drawing.Size(276, 25);
            this.departmentTb.TabIndex = 50;
            this.departmentTb.Text = "Department";
            this.departmentTb.Enter += new System.EventHandler(this.departmentTb_Enter);
            this.departmentTb.Leave += new System.EventHandler(this.departmentTb_Leave);
            // 
            // phoneTb
            // 
            this.phoneTb.BackColor = System.Drawing.Color.DimGray;
            this.phoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.phoneTb.Location = new System.Drawing.Point(42, 335);
            this.phoneTb.Multiline = true;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(276, 25);
            this.phoneTb.TabIndex = 51;
            this.phoneTb.Text = "Phone";
            this.phoneTb.Enter += new System.EventHandler(this.phoneTb_Enter);
            this.phoneTb.Leave += new System.EventHandler(this.phoneTb_Leave);
            // 
            // locationTb
            // 
            this.locationTb.BackColor = System.Drawing.Color.DimGray;
            this.locationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.locationTb.Location = new System.Drawing.Point(42, 282);
            this.locationTb.Multiline = true;
            this.locationTb.Name = "locationTb";
            this.locationTb.Size = new System.Drawing.Size(276, 25);
            this.locationTb.TabIndex = 52;
            this.locationTb.Text = "Location";
            this.locationTb.Enter += new System.EventHandler(this.locationTb_Enter);
            this.locationTb.Leave += new System.EventHandler(this.locationTb_Leave);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(42, 438);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(242, 47);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseClick);
            this.saveButton.MouseEnter += new System.EventHandler(this.saveButton_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(843, 616);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.locationTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.departmentTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.TextBox departmentTb;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.TextBox locationTb;
        private System.Windows.Forms.Button saveButton;
    }
}