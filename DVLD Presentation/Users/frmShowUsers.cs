using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;

namespace DVLD
{
    public partial class frmShowUsers : Form
    {
        private DataTable Users = new DataTable();
        public frmShowUsers()
        {
            InitializeComponent();
        }
        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            comboBoxActiveStatus.SelectedIndex = 0;
            _LoadUsersList();
           
        }
        private void _ResizedataGridTable()
        {
            dataGridViewUsers.Columns[0].Width = 100;
            dataGridViewUsers.Columns[1].Width = 100;
            dataGridViewUsers.Columns[2].Width = 400;
            dataGridViewUsers.Columns[3].Width = 200;
            dataGridViewUsers.Columns[4].Width = 100;
        }
        private void _LoadUsersList()
        {
            Users = clsUser.GetAllUsers();
            dataGridViewUsers.DataSource = Users;
            lblRecordsCount.Text = dataGridViewUsers.Rows.Count.ToString() + " Record(s)";
            _ResizedataGridTable();
            
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser User = new frmAddEditUser(-1);
            User.DataBack += frmAddEditUser_DataBack;
            User.ShowDialog();
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 1 || comboBoxFilter.SelectedIndex == 2)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else if (comboBoxFilter.SelectedIndex == 3)
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            else if (comboBoxFilter.SelectedIndex == 4)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TxtBoxFilterFilter_Visibility()
        {
            txtBoxFilter.Visible = comboBoxFilter.SelectedIndex != 0 && comboBoxFilter.SelectedIndex != 5;
        }
        private void comboBoxActiveStatus_Visibility()
        {
            comboBoxActiveStatus.Visible = comboBoxFilter.SelectedIndex == 5;
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Text = string.Empty;
            TxtBoxFilterFilter_Visibility();
            comboBoxActiveStatus_Visibility();
        }
        private void comboBoxActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = Users;
            if (comboBoxActiveStatus.SelectedIndex != 0)
            {
                DataTable dt = Users;
                string FilterExepression = (comboBoxActiveStatus.SelectedIndex == 1) ? "1" : "0";
                dt.DefaultView.RowFilter = string.Format( "[{0}] = {1}" ,comboBoxFilter.Text.Trim() , FilterExepression.ToString());
                dt = dt.DefaultView.ToTable();
                dataGridViewUsers.DataSource = dt;
                lblRecordsCount.Text = dt.Rows.Count.ToString() + " Record(s)";
            }
            
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = Users;
            if (txtBoxFilter.Text != string.Empty && comboBoxFilter.SelectedIndex != 0)
            {

                DataTable dt = Users;
                dt.DefaultView.RowFilter = comboBoxFilter.SelectedIndex == 1 || comboBoxFilter.SelectedIndex == 2 ? 
                    string.Format("[{0}] = {1}", comboBoxFilter.Text, txtBoxFilter.Text.Trim()) :
                    string.Format("[{0}]  LIKE '{1}%'", comboBoxFilter.Text, txtBoxFilter.Text.Trim());
                dt = dt.DefaultView.ToTable();
                dataGridViewUsers.DataSource = dt;
                lblRecordsCount.Text = dt.Rows.Count.ToString() + " Record(s)";
            }else if(txtBoxFilter.Text == string.Empty || comboBoxFilter.SelectedIndex == 0)
            {
                Users.DefaultView.RowFilter = string.Empty;
                dataGridViewUsers.DataSource= Users;
                lblRecordsCount.Text = dataGridViewUsers.Rows.Count.ToString();
            }
        }
        private void frmDisplayUserInfo_DataBack(object sender, bool IsChanged)
        {
            if (IsChanged)
                _LoadUsersList(); ;
        }
        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            frmDisplayUserInfo UserInfo = new frmDisplayUserInfo(UserID, frmDisplayUserInfo.enMode.DisplayInfo);
            UserInfo.DataBack += frmDisplayUserInfo_DataBack;
            UserInfo.Show();
        }
        private void frmAddEditUser_DataBack(object sendre, bool IsSaved)
        {
            if (IsSaved)
                _LoadUsersList();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser User = new frmAddEditUser(-1);
            User.DataBack += frmAddEditUser_DataBack;
            User.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridViewUsers.CurrentRow.Cells[1].Value;
            frmAddEditUser User = new frmAddEditUser(PersonID);
            User.DataBack += frmAddEditUser_DataBack;
            User.ShowDialog();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("Record Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadUsersList();
            }
            else
            {
                MessageBox.Show("Deletion Operation Failed ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            frmDisplayUserInfo UserInfo = new frmDisplayUserInfo(UserID, frmDisplayUserInfo.enMode.ChangePassword);
            UserInfo.Show();
        }
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Service Not Available Right Now", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Service Not Available Right Now", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
