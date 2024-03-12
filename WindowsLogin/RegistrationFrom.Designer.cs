
namespace Final_Project
{
    partial class RegistrationFrom
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
            components = new System.ComponentModel.Container();
            Logout = new LinkLabel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxRno = new ComboBox();
            Clear = new Button();
            Delete = new Button();
            Update = new Button();
            Register = new Button();
            groupBox4 = new GroupBox();
            textBoxCnumber = new MaskedTextBox();
            textBoxPname = new MaskedTextBox();
            textBoxNIC = new MaskedTextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            textBoxAddress = new TextBox();
            textBoxHphone = new MaskedTextBox();
            textBoxMphone = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxEmail = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            label6 = new Label();
            textBoxdob = new DateTimePicker();
            label5 = new Label();
            textBoxLname = new MaskedTextBox();
            label4 = new Label();
            textBoxFname = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            bindingSource1 = new BindingSource(components);
            Exit = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Location = new Point(30, 9);
            Logout.Name = "Logout";
            Logout.Size = new Size(45, 15);
            Logout.TabIndex = 0;
            Logout.TabStop = true;
            Logout.Text = "Logout";
            Logout.LinkClicked += Logout_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 26);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 1;
            label1.Text = "Skills International";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRno);
            groupBox1.Controls.Add(Clear);
            groupBox1.Controls.Add(Delete);
            groupBox1.Controls.Add(Update);
            groupBox1.Controls.Add(Register);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 692);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxRno
            // 
            textBoxRno.FormattingEnabled = true;
            textBoxRno.Location = new Point(93, 32);
            textBoxRno.Name = "textBoxRno";
            textBoxRno.Size = new Size(142, 23);
            textBoxRno.TabIndex = 20;
            textBoxRno.SelectedIndexChanged += textBoxRno_SelectedIndexChanged;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 10F);
            Clear.Location = new Point(480, 648);
            Clear.Name = "Clear";
            Clear.Size = new Size(73, 30);
            Clear.TabIndex = 19;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += clear_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 10F);
            Delete.Location = new Point(563, 648);
            Delete.Name = "Delete";
            Delete.Size = new Size(73, 30);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += delete_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 10F);
            Update.Location = new Point(107, 647);
            Update.Name = "Update";
            Update.Size = new Size(73, 30);
            Update.TabIndex = 17;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += update_Click;
            // 
            // Register
            // 
            Register.Font = new Font("Segoe UI", 10F);
            Register.Location = new Point(28, 647);
            Register.Name = "Register";
            Register.Size = new Size(73, 30);
            Register.TabIndex = 16;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += register_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxCnumber);
            groupBox4.Controls.Add(textBoxPname);
            groupBox4.Controls.Add(textBoxNIC);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(29, 475);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(607, 156);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // textBoxCnumber
            // 
            textBoxCnumber.Location = new Point(123, 104);
            textBoxCnumber.Name = "textBoxCnumber";
            textBoxCnumber.Size = new Size(162, 23);
            textBoxCnumber.TabIndex = 15;
            // 
            // textBoxPname
            // 
            textBoxPname.Location = new Point(123, 27);
            textBoxPname.Name = "textBoxPname";
            textBoxPname.Size = new Size(463, 23);
            textBoxPname.TabIndex = 14;
            // 
            // textBoxNIC
            // 
            textBoxNIC.Location = new Point(123, 67);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(162, 23);
            textBoxNIC.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 112);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 7;
            label12.Text = "Contact Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 75);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 5;
            label13.Text = "NIC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 31);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 3;
            label14.Text = "Parent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxAddress);
            groupBox3.Controls.Add(textBoxHphone);
            groupBox3.Controls.Add(textBoxMphone);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBoxEmail);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(29, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(607, 186);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(123, 31);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(463, 70);
            textBoxAddress.TabIndex = 14;
            // 
            // textBoxHphone
            // 
            textBoxHphone.Location = new Point(422, 149);
            textBoxHphone.Name = "textBoxHphone";
            textBoxHphone.Size = new Size(164, 23);
            textBoxHphone.TabIndex = 13;
            // 
            // textBoxMphone
            // 
            textBoxMphone.Location = new Point(123, 146);
            textBoxMphone.Name = "textBoxMphone";
            textBoxMphone.Size = new Size(162, 23);
            textBoxMphone.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 152);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 9;
            label7.Text = "Home Phone";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 149);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 7;
            label8.Text = "Mobile Phone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(123, 112);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(463, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 118);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 5;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 31);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 3;
            label10.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonFemale);
            groupBox2.Controls.Add(radioButtonMale);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxdob);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxLname);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxFname);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(29, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 186);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(195, 146);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 11;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(123, 147);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 10;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 148);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            // 
            // textBoxdob
            // 
            textBoxdob.Location = new Point(123, 102);
            textBoxdob.Name = "textBoxdob";
            textBoxdob.Size = new Size(199, 23);
            textBoxdob.TabIndex = 8;
            textBoxdob.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 108);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Date of Birth";
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(123, 65);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(463, 23);
            textBoxLname.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 68);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            label4.Click += label4_Click;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(123, 26);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(463, 23);
            textBoxFname.TabIndex = 4;
            textBoxFname.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 31);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Reg No";
            label2.Click += label2_Click;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(30, 805);
            label11.Name = "label11";
            label11.Size = new Size(666, 3);
            label11.TabIndex = 15;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Location = new Point(670, 786);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 15);
            Exit.TabIndex = 16;
            Exit.TabStop = true;
            Exit.Text = "Exit";
            Exit.LinkClicked += exit_Clicked;
            // 
            // RegistrationFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(721, 553);
            Controls.Add(Exit);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Logout);
            Name = "RegistrationFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration - Skills International";
            Load += HomePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Console.WriteLine("HomePage_Load has been implemented.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label2_Click has been implemented.");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Console.WriteLine("maskedTextBox1_MaskInputRejected has been implemented.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label4_Click has been implemented.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("dateTimePicker1_ValueChanged has been implemented.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("groupBox1_Enter has been implemented.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label7_Click has been implemented.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("radioButton1_CheckedChanged has been implemented.");
        }

        #endregion

        private LinkLabel Logout;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private MaskedTextBox textBoxFname;
        private MaskedTextBox textBoxLname;
        private Label label4;
        private DateTimePicker textBoxdob;
        private Label label5;
        private RadioButton radioButtonMale;
        private Label label6;
        private RadioButton radioButtonFemale;
        private GroupBox groupBox3;
        private MaskedTextBox textBoxHphone;
        private MaskedTextBox textBoxMphone;
        private Label label7;
        private Label label8;
        private MaskedTextBox textBoxEmail;
        private Label label9;
        private Label label10;
        private TextBox textBoxAddress;
        private GroupBox groupBox4;
        private MaskedTextBox textBoxCnumber;
        private MaskedTextBox textBoxPname;
        private MaskedTextBox textBoxNIC;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button Register;
        private Button Clear;
        private Button Delete;
        private Button Update;
        private Label label11;
        private BindingSource bindingSource1;
        private LinkLabel Exit;
        private ComboBox textBoxRno;
    }
}