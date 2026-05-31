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
    public partial class RefereeManagementForm : Form
    {
        private readonly RefereeService _refereeService;
        private readonly LookupService _lookupService;

        public RefereeManagementForm()
        {
            InitializeComponent();
            _refereeService = new RefereeService();
            _lookupService = new LookupService();
        }

        private void RefereeManagementForm_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxes();
            RefreshGrid();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbRanks.SelectedValue != null && cmbCities.SelectedValue != null)
            {
                var referee = new Referee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Rank_Id = Convert.ToInt32(cmbRanks.SelectedValue),
                    City_Id = Convert.ToInt32(cmbCities.SelectedValue),
                    IsActive = chkIsActive.Checked
                };

                _refereeService.Create(referee);
                RefreshGrid();
                ClearInputFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReferees.CurrentRow != null && cmbRanks.SelectedValue != null && cmbCities.SelectedValue != null)
            {
                var referee = new Referee
                {
                    Id = Convert.ToInt32(dgvReferees.CurrentRow.Cells["Id"].Value),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Rank_Id = Convert.ToInt32(cmbRanks.SelectedValue),
                    City_Id = Convert.ToInt32(cmbCities.SelectedValue),
                    IsActive = chkIsActive.Checked
                };

                _refereeService.Update(referee);
                RefreshGrid();
                ClearInputFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReferees.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvReferees.CurrentRow.Cells["Id"].Value);
                _refereeService.Delete(id);
                RefreshGrid();
                ClearInputFields();
            }
        }

        private void dgvReferees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReferees.CurrentRow != null)
            {
                txtFirstName.Text = dgvReferees.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvReferees.CurrentRow.Cells["LastName"].Value.ToString();
                cmbRanks.SelectedValue = dgvReferees.CurrentRow.Cells["Rank_Id"].Value;
                cmbCities.SelectedValue = dgvReferees.CurrentRow.Cells["City_Id"].Value;
                chkIsActive.Checked = Convert.ToBoolean(dgvReferees.CurrentRow.Cells["IsActive"].Value);
            }
        }

        private void LoadDataToComboBoxes()
        {
            cmbRanks.DataSource = _lookupService.GetRanks();
            cmbRanks.DisplayMember = "RankName";
            cmbRanks.ValueMember = "Id";

            cmbCities.DataSource = _lookupService.GetCities();
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "Id";
        }

        private void RefreshGrid()
        {
            dgvReferees.DataSource = _refereeService.GetAll();

            if (dgvReferees.Columns["Rank"] != null) dgvReferees.Columns["Rank"].Visible = false;
            if (dgvReferees.Columns["City"] != null) dgvReferees.Columns["City"].Visible = false;
            if (dgvReferees.Columns["TrainingAttendances"] != null) dgvReferees.Columns["TrainingAttendances"].Visible = false;
        }

        private void ClearInputFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            if (cmbRanks.Items.Count > 0) cmbRanks.SelectedIndex = 0;
            if (cmbCities.Items.Count > 0) cmbCities.SelectedIndex = 0;
            chkIsActive.Checked = false;
        }
    }
}
