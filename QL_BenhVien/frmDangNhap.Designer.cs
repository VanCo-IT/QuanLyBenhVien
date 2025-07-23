namespace GUI_QLBV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pnMain = new Panel();
            pnDangNhap = new Panel();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnMain.SuspendLayout();
            pnDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackgroundImage = (Image)resources.GetObject("pnMain.BackgroundImage");
            pnMain.BackgroundImageLayout = ImageLayout.Stretch;
            pnMain.Controls.Add(pnDangNhap);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(884, 561);
            pnMain.TabIndex = 0;
            // 
            // pnDangNhap
            // 
            pnDangNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnDangNhap.BackColor = Color.FromArgb(0, 192, 192);
            pnDangNhap.BorderStyle = BorderStyle.FixedSingle;
            pnDangNhap.Controls.Add(txtMatKhau);
            pnDangNhap.Controls.Add(txtEmail);
            pnDangNhap.Controls.Add(label2);
            pnDangNhap.Controls.Add(label1);
            pnDangNhap.Location = new Point(275, 117);
            pnDangNhap.Name = "pnDangNhap";
            pnDangNhap.Size = new Size(329, 86);
            pnDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(84, 62);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(248, 23);
            txtMatKhau.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(84, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnMain);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            Load += frmDangNhap_Load;
            pnMain.ResumeLayout(false);
            pnDangNhap.ResumeLayout(false);
            pnDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnDangNhap;
        private Label label1;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private Label label2;
    }
}