namespace C.PL.Views
{
    partial class frmChucVu
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
            txtTenChucVu = new TextBox();
            btnTimKiem = new Button();
            groupBox1 = new GroupBox();
            txtMaChucVu = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtTimKiem = new TextBox();
            dgvChucVu = new DataGridView();
            tenChucVu = new DataGridViewTextBoxColumn();
            maChucVu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            SuspendLayout();
            // 
            // txtTenChucVu
            // 
            txtTenChucVu.Location = new Point(166, 53);
            txtTenChucVu.Name = "txtTenChucVu";
            txtTenChucVu.Size = new Size(422, 27);
            txtTenChucVu.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(293, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaChucVu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenChucVu);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 152);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý chức vụ";
            // 
            // txtMaChucVu
            // 
            txtMaChucVu.Location = new Point(166, 20);
            txtMaChucVu.Name = "txtMaChucVu";
            txtMaChucVu.Size = new Size(422, 27);
            txtMaChucVu.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 56);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên chức vụ :";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(117, 97);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(381, 97);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(249, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvChucVu);
            groupBox2.Location = new Point(11, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 256);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chức vụ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Location = new Point(231, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(408, 69);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(281, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // dgvChucVu
            // 
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucVu.Columns.AddRange(new DataGridViewColumn[] { maChucVu, tenChucVu });
            dgvChucVu.Location = new Point(6, 75);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvChucVu.RowTemplate.Height = 29;
            dgvChucVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChucVu.Size = new Size(627, 175);
            dgvChucVu.TabIndex = 0;
            dgvChucVu.CellClick += dgvChucVu_CellClick;
            // 
            // tenChucVu
            // 
            tenChucVu.DataPropertyName = "tenChucVu";
            tenChucVu.HeaderText = "Tên chức vụ";
            tenChucVu.MinimumWidth = 6;
            tenChucVu.Name = "tenChucVu";
            tenChucVu.Width = 457;
            // 
            // maChucVu
            // 
            maChucVu.DataPropertyName = "maChucVu";
            maChucVu.HeaderText = "Mã chức vụ";
            maChucVu.MinimumWidth = 6;
            maChucVu.Name = "maChucVu";
            maChucVu.Width = 125;
            // 
            // frmChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 456);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChucVu";
            Text = "frmChucVu";
            Load += frmChucVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTenChucVu;
        private Button btnTimKiem;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private DataGridView dgvChucVu;
        private Label label1;
        private Button btnThem;
        private GroupBox groupBox3;
        private TextBox txtMaChucVu;
        private DataGridViewTextBoxColumn maChucVu;
        private DataGridViewTextBoxColumn tenChucVu;
    }
}