namespace GymManagementSystemC_
{
    partial class EditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMember));
            btnCancel = new Button();
            btnEdit = new Button();
            comboBoxMembership = new ComboBox();
            comboBoxGymTime = new ComboBox();
            txtAddress = new RichTextBox();
            txtMobile = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            txtEmail = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(376, 462);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(250, 462);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "1 Month", "2 Month", "3 Month", "6 Month", "12 Month" });
            comboBoxMembership.Location = new Point(352, 383);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(151, 28);
            comboBoxMembership.TabIndex = 43;
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "06AM - 07AM", "07AM - 08AM", "08AM - 09AM", "05AM - 06AM", "06AM - 07AM" });
            comboBoxGymTime.Location = new Point(529, 170);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(151, 28);
            comboBoxGymTime.TabIndex = 42;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(529, 287);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 85);
            txtAddress.TabIndex = 41;
            txtAddress.Text = "";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(529, 232);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 40;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(529, 116);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(158, 27);
            dateTimePickerJoinDate.TabIndex = 39;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(529, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 38;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(162, 285);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(137, 27);
            dateTimePickerDOB.TabIndex = 37;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radioButton2.ForeColor = SystemColors.ControlLight;
            radioButton2.Location = new Point(245, 206);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 27);
            radioButton2.TabIndex = 36;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.ControlLight;
            radioButton1.Location = new Point(158, 206);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 27);
            radioButton1.TabIndex = 35;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(174, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 34;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(174, 63);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(421, 285);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 32;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(435, 232);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 31;
            label9.Text = "Mobile";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(421, 175);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 30;
            label8.Text = "Gym Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(421, 116);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 29;
            label7.Text = "Join Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(435, 65);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 28;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(190, 388);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 27;
            label5.Text = "Membership Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(38, 288);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 26;
            label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(50, 208);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 25;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(50, 135);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 24;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(50, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 23;
            label1.Text = "First Name";
            // 
            // EditMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(comboBoxMembership);
            Controls.Add(comboBoxGymTime);
            Controls.Add(txtAddress);
            Controls.Add(txtMobile);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnEdit;
        private ComboBox comboBoxMembership;
        private ComboBox comboBoxGymTime;
        private RichTextBox txtAddress;
        private TextBox txtMobile;
        private DateTimePicker dateTimePickerJoinDate;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerDOB;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}