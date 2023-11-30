namespace C.PL.Forms.FrmDangNhap
{
    partial class frmDoiMatKhau
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
            btCancel = new Button();
            btReset = new Button();
            btAdd = new Button();
            txtNewPsss = new TextBox();
            txtOldPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCancel);
            groupBox1.Controls.Add(btReset);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(txtNewPsss);
            groupBox1.Controls.Add(txtOldPass);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(61, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Điền thông tin";
            // 
            // btCancel
            // 
            btCancel.Location = new Point(349, 230);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(130, 40);
            btCancel.TabIndex = 8;
            btCancel.Text = "Thoát";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            btReset.Location = new Point(188, 230);
            btReset.Name = "btReset";
            btReset.Size = new Size(130, 40);
            btReset.TabIndex = 7;
            btReset.Text = "Làm mới";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(28, 230);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(130, 40);
            btAdd.TabIndex = 6;
            btAdd.Text = "Đổi Mật khẩu";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // txtNewPsss
            // 
            txtNewPsss.Location = new Point(175, 174);
            txtNewPsss.Name = "txtNewPsss";
            txtNewPsss.Size = new Size(304, 23);
            txtNewPsss.TabIndex = 5;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(175, 115);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(304, 23);
            txtOldPass.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(175, 55);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(304, 23);
            txtUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 182);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 123);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 63);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(663, 390);
            Controls.Add(groupBox1);
            Name = "frmDoiMatKhau";
            Text = "frmDoiMatKhau";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewPsss;
        private TextBox txtOldPass;
        private TextBox txtUser;
        private Button btAdd;
        private Button btReset;
        private Button btCancel;
    }
}