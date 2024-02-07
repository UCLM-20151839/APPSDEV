namespace Learnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fname = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cvstat = new ComboBox();
            label7 = new Label();
            volley = new CheckBox();
            badminton = new CheckBox();
            basket = new CheckBox();
            label6 = new Label();
            Date = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            female = new RadioButton();
            male = new RadioButton();
            mname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lname = new TextBox();
            groupBox2 = new GroupBox();
            Display = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Location = new Point(136, 51);
            fname.Name = "fname";
            fname.Size = new Size(339, 35);
            fname.TabIndex = 0;
            fname.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 1;
            label1.Text = "Firstname";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cvstat);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(volley);
            groupBox1.Controls.Add(badminton);
            groupBox1.Controls.Add(basket);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Date);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Location = new Point(11, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 407);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cvstat
            // 
            cvstat.FormattingEnabled = true;
            cvstat.Items.AddRange(new object[] { "Married", "Single" });
            cvstat.Location = new Point(125, 274);
            cvstat.Name = "cvstat";
            cvstat.Size = new Size(212, 38);
            cvstat.TabIndex = 10;
            cvstat.Text = "<<Select One>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 274);
            label7.Name = "label7";
            label7.Size = new Size(113, 30);
            label7.TabIndex = 9;
            label7.Text = "Civil Status";
            // 
            // volley
            // 
            volley.AutoSize = true;
            volley.Location = new Point(150, 181);
            volley.Name = "volley";
            volley.Size = new Size(127, 34);
            volley.TabIndex = 8;
            volley.Text = "VolleyBall";
            volley.UseVisualStyleBackColor = true;
            // 
            // badminton
            // 
            badminton.AutoSize = true;
            badminton.Location = new Point(7, 224);
            badminton.Name = "badminton";
            badminton.Size = new Size(140, 34);
            badminton.TabIndex = 7;
            badminton.Text = "Badminton";
            badminton.UseVisualStyleBackColor = true;
            // 
            // basket
            // 
            basket.AutoSize = true;
            basket.Location = new Point(7, 181);
            basket.Name = "basket";
            basket.Size = new Size(132, 34);
            basket.TabIndex = 6;
            basket.Text = "Basketball";
            basket.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 148);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 5;
            label6.Text = "Sports";
            // 
            // Date
            // 
            Date.Location = new Point(124, 99);
            Date.Name = "Date";
            Date.Size = new Size(367, 35);
            Date.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 99);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 3;
            label5.Text = "Birthdate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 51);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 2;
            label4.Text = "Gender";
            label4.Click += label4_Click;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(190, 51);
            female.Name = "female";
            female.Size = new Size(104, 34);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(100, 51);
            male.Name = "male";
            male.Size = new Size(84, 34);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // mname
            // 
            mname.Location = new Point(135, 114);
            mname.Name = "mname";
            mname.Size = new Size(339, 35);
            mname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 114);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 4;
            label2.Text = "Middlename";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 168);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 5;
            label3.Text = "Lastname";
            // 
            // lname
            // 
            lname.Location = new Point(136, 168);
            lname.Name = "lname";
            lname.Size = new Size(339, 35);
            lname.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lname);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mname);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(fname);
            groupBox2.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 255);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // Display
            // 
            Display.Location = new Point(585, 243);
            Display.Name = "Display";
            Display.Size = new Size(263, 43);
            Display.TabIndex = 8;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Displayinfo;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 775);
            Controls.Add(pictureBox1);
            Controls.Add(Display);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox fname;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton female;
        private RadioButton male;
        private TextBox mname;
        private Label label2;
        private Label label3;
        private TextBox lname;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private CheckBox volley;
        private CheckBox badminton;
        private CheckBox basket;
        private Label label6;
        private DateTimePicker Date;
        private Button Display;
        private PictureBox pictureBox1;
        private Label label7;
        private ComboBox cvstat;
    }
}
