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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            cls_Actions.LoadData(txt_FirstName, txt_LastName, txt_Age);
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            cls_Actions.UpdateData(txt_FirstName, txt_LastName, txt_Age, cls_Actions.userId);
        }

        private void btn_SeeUsers_Click(object sender, EventArgs e)
        {
            frm_SeeUsers frmSeeUsers = new frm_SeeUsers();
            frmSeeUsers.ShowDialog();
            this.Hide();
        }

        private void btn_SeeMessages_Click(object sender, EventArgs e)
        {
            frm_SeeMessages frmSeeMessages = new frm_SeeMessages();
            frmSeeMessages.Show();
            this.Hide();
        }
    }
}
