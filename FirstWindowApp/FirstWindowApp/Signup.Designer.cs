namespace FirstWindowApp
{
    partial class Signup
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
            txtName = new TextBox();
            name = new Label();
            dobPicker = new DateTimePicker();
            dob = new Label();
            gender = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            fname = new Label();
            mname = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            age = new Label();
            contact = new Label();
            txtContact = new TextBox();
            level = new Label();
            txtMname = new TextBox();
            faculty = new Label();
            txtFname = new TextBox();
            heading = new Button();
            btnSignup = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(472, 181);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(357, 30);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(361, 184);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            name.Click += label1_Click;
            // 
            // dobPicker
            // 
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.Location = new Point(472, 229);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(357, 27);
            dobPicker.TabIndex = 2;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Location = new Point(361, 229);
            dob.Name = "dob";
            dob.Size = new Size(38, 20);
            dob.TabIndex = 3;
            dob.Text = "Dob\r\n";
            dob.Click += label2_Click;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(361, 276);
            gender.Name = "gender";
            gender.Size = new Size(57, 20);
            gender.TabIndex = 4;
            gender.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(472, 276);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(740, 274);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Other";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(592, 274);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(78, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Female";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Location = new Point(361, 541);
            fname.Name = "fname";
            fname.Size = new Size(102, 20);
            fname.TabIndex = 8;
            fname.Text = "Father's Name";
            fname.Click += label4_Click;
            // 
            // mname
            // 
            mname.AutoSize = true;
            mname.Location = new Point(363, 600);
            mname.Name = "mname";
            mname.Size = new Size(110, 20);
            mname.TabIndex = 10;
            mname.Text = "Mother's Name";
            mname.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 401);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 12;
            label6.Text = "Address\r\n";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(470, 401);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(359, 116);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(363, 315);
            age.Name = "age";
            age.Size = new Size(36, 20);
            age.TabIndex = 14;
            age.Text = "Age";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(361, 357);
            contact.Name = "contact";
            contact.Size = new Size(60, 20);
            contact.TabIndex = 16;
            contact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(472, 350);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(357, 27);
            txtContact.TabIndex = 17;
            // 
            // level
            // 
            level.AutoSize = true;
            level.Location = new Point(361, 647);
            level.Name = "level";
            level.Size = new Size(43, 20);
            level.TabIndex = 18;
            level.Text = "Level";
            level.Click += label9_Click;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(472, 597);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(357, 27);
            txtMname.TabIndex = 19;
            // 
            // faculty
            // 
            faculty.AutoSize = true;
            faculty.Location = new Point(361, 701);
            faculty.Name = "faculty";
            faculty.Size = new Size(54, 20);
            faculty.TabIndex = 20;
            faculty.Text = "Faculty";
            faculty.Click += label10_Click;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(472, 534);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(357, 27);
            txtFname.TabIndex = 21;
            txtFname.TextChanged += textBox7_TextChanged;
            // 
            // heading
            // 
            heading.Image = Properties.Resources.download;
            heading.Location = new Point(361, 12);
            heading.Name = "heading";
            heading.Size = new Size(468, 143);
            heading.TabIndex = 23;
            heading.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = SystemColors.HotTrack;
            btnSignup.Location = new Point(534, 767);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(170, 51);
            btnSignup.TabIndex = 25;
            btnSignup.Text = "SignUp";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(476, 701);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 24);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "BCA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(566, 701);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(57, 24);
            checkBox2.TabIndex = 27;
            checkBox2.Text = "BIM";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(666, 701);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 24);
            checkBox3.TabIndex = 28;
            checkBox3.Text = "BBS";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+2", "Bachelor", "Masters" });
            comboBox1.Location = new Point(476, 647);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(353, 28);
            comboBox1.TabIndex = 29;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 909);
            Controls.Add(comboBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnSignup);
            Controls.Add(heading);
            Controls.Add(txtFname);
            Controls.Add(faculty);
            Controls.Add(txtMname);
            Controls.Add(level);
            Controls.Add(txtContact);
            Controls.Add(contact);
            Controls.Add(age);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(mname);
            Controls.Add(fname);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(gender);
            Controls.Add(dob);
            Controls.Add(dobPicker);
            Controls.Add(name);
            Controls.Add(txtName);
            Name = "Signup";
            Text = "Form2";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label name;
        private DateTimePicker dobPicker;
        private Label dob;
        private Label gender;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label fname;
        private Label mname;
        private Label label6;
        private TextBox textBox4;
        private Label age;
        private Label contact;
        private TextBox txtContact;
        private Label level;
        private TextBox txtMname;
        private Label faculty;
        private TextBox txtFname;
        private Label label11;
        private ImageList imageList1;
        private Button heading;
        private Button btnSignup;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBox1;
    }
}