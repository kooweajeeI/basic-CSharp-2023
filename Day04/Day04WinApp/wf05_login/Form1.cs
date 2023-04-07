using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace wf05_login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "abcd" && TxtPwd.Text == "1234")
            {
                lblMsg.Text = "로그인 성공";
            }
            else
            {
                lblMsg.Text = "로그인 실패";
            }

        }
    }
}
