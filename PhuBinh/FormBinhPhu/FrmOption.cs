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
    public partial class FrmOption : Form
    {
        ServiceReference1.UserDetail obj = new ServiceReference1.UserDetail();
        public FrmOption()
        {
            InitializeComponent();
            int a = Class1.Role;
            if(a == 0)
            {
                FrmVote f = new FrmVote();
                this.Hide();
                f.ShowDialog();
            }
        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            client.RsActi(obj);
            Application.Exit();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            FrmLoadOption f = new FrmLoadOption();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.DsAcount();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ServiceReference1.UserDetail obj = new ServiceReference1.UserDetail();
            obj.name = txtname.Text;
            obj.pass = txtpass.Text;
            if (txtrole.Text == "1")
            {
                obj.role = bool.Parse("true");
            }
            else
            {
                obj.role = bool.Parse("false");
            }
            obj.idacc = txtid.Text;
            if(txtname.Text==""||txtpass.Text==""||txtid.Text==""||txtrole.Text=="")
            {
                MessageBox.Show("Nhap Thieu Thong Tin", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            if(client.Them(obj)== true)
            {
                MessageBox.Show("Da Them", "Thong Bao", MessageBoxButtons.OK);
                BtnAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Id Account bị trùng", "Thong Bao", MessageBoxButtons.OK);
            }


        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtid.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtrole.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txtpass.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là sửa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.UserDetail obj = new ServiceReference1.UserDetail();
                obj.name = txtname.Text;
                obj.pass = txtpass.Text;
                if (txtrole.Text == "1")
                {
                    obj.role = bool.Parse("true");
                }
                else
                {
                    obj.role = bool.Parse("false");
                }
                obj.idacc = txtid.Text;
                client.Sua(obj);
                BtnAccount_Click(sender, e);

            }

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là xóa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.UserDetail obj = new ServiceReference1.UserDetail();
                obj.name = txtname.Text;
                obj.pass = txtpass.Text;
                if (txtrole.Text == "1")
                {
                    obj.role = bool.Parse("true");
                }
                else
                {
                    obj.role = bool.Parse("false");
                }
                obj.idacc = txtid.Text;
                client.Xoa(obj);
                MessageBox.Show("Đã Xóa", "Thông báo");
                BtnAccount_Click(sender, e);
            }
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            FrmVote f = new FrmVote();
            this.Hide();
            f.ShowDialog();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {

        }

        private void FrmOption_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.KtActivate(obj) == true)
            {
                client.RsActi(obj);
            }
            Application.Exit();
        }
    }
}
