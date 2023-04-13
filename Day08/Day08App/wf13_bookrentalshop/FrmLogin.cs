using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false;     // 로그인 성공했는지 변수

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess();
            if (isLogined)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        // DB userTbl에서 정보확인 로그인처리
        private bool LoginProcess()
        {
            // Validation check
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = TxtUserId.Text;
            string strPassword = TxtPassword.Text;
            try
            {
                // DB처리
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    #region<DB쿼리를 위한 구성>
                    string selQuery = @"SELECT userid, password 
                                        FROM  usertbl
                                        WHERE userId = @userId
                                        AND password = @password";
                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userID", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader();
                    reader.Read();

                    // strUserId = reader["userId"]?.ToString();
                    // strPassword = reader["password"]?.ToString();

                    strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                    strPassword = reader["password"] != null ? reader["password"].ToString() : "--";

                    return true;

                }   // conn.Close();

                // MessageBox.Show($"{strUserId} / {strPassword}");
            }
            catch
            {
                //MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("아이디와 비밀번호 확인요망", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Environment.Exit(0);    // 가장 완벽하게 프로그램 종료
        }

        // 이게 없으면 x버튼이나 알트F4했을 때 메인폼이 나타마
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogined != true)      // 로그인 안되었을 때 창을 닫으면 프로그램 모두 종료
            {
                Environment.Exit(0);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)    // enter키
            {
                BtnLogin_Click(sender, e);  // 버튼 클릭 이벤트 핸들러 호출
            }
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)    // enter키
            {
                TxtPassword.Focus();
            }
        }
    }
}
