namespace C.PL.Forms.FrmDangNhap
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassWord = new TextBox();
            txtUser = new TextBox();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(96, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Điền thông tin tài khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Location = new Point(121, 177);
            button1.Name = "button1";
            button1.Size = new Size(155, 38);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(121, 124);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(246, 23);
            txtPassWord.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(121, 72);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(246, 23);
            txtUser.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(403, 408);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu ?";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(607, 450);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtUser;
        private TextBox txtPassWord;
        private Label label1;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}