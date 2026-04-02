using System.Text.RegularExpressions;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string myID = "donghwan";
        string myPW = "king";
        int missed = 0;
        string idPattern = @"^[가-힣ㄱ-ㅎㅏ-ㅣa-zA-Z]+$";
        string pwPattern = @"^[가-힣ㄱ-ㅎㅏ-ㅣa-zA-Z\p{P}\p{S} ]+$";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPW.Text))
            {
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            decimal lockoutTime = 0;

            if (lockoutTime > 0)
            {
                MessageBox.Show("로그인 시도 횟수 초과! " + lockoutTime + "초 후 시도해주세요.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OK);
                lblErrorMsg.Visible = false;
                missed = 0;
            }
            else
            {
                //MessageBox.Show("로그인 실패!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
                if (missed < 4)
                {
                    missed++;
                }
                else
                {
                    MessageBox.Show("로그인 시도 횟수 초과! 30초 후 시도해주세요.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lockoutTime = 30;
                    while (lockoutTime > 0)
                    {
                        lblErrorMsg.Text = $"로그인 시도 횟수 초과! {lockoutTime}초 후 시도해주세요.";
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1000);
                        lockoutTime--;
                    }
                    lblErrorMsg.Text = $"아이디 또는 비밀번호가 잘못 되었습니다.";
                    lblErrorMsg.Visible = false;
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPW.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
            e.SuppressKeyPress = true;
                if (txtID.Text == "")
                {
                    txtPW.Text = "패스워드";
                    txtPW.ForeColor = Color.Silver;
                    txtPW.UseSystemPasswordChar = false;
                }
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                if (txtPW.Text == "")
                {
                    txtID.Text = "아이디";
                    txtID.ForeColor = Color.Silver;
                }
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            string currentText = txtID.Text == "아이디" ? "" : txtID.Text;
            string nextText = currentText.Remove(txtID.SelectionStart, txtID.SelectionLength)
                .Insert(txtID.SelectionStart, e.KeyChar.ToString());

            if (!Regex.IsMatch(nextText, idPattern))
            {
                e.Handled = true;
            }
        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            string currentText = txtPW.Text == "패스워드" ? "" : txtPW.Text;
            string nextText = currentText.Remove(txtPW.SelectionStart, txtPW.SelectionLength)
                .Insert(txtPW.SelectionStart, e.KeyChar.ToString());

            if (!Regex.IsMatch(nextText, pwPattern))
            {
                e.Handled = true;
            }
        }

        private void chkPWvisible_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPWvisible.Checked)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                if (txtPW.Text != "패스워드")
                {
                    txtPW.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
