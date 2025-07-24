using GUI_QLBV;

namespace QL_BenhVien
{
    public partial class frmChaoMung : Form
    {
        public frmChaoMung()
        {
            InitializeComponent();
            // Cấu hình kiểu cho thanh progress bar
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            // Thực hiện thao tác load chờ 3 giây
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    frmDangNhap login = new frmDangNhap();
                    login.Show();
                    this.Hide();
                }));
            });
        }
    }
}
