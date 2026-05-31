using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefereeX
{
    public partial class RefereeX : Form
    {
        public RefereeX()
        {
            InitializeComponent();
        }

        private void btnRefereeManagement_Click(object sender, EventArgs e)
        {
            RefereeManagementForm refereeForm = new RefereeManagementForm();
            refereeForm.ShowDialog();
        }

        private void btnTrainingReports_Click(object sender, EventArgs e)
        {
            TrainingReportsForm reportForm = new TrainingReportsForm();
            reportForm.ShowDialog();
        }

        private void RefereeX_Load(object sender, EventArgs e)
        {
            Application.Run(new RefereeX());
        }
    }
}
