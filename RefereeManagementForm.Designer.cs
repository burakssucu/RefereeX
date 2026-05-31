namespace RefereeX
{
    partial class RefereeManagementForm
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            chkIsActive = new CheckBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnList = new Button();
            dgvReferees = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cmbRanks = new ComboBox();
            cmbCities = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReferees).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(68, 80);
            Label1.Name = "Label1";
            Label1.Size = new Size(31, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Adı :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(68, 105);
            Label2.Name = "Label2";
            Label2.Size = new Size(48, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Soyadı :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(68, 131);
            Label3.Name = "Label3";
            Label3.Size = new Size(92, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Klasman (Rank):";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(68, 202);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(111, 19);
            chkIsActive.TabIndex = 3;
            chkIsActive.Text = "Lisansı Aktif mi?";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(161, 334);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "➕ Ekle";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(242, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "🔄 Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(336, 334);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "❌ Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(417, 334);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 7;
            btnList.Text = "📋 Listele";
            btnList.UseVisualStyleBackColor = true;
            // 
            // dgvReferees
            // 
            dgvReferees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReferees.Location = new Point(318, 50);
            dgvReferees.Name = "dgvReferees";
            dgvReferees.Size = new Size(240, 150);
            dgvReferees.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(105, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            // 
            // cmbRanks
            // 
            cmbRanks.FormattingEnabled = true;
            cmbRanks.Location = new Point(161, 129);
            cmbRanks.Name = "cmbRanks";
            cmbRanks.Size = new Size(121, 23);
            cmbRanks.TabIndex = 11;
            // 
            // cmbCities
            // 
            cmbCities.FormattingEnabled = true;
            cmbCities.Location = new Point(161, 158);
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(121, 23);
            cmbCities.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 160);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Şehir :";
            // 
            // RefereeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCities);
            Controls.Add(label4);
            Controls.Add(cmbRanks);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dgvReferees);
            Controls.Add(btnList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(chkIsActive);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "RefereeManagementForm";
            Text = "RefereeManagementForm";
            Load += RefereeManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReferees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Label Label2;
        private Label Label3;
        private CheckBox chkIsActive;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnList;
        private DataGridView dgvReferees;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cmbRanks;
        private ComboBox cmbCities;
        private Label label4;
    }
}