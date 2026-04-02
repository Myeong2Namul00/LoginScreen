namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            chkPWvisible = new CheckBox();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 72F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(183, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(306, 124);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("나눔고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(112, 182);
            txtID.Name = "txtID";
            txtID.Size = new Size(459, 50);
            txtID.TabIndex = 0;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.KeyPress += txtID_KeyPress;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("나눔고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(112, 245);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(459, 50);
            txtPW.TabIndex = 1;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.KeyPress += txtPW_KeyPress;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 255, 192);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("한컴 말랑말랑 Bold", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(258, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(179, 43);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("나눔고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(112, 298);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(285, 19);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // chkPWvisible
            // 
            chkPWvisible.AutoSize = true;
            chkPWvisible.Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPWvisible.Location = new Point(476, 298);
            chkPWvisible.Name = "chkPWvisible";
            chkPWvisible.Size = new Size(95, 18);
            chkPWvisible.TabIndex = 5;
            chkPWvisible.TabStop = false;
            chkPWvisible.Text = "비밀번호 표시";
            chkPWvisible.UseVisualStyleBackColor = true;
            chkPWvisible.CheckedChanged += chkPWvisible_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 384);
            Controls.Add(chkPWvisible);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
        private CheckBox chkPWvisible;
    }
}
