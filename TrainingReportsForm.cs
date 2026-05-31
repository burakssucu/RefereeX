using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefereeX.Data.Entities;
using RefereeX.Services;

namespace RefereeX
{
    public partial class TrainingReportsForm : Form
    {
        private readonly AttendanceService _attendanceService;
        private readonly RefereeService _refereeService;

        public TrainingReportsForm()
        {
            InitializeComponent();
            _attendanceService = new AttendanceService();
            _refereeService = new RefereeService();
        }

        private void TrainingReportsForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            LoadComboBoxes();
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if (cmbReferees.SelectedValue != null)
            {
                var attendance = new TrainingAttendance
                {
                    Referee_Id = Convert.ToInt32(cmbReferees.SelectedValue),
                    Training_Id = 1,
                    IsSignedTime = DateTime.Now,
                    IsPresent = chkIsPresent.Checked
                };

                _attendanceService.Create(attendance);
                RefreshGrid();
                ResetInputs();
            }
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (dgvAttendances.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAttendances.CurrentRow.Cells["Id"].Value);
                _attendanceService.Delete(id);
                RefreshGrid();
                ResetInputs();
            }
        }

        private void rbFIFA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFIFA.Checked)
            {
                int count = _attendanceService.GetTotalAttendanceCountByRank("FIFA");
                lblLinqResult.Text = "Sonuç: FIFA klasmanındaki hakemlerin toplam idman katılımı: " + count;
            }
        }

        private void chkPerfectAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerfectAttendance.Checked)
            {
                var names = _attendanceService.GetPerfectAttendanceRefereeNames();
                lblLinqResult.Text = "Sonuç: " + string.Join(", ", names);
            }
            else
            {
                lblLinqResult.Text = "Sonuç: ";
            }
        }

        private void RefreshGrid()
        {
            dgvAttendances.DataSource = _attendanceService.GetAll();

            if (dgvAttendances.Columns["Referee"] != null) dgvAttendances.Columns["Referee"].Visible = false;
            if (dgvAttendances.Columns["Training"] != null) dgvAttendances.Columns["Training"].Visible = false;
        }

        private void LoadComboBoxes()
        {
            cmbReferees.DataSource = _refereeService.GetAll();
            cmbReferees.DisplayMember = "FirstName";
            cmbReferees.ValueMember = "Id";
        }

        private void ResetInputs()
        {
            chkIsPresent.Checked = false;
            rbFIFA.Checked = false;
            chkPerfectAttendance.Checked = false;
        }
    }
}
