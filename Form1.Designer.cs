namespace StudentRegistrationApplication
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastnameBox1 = new System.Windows.Forms.TextBox();
            this.Studentres = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.FirstnameBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MiddlenameBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Malebutton = new System.Windows.Forms.RadioButton();
            this.Femalebutton = new System.Windows.Forms.RadioButton();
            this.Dateofbirth = new System.Windows.Forms.Label();
            this.DAYS = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Years = new System.Windows.Forms.ComboBox();
            this.Registerbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentRegistrationApplication.Properties.Resources.asdasd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 624);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LastnameBox1
            // 
            this.LastnameBox1.Location = new System.Drawing.Point(40, 183);
            this.LastnameBox1.Multiline = true;
            this.LastnameBox1.Name = "LastnameBox1";
            this.LastnameBox1.Size = new System.Drawing.Size(337, 28);
            this.LastnameBox1.TabIndex = 1;
            // 
            // Studentres
            // 
            this.Studentres.AutoSize = true;
            this.Studentres.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Studentres.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Studentres.Location = new System.Drawing.Point(42, 65);
            this.Studentres.Name = "Studentres";
            this.Studentres.Size = new System.Drawing.Size(335, 27);
            this.Studentres.TabIndex = 2;
            this.Studentres.Text = "Student Registration Form";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.BackColor = System.Drawing.Color.Transparent;
            this.Lastname.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Lastname.ForeColor = System.Drawing.Color.Black;
            this.Lastname.Location = new System.Drawing.Point(44, 154);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(115, 16);
            this.Lastname.TabIndex = 3;
            this.Lastname.Text = "LAST NAME *";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Firstname.Location = new System.Drawing.Point(44, 232);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(120, 16);
            this.Firstname.TabIndex = 4;
            this.Firstname.Text = "FIRST NAME *";
            // 
            // FirstnameBox2
            // 
            this.FirstnameBox2.Location = new System.Drawing.Point(40, 267);
            this.FirstnameBox2.Multiline = true;
            this.FirstnameBox2.Name = "FirstnameBox2";
            this.FirstnameBox2.Size = new System.Drawing.Size(337, 28);
            this.FirstnameBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "MIDDLE NAME *";
            // 
            // MiddlenameBox3
            // 
            this.MiddlenameBox3.Location = new System.Drawing.Point(40, 348);
            this.MiddlenameBox3.Multiline = true;
            this.MiddlenameBox3.Name = "MiddlenameBox3";
            this.MiddlenameBox3.Size = new System.Drawing.Size(337, 28);
            this.MiddlenameBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "GENDER *";
            // 
            // Malebutton
            // 
            this.Malebutton.AutoSize = true;
            this.Malebutton.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Malebutton.Location = new System.Drawing.Point(151, 393);
            this.Malebutton.Name = "Malebutton";
            this.Malebutton.Size = new System.Drawing.Size(69, 20);
            this.Malebutton.TabIndex = 9;
            this.Malebutton.TabStop = true;
            this.Malebutton.Text = "MALE";
            this.Malebutton.UseVisualStyleBackColor = true;
            // 
            // Femalebutton
            // 
            this.Femalebutton.AutoSize = true;
            this.Femalebutton.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Femalebutton.Location = new System.Drawing.Point(236, 394);
            this.Femalebutton.Name = "Femalebutton";
            this.Femalebutton.Size = new System.Drawing.Size(89, 20);
            this.Femalebutton.TabIndex = 10;
            this.Femalebutton.TabStop = true;
            this.Femalebutton.Text = "FEMALE";
            this.Femalebutton.UseVisualStyleBackColor = true;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.AutoSize = true;
            this.Dateofbirth.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Dateofbirth.Location = new System.Drawing.Point(44, 440);
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.Size = new System.Drawing.Size(146, 16);
            this.Dateofbirth.TabIndex = 11;
            this.Dateofbirth.Text = "DATE OF BIRTH *";
            // 
            // DAYS
            // 
            this.DAYS.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.DAYS.FormattingEnabled = true;
            this.DAYS.Location = new System.Drawing.Point(47, 471);
            this.DAYS.Name = "DAYS";
            this.DAYS.Size = new System.Drawing.Size(100, 24);
            this.DAYS.TabIndex = 12;
            this.DAYS.Text = "-DAY-";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(162, 471);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(100, 24);
            this.Month.TabIndex = 13;
            this.Month.Text = "-MONTH-";
            // 
            // Years
            // 
            this.Years.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold);
            this.Years.FormattingEnabled = true;
            this.Years.Location = new System.Drawing.Point(277, 471);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(100, 24);
            this.Years.TabIndex = 14;
            this.Years.Text = "-YEAR-";
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.Crimson;
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbutton.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.Location = new System.Drawing.Point(117, 522);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(170, 34);
            this.Registerbutton.TabIndex = 15;
            this.Registerbutton.Text = "REGISTER";
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 623);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.DAYS);
            this.Controls.Add(this.Dateofbirth);
            this.Controls.Add(this.Femalebutton);
            this.Controls.Add(this.Malebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MiddlenameBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstnameBox2);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Studentres);
            this.Controls.Add(this.LastnameBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LastnameBox1;
        private System.Windows.Forms.Label Studentres;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.TextBox FirstnameBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MiddlenameBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Malebutton;
        private System.Windows.Forms.RadioButton Femalebutton;
        private System.Windows.Forms.Label Dateofbirth;
        private System.Windows.Forms.ComboBox DAYS;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Years;
        private System.Windows.Forms.Button Registerbutton;
    }
}

