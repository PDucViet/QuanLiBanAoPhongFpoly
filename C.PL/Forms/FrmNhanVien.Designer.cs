namespace C.PL.Forms
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            btnReset = new Button();
            btnSua = new Button();
            btnThem = new Button();
            BtnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_diachi = new TextBox();
            tb_ten = new TextBox();
            tb_sdt = new TextBox();
            tb_email = new TextBox();
            label5 = new Label();
            cbb_cv = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            lb_Id = new Label();
            groupBox3 = new GroupBox();
            rdOff = new RadioButton();
            rdOn = new RadioButton();
            groupBox2 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label8 = new Label();
            tb_TaiKhoan = new TextBox();
            label7 = new Label();
            dt_DoB = new DateTimePicker();
            label4 = new Label();
            dgvNhanVien = new DataGridView();
            tbSearch = new TextBox();
            btSearch = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(710, 464);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 47);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(971, 464);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 47);
            btnSua.TabIndex = 37;
            btnSua.Text = "Sửa nhân viên";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(449, 464);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 47);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm nhân viên";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // BtnThoat
            // 
            BtnThoat.Image = (Image)resources.GetObject("BtnThoat.Image");
            BtnThoat.Location = new Point(1232, 464);
            BtnThoat.Margin = new Padding(3, 2, 3, 2);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(131, 47);
            BtnThoat.TabIndex = 39;
            BtnThoat.Text = "Thoát";
            BtnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 44;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 45;
            label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 129);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 46;
            label3.Text = "SDT";
            // 
            // tb_diachi
            // 
            tb_diachi.Location = new Point(148, 80);
            tb_diachi.Margin = new Padding(3, 2, 3, 2);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(229, 23);
            tb_diachi.TabIndex = 48;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(148, 42);
            tb_ten.Margin = new Padding(3, 2, 3, 2);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(229, 23);
            tb_ten.TabIndex = 49;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(148, 121);
            tb_sdt.Margin = new Padding(3, 2, 3, 2);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(229, 23);
            tb_sdt.TabIndex = 50;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(148, 163);
            tb_email.Margin = new Padding(3, 2, 3, 2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(229, 23);
            tb_email.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 52;
            label5.Text = "Email";
            // 
            // cbb_cv
            // 
            cbb_cv.FormattingEnabled = true;
            cbb_cv.Location = new Point(148, 233);
            cbb_cv.Margin = new Padding(3, 2, 3, 2);
            cbb_cv.Name = "cbb_cv";
            cbb_cv.Size = new Size(229, 23);
            cbb_cv.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 241);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 54;
            label6.Text = "Chức vụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 204);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 58;
            label9.Text = "Giới tính ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_Id);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tb_TaiKhoan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dt_DoB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbb_cv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_ten);
            groupBox1.Controls.Add(tb_diachi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(383, 502);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin nhân viên";
            // 
            // lb_Id
            // 
            lb_Id.AutoSize = true;
            lb_Id.Location = new Point(15, 23);
            lb_Id.Name = "lb_Id";
            lb_Id.Size = new Size(0, 15);
            lb_Id.TabIndex = 70;
            lb_Id.UseWaitCursor = true;
            lb_Id.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdOff);
            groupBox3.Controls.Add(rdOn);
            groupBox3.Location = new Point(140, 356);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 44);
            groupBox3.TabIndex = 69;
            groupBox3.TabStop = false;
            // 
            // rdOff
            // 
            rdOff.AutoSize = true;
            rdOff.Location = new Point(122, 12);
            rdOff.Name = "rdOff";
            rdOff.Size = new Size(118, 19);
            rdOff.TabIndex = 67;
            rdOff.TabStop = true;
            rdOff.Text = "Không hoạt động";
            rdOff.UseVisualStyleBackColor = true;
            // 
            // rdOn
            // 
            rdOn.AutoSize = true;
            rdOn.Checked = true;
            rdOn.Location = new Point(8, 12);
            rdOn.Name = "rdOn";
            rdOn.Size = new Size(82, 19);
            rdOn.TabIndex = 66;
            rdOn.TabStop = true;
            rdOn.Text = "Hoạt động";
            rdOn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFemale);
            groupBox2.Controls.Add(rbMale);
            groupBox2.Location = new Point(139, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 33);
            groupBox2.TabIndex = 68;
            groupBox2.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(123, 9);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(41, 19);
            rbFemale.TabIndex = 62;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(9, 9);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 61;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 372);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 65;
            label8.Text = "Trạng thái";
            // 
            // tb_TaiKhoan
            // 
            tb_TaiKhoan.Location = new Point(148, 323);
            tb_TaiKhoan.Name = "tb_TaiKhoan";
            tb_TaiKhoan.Size = new Size(229, 23);
            tb_TaiKhoan.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 331);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 63;
            label7.Text = "Tài khoản";
            // 
            // dt_DoB
            // 
            dt_DoB.Format = DateTimePickerFormat.Short;
            dt_DoB.Location = new Point(148, 278);
            dt_DoB.Name = "dt_DoB";
            dt_DoB.Size = new Size(229, 23);
            dt_DoB.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 286);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 59;
            label4.Text = "Ngày sinh";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(449, 97);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowTemplate.Height = 25;
            dgvNhanVien.Size = new Size(916, 339);
            dgvNhanVien.TabIndex = 41;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(661, 24);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(521, 23);
            tbSearch.TabIndex = 42;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(1225, 24);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(140, 23);
            btSearch.TabIndex = 43;
            btSearch.Text = "Tìm kiếm";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1377, 522);
            Controls.Add(btSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvNhanVien);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(BtnThoat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnSua;
        private Button btnThem;
        private Button BtnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_diachi;
        private TextBox tb_ten;
        private TextBox tb_sdt;
        private TextBox tb_email;
        private Label label5;
        private ComboBox cbb_cv;
        private Label label6;
        private Label label9;
        private GroupBox groupBox1;
        private DataGridView dgvNhanVien;
        private Label label4;
        private DateTimePicker dt_DoB;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label7;
        private TextBox tb_TaiKhoan;
        private Label label8;
        private RadioButton rdOff;
        private RadioButton rdOn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lb_Id;
        private TextBox tbSearch;
        private Button btSearch;
    }
}