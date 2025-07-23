using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            pnDangNhap.BackColor = Color.FromArgb(230, Color.White);  // Trắng đục
            pnDangNhap.BorderStyle = BorderStyle.FixedSingle;         // Có viền nhẹ

        }
    }
}
