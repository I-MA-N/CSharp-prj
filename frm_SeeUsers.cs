using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj
{
    public partial class frm_SeeUsers : Form
    {
        public frm_SeeUsers()
        {
            InitializeComponent();
        }

        public void setGridData()
        {
            grid_Users.DataSource = cls_Actions.GetSimpleusersData();
            lbl_Count.Text = $"Users count: {cls_Actions.GetSimpleusersData().Count}";
        }

        public void setInputsValue()
        {
            var selectedRow = grid_Users.CurrentRow.Cells;
            txt_FirstName.Text = selectedRow["firstName"].Value.ToString();
            txt_LastName.Text = selectedRow["lastName"].Value.ToString();
            txt_Age.Text = selectedRow["age"].Value.ToString();
        }

        public void resetInputs()
        {
            foreach (Control childControl in group_Inputs.Controls)
            {
                if (childControl is TextBox)
                {
                    childControl.Text = string.Empty;
                }
            }
            foreach (Control childControl in group_Inputs2.Controls)
            {
                if (childControl is TextBox)
                {
                    childControl.Text = string.Empty;
                }
            }
        }

        private void frm_SeeUsers_Load(object sender, EventArgs e)
        {
            setGridData();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin frmAdmin = new frm_Admin();
            frmAdmin.Show();
            this.Close();
        }

        private void grid_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (group_Inputs2.Visible == false)
                setInputsValue();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            group_Inputs.Visible = true;
            group_Inputs2.Visible = false;
            btn_Submit.Visible = true;
            setInputsValue();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            group_Inputs.Visible = true;
            group_Inputs2.Visible = true;
            btn_Submit.Visible = true;
            resetInputs();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (group_Inputs2.Visible == false)
            {
                int selectedUserId = Convert.ToInt32(grid_Users.CurrentRow.Cells["userId"].Value);
                cls_Actions.UpdateData(txt_FirstName, txt_LastName, txt_Age, selectedUserId);
                setGridData();
            } else
            {
                cls_Actions.AddUser(txt_Username.Text, txt_Password.Text, txt_FirstName.Text,
                                    txt_LastName.Text, Convert.ToInt32(txt_Age.Text));
                resetInputs();
                setGridData();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(grid_Users.CurrentRow.Cells["userId"].Value);
            bool result = cls_Actions.DeleteUser(selectedUserId);
            if (result)
            {
                setGridData();
            }
        }
    }
}
