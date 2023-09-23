namespace Bai2
{
    partial class frm_Bai2
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
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_Stk = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_Tien = new System.Windows.Forms.Label();
            this.lbl_QL = new System.Windows.Forms.Label();
            this.txt_Sotk = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Location = new System.Drawing.Point(94, 119);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(86, 13);
            this.lbl_TenKH.TabIndex = 0;
            this.lbl_TenKH.Text = "Tên khách hàng";
            // 
            // lbl_Stk
            // 
            this.lbl_Stk.AutoSize = true;
            this.lbl_Stk.Location = new System.Drawing.Point(113, 83);
            this.lbl_Stk.Name = "lbl_Stk";
            this.lbl_Stk.Size = new System.Drawing.Size(67, 13);
            this.lbl_Stk.TabIndex = 1;
            this.lbl_Stk.Text = "Số tài khoản";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(80, 156);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(100, 13);
            this.lbl_DiaChi.TabIndex = 0;
            this.lbl_DiaChi.Text = "Địa chỉ khách hàng";
            // 
            // lbl_Tien
            // 
            this.lbl_Tien.AutoSize = true;
            this.lbl_Tien.Location = new System.Drawing.Point(66, 192);
            this.lbl_Tien.Name = "lbl_Tien";
            this.lbl_Tien.Size = new System.Drawing.Size(114, 13);
            this.lbl_Tien.TabIndex = 1;
            this.lbl_Tien.Text = "Số tiền trong tài khoản";
            // 
            // lbl_QL
            // 
            this.lbl_QL.AutoSize = true;
            this.lbl_QL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QL.Location = new System.Drawing.Point(62, 30);
            this.lbl_QL.Name = "lbl_QL";
            this.lbl_QL.Size = new System.Drawing.Size(465, 31);
            this.lbl_QL.TabIndex = 1;
            this.lbl_QL.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // txt_Sotk
            // 
            this.txt_Sotk.Location = new System.Drawing.Point(186, 80);
            this.txt_Sotk.Name = "txt_Sotk";
            this.txt_Sotk.Size = new System.Drawing.Size(341, 20);
            this.txt_Sotk.TabIndex = 2;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(186, 116);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(341, 20);
            this.txt_Ten.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(186, 153);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(341, 20);
            this.txt_DiaChi.TabIndex = 2;
            // 
            // txt_Tien
            // 
            this.txt_Tien.Location = new System.Drawing.Point(186, 189);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(341, 20);
            this.txt_Tien.TabIndex = 2;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(209, 215);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(290, 215);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(371, 215);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(452, 215);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 101);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(406, 358);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(120, 20);
            this.txt_TongTien.TabIndex = 2;
            // 
            // frm_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tien);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_Sotk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Tien);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_QL);
            this.Controls.Add(this.lbl_Stk);
            this.Controls.Add(this.lbl_TenKH);
            this.Name = "frm_Bai2";
            this.Text = "frm_Baitap2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_Stk;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_Tien;
        private System.Windows.Forms.Label lbl_QL;
        private System.Windows.Forms.TextBox txt_Sotk;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TongTien;
    }
}

