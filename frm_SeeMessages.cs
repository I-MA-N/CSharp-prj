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
    public partial class frm_SeeMessages : Form
    {
        public frm_SeeMessages()
        {
            InitializeComponent();
        }

        private void setGridData()
        {
            List<tbl_Messages> messagesData = cls_Actions.GetMessagesData();
            lbl_Count.Text = $"Messages count: {messagesData.Count}";
            grid_Messages.DataSource = messagesData;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin frmAdmin = new frm_Admin();
            frmAdmin.Show();
            this.Close();
        }

        private void frm_SeeMessages_Load(object sender, EventArgs e)
        {
            setGridData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int selectedMessageId = Convert.ToInt32(grid_Messages.CurrentRow.Cells["messageId"].Value);
            bool result = cls_Actions.DeleteMessage(selectedMessageId);
            if (result)
            {
                setGridData();
            }
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            frm_Admin frmAdmin = new frm_Admin();
            frmAdmin.Show();
            this.Close();
        }
    }
}
