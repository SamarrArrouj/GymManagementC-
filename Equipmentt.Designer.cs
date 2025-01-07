namespace GymManagementSystemC_
{
    partial class Equipmentt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipmentt));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMusclesUsed = new TextBox();
            txtEquipName = new TextBox();
            txtCost = new TextBox();
            txtDescription = new RichTextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            btnSave = new Button();
            btnReset = new Button();
            btnViewEq = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(144, 37);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(144, 134);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(144, 329);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 2;
            label3.Text = "Muscles Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(144, 389);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 3;
            label4.Text = "Delivery Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(144, 436);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(315, 329);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(215, 27);
            txtMusclesUsed.TabIndex = 5;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(315, 33);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(215, 27);
            txtEquipName.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(315, 436);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(215, 27);
            txtCost.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(315, 100);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 179);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(315, 389);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(215, 27);
            dateTimePickerDeliveryDate.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(218, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(327, 505);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEq
            // 
            btnViewEq.Location = new Point(436, 505);
            btnViewEq.Name = "btnViewEq";
            btnViewEq.Size = new Size(128, 29);
            btnViewEq.TabIndex = 12;
            btnViewEq.Text = "View Equipment";
            btnViewEq.UseVisualStyleBackColor = true;
            btnViewEq.Click += btnViewEq_Click;
            // 
            // Equipmentt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 553);
            Controls.Add(btnViewEq);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtDescription);
            Controls.Add(txtCost);
            Controls.Add(txtEquipName);
            Controls.Add(txtMusclesUsed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Equipmentt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipmentt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMusclesUsed;
        private TextBox txtEquipName;
        private TextBox txtCost;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePickerDeliveryDate;
        private Button btnSave;
        private Button btnReset;
        private Button btnViewEq;
    }
}