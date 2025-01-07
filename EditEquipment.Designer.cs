namespace GymManagementSystemC_
{
    partial class EditEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEquipment));
            btnCancel = new Button();
            btnEdit = new Button();
            dateTimePickerDeliveryDate = new DateTimePicker();
            txtDescription = new RichTextBox();
            txtCost = new TextBox();
            txtEquipName = new TextBox();
            txtMusclesUsed = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(365, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(256, 500);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(287, 382);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(215, 27);
            dateTimePickerDeliveryDate.TabIndex = 22;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(287, 93);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 179);
            txtDescription.TabIndex = 21;
            txtDescription.Text = "";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(287, 429);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(215, 27);
            txtCost.TabIndex = 20;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(287, 26);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(215, 27);
            txtEquipName.TabIndex = 19;
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(287, 322);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(215, 27);
            txtMusclesUsed.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(116, 429);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 17;
            label5.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(116, 382);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 16;
            label4.Text = "Delivery Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(116, 322);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 15;
            label3.Text = "Muscles Used";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(116, 127);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 14;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(116, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 13;
            label1.Text = "Equipment Name";
            // 
            // EditEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
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
            Name = "EditEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEquipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnEdit;
        private DateTimePicker dateTimePickerDeliveryDate;
        private RichTextBox txtDescription;
        private TextBox txtCost;
        private TextBox txtEquipName;
        private TextBox txtMusclesUsed;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}