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
    public partial class frm_SendMessage : Form
    {
        public frm_SendMessage()
        {
            InitializeComponent();
        }

        private void frm_SendMessage_Load(object sender, EventArgs e)
        {
            combo_Admins.DataSource = cls_Actions.GetAdminsData().Select(
                admin => $"{admin.userId}: {admin.firstName} {admin.lastName}"
            ).ToList();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string subject = txt_Subject.Text;
            string bodyText = txt_Body.Text;
            string[] adminString = combo_Admins.SelectedItem.ToString().Split(':');
            int adminId = Convert.ToInt32(adminString[0]);
            cls_Actions.AddMessage(subject, bodyText, cls_Actions.userId, adminId);
            txt_Body.Clear();
            txt_Subject.Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Simpleuser frmSimpleuser = new frm_Simpleuser();
            frmSimpleuser.Show();
        }
    }
}
