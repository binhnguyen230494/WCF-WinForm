using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBinhPhu
{
    public partial class FrmDangNhap : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            ServiceReference1.UserDetail obj = new ServiceReference1.UserDetail();
            obj.idacc = TxtDangNhap.Text;
            obj.pass = TxtMatKhau.Text;
            if (TxtDangNhap.Text == "" || TxtMatKhau.Text == "")
            {
                MessageBox.Show("Vui long them thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (client.KtActivate(obj) == false)
            {
                client.SuaActi(obj);
                if (client.DangNhap(obj) == true)
                {
                    {
                        if (client.Account(obj) == true)
                        {
                            Class1.IdAcc = TxtDangNhap.Text;
                            Class1.Role = 1;
                            MessageBox.Show("Chao Admin", "Account");
                            FrmOption f = new FrmOption();
                            this.Hide();
                            f.ShowDialog();
                        }
                        else
                        {
                            Class1.IdAcc = TxtDangNhap.Text;
                            Class1.Role = 0;
                            MessageBox.Show("Chào User", "Acount");
                            FrmVote f = new FrmVote();
                            this.Hide();
                            f.ShowDialog();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Thất bại", "Error");
                    TxtDangNhap.Clear();
                    TxtMatKhau.Clear();
                    TxtDangNhap.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã đăng nhâp!!","Thông báo", MessageBoxButtons.OK);
                TxtDangNhap.Clear();
                TxtMatKhau.Clear();
                TxtDangNhap.Focus();
            }
                
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
