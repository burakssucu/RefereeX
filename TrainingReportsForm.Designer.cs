namespace RefereeX
{
    partial class TrainingReportsForm
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
            label1 = new Label();
            label2 = new Label();
            chkIsPresent = new CheckBox();
            cmbReferees = new ComboBox();
            cmbTrainings = new ComboBox();
            btnSaveAttendance = new Button();
            btnDeleteAttendance = new Button();
            dgvAttendances = new DataGridView();
            groupBox1 = new GroupBox();
            rbFIFA = new RadioButton();
            chkPerfectAttendance = new CheckBox();
            lblLinqResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Hakem Seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 58);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "İdman / Konum Seç:";
            // 
            // chkIsPresent
            // 
            chkIsPresent.AutoSize = true;
            chkIsPresent.Location = new Point(80, 136);
            chkIsPresent.Name = "chkIsPresent";
            chkIsPresent.Size = new Size(160, 19);
            chkIsPresent.TabIndex = 2;
            chkIsPresent.Text = "İdmana Katıldı (İmza Attı)";
            chkIsPresent.UseVisualStyleBackColor = true;
            // 
            // cmbReferees
            // 
            cmbReferees.FormattingEnabled = true;
            cmbReferees.Location = new Point(144, 22);
            cmbReferees.Name = "cmbReferees";
            cmbReferees.Size = new Size(121, 23);
            cmbReferees.TabIndex = 3;
            // 
            // cmbTrainings
            // 
            cmbTrainings.FormattingEnabled = true;
            cmbTrainings.Location = new Point(190, 58);
            cmbTrainings.Name = "cmbTrainings";
            cmbTrainings.Size = new Size(121, 23);
            cmbTrainings.TabIndex = 4;
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.Location = new Point(383, 22);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(216, 23);
            btnSaveAttendance.TabIndex = 5;
            btnSaveAttendance.Text = "➕ Katılım Girişi Yap";
            btnSaveAttendance.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAttendance
            // 
            btnDeleteAttendance.Location = new Point(383, 68);
            btnDeleteAttendance.Name = "btnDeleteAttendance";
            btnDeleteAttendance.Size = new Size(216, 23);
            btnDeleteAttendance.TabIndex = 6;
            btnDeleteAttendance.Text = "❌ Seçili Kaydı Sil";
            btnDeleteAttendance.UseVisualStyleBackColor = true;
            // 
            // dgvAttendances
            // 
            dgvAttendances.AllowUserToResizeRows = false;
            dgvAttendances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendances.Location = new Point(403, 136);
            dgvAttendances.Name = "dgvAttendances";
            dgvAttendances.Size = new Size(240, 150);
            dgvAttendances.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLinqResult);
            groupBox1.Controls.Add(chkPerfectAttendance);
            groupBox1.Controls.Add(rbFIFA);
            groupBox1.Location = new Point(131, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelişmiş İdman Analizleri (LINQ Sorguları)";
            // 
            // rbFIFA
            // 
            rbFIFA.AutoSize = true;
            rbFIFA.Location = new Point(2, 22);
            rbFIFA.Name = "rbFIFA";
            rbFIFA.Size = new Size(230, 19);
            rbFIFA.TabIndex = 0;
            rbFIFA.TabStop = true;
            rbFIFA.Text = "FIFA Klasmanının Toplam Katılım Sayısı";
            rbFIFA.UseVisualStyleBackColor = true;
            // 
            // chkPerfectAttendance
            // 
            chkPerfectAttendance.AutoSize = true;
            chkPerfectAttendance.Location = new Point(1, 47);
            chkPerfectAttendance.Name = "chkPerfectAttendance";
            chkPerfectAttendance.Size = new Size(197, 19);
            chkPerfectAttendance.TabIndex = 1;
            chkPerfectAttendance.Text = "Eksiksiz Katılan Hakemleri Listele";
            chkPerfectAttendance.UseVisualStyleBackColor = true;
            // 
            // lblLinqResult
            // 
            lblLinqResult.AutoSize = true;
            lblLinqResult.Location = new Point(-1, 71);
            lblLinqResult.Name = "lblLinqResult";
            lblLinqResult.Size = new Size(46, 15);
            lblLinqResult.TabIndex = 2;
            lblLinqResult.Text = "Sonuç :";
            // 
            // TrainingReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvAttendances);
            Controls.Add(btnDeleteAttendance);
            Controls.Add(btnSaveAttendance);
            Controls.Add(cmbTrainings);
            Controls.Add(cmbReferees);
            Controls.Add(chkIsPresent);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrainingReportsForm";
            Text = "TrainingReportsForm";
            Load += TrainingReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chkIsPresent;
        private ComboBox cmbReferees;
        private ComboBox cmbTrainings;
        private Button btnSaveAttendance;
        private Button btnDeleteAttendance;
        private DataGridView dgvAttendances;
        private GroupBox groupBox1;
        private Label lblLinqResult;
        private CheckBox chkPerfectAttendance;
        private RadioButton rbFIFA;
    }
}