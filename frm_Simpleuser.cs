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
    public partial class frm_Simpleuser : Form
    {
        public frm_Simpleuser()
        {
            InitializeComponent();
        }

        private void frm_Simpleuser_Load(object sender, EventArgs e)
        {
            cls_Actions.LoadData(txt_FirstName, txt_LastName, txt_Age);
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            cls_Actions.UpdateData(txt_FirstName, txt_LastName, txt_Age, cls_Actions.userId);
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            frm_SendMessage frmSendMessage = new frm_SendMessage();
            frmSendMessage.Show();
            this.Hide();
        }
    }
}
