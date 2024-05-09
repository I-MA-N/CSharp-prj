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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            var result = cls_Actions.Login(username, password);

            if (result == "simpleuser")
            {
                frm_Simpleuser frmSimpleuser = new frm_Simpleuser();
                frmSimpleuser.Show();
                this.Hide();
            }
            else if (result == "admin")
            {
                frm_Admin frmAdmin = new frm_Admin();
                frmAdmin.Show();
                this.Hide();
            }
        }
    }
}
