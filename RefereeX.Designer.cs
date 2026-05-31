namespace RefereeX
{
    partial class RefereeX
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
            panel1 = new Panel();
            label1 = new Label();
            btnRefereeManagement = new Button();
            btnTrainingReports = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 41);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 0;
            label1.Text = "RefereeX - Hakem Otomasyon Paneli";
            // 
            // btnRefereeManagement
            // 
            btnRefereeManagement.Location = new Point(90, 175);
            btnRefereeManagement.Name = "btnRefereeManagement";
            btnRefereeManagement.Size = new Size(229, 187);
            btnRefereeManagement.TabIndex = 1;
            btnRefereeManagement.Text = "👤 Hakem Yönetim Modülü";
            btnRefereeManagement.UseVisualStyleBackColor = true;
            // 
            // btnTrainingReports
            // 
            btnTrainingReports.Location = new Point(479, 175);
            btnTrainingReports.Name = "btnTrainingReports";
            btnTrainingReports.Size = new Size(229, 187);
            btnTrainingReports.TabIndex = 2;
            btnTrainingReports.Text = "🏃 İdman ve Raporlama Modülü";
            btnTrainingReports.UseVisualStyleBackColor = true;
            // 
            // RefereeX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTrainingReports);
            Controls.Add(btnRefereeManagement);
            Controls.Add(panel1);
            Name = "RefereeX";
            Text = "RefereeX";
            Load += RefereeX_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnRefereeManagement;
        private Button btnTrainingReports;
    }
}