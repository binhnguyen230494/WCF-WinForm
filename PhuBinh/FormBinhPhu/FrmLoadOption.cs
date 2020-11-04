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
    public partial class FrmLoadOption : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        ServiceReference1.Option obj = new ServiceReference1.Option();
        ServiceReference1.Vote obi = new ServiceReference1.Vote();
        ServiceReference1.UserDetail oba = new ServiceReference1.UserDetail();

        public FrmLoadOption()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            FrmOption f = new FrmOption();
            this.Hide();
            f.Show();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            obi.idopt = CmbOption.Text;
            if (obi.idopt != "1")
            {
                MessageBox.Show("Khong the load thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else  if(client.LoadContent(obi) == true)
            {
                DataSet da = new DataSet();
                da = client.DsAns();
               

                DataSet ds = new DataSet();
                ds = client.DsOption();
                TxtContent.Text = ds.Tables[0].Rows[0][0].ToString();

                

                DataSet dt = new DataSet();
                dt = client.DsCode1();

               
                GridResult.DataSource = dt.Tables[0];
                GridResult.Columns[0].HeaderText = "Mã Vote";
                GridResult.Columns[1].HeaderText = "Tên người Vote";
                GridResult.Columns[2].HeaderText = "Câu trả lời";
                GridResult.Columns[3].HeaderText = "Giờ Vote";
            }
            
        }

        private void FrmLoadOption_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.KtActivate(oba) == true)
            {
                client.RsActi(oba);
            }
            Application.Exit();
        }

        

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //int maxid = 1;
            //for (int i = 0; i< CmbOption.Items.Count; i++)
            //{
            //    if ( Convert.ToInt32(CmbOption.Items[i]) > maxid)
            //    {
            //        maxid = Convert.ToInt32(CmbOption.Items[i]);
            //    }
            //}
            //maxid += 1;
            //CmbOption.Items.Add(maxid);
            //CmbOption.SelectedIndex = 1;
            TxtAns.Clear();
            TxtContent.Clear();
            CmbAns.DataSource = null;
            CmbOption.DataSource = null;
        }


        private void BtnSua_Click(object sender, EventArgs e)
        {
            //int id = CmbAns.SelectedIndex;
            //CmbAns.Items[id] = TxtAns.Text;
            if(TxtAns.Text == "")
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc là sửa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Option obj = new ServiceReference1.Option();
                obj.code = CmbAns.SelectedValue.ToString();
                obj.contents = TxtAns.Text;
                client.SuaAns(obj);
                //BtnLoad_Click(sender, e);
            }
            FrmLoadOption_Load(sender, e);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //int id = CmbAns.SelectedIndex;
            //CmbAns.Items.RemoveAt(id);
            if(TxtAns.Text == "")
            {
                MessageBox.Show("Thiếu điều kiện", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc là xóa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Option obj = new ServiceReference1.Option();
                obj.code = CmbAns.SelectedValue.ToString();
                obj.contents = TxtAns.Text;
                client.XoaOption(obj);
                MessageBox.Show("Đã Xóa", "Thông báo");
                //BtnLoad_Click(sender, e);
            }
            FrmLoadOption_Load(sender, e);
        }

        private void FrmLoadOption_Load(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            da = client.DistinctOpt();
            CmbOption.DataSource = da.Tables[0];
            CmbOption.DisplayMember = "idopt";
            CmbOption.ValueMember = "idopt";

            ServiceReference1.Option obj = new ServiceReference1.Option();
            DataSet ds = new DataSet();
            ds = client.DsAns();
            CmbAns.DataSource = ds.Tables[0];
            CmbAns.DisplayMember = "Contents";
            CmbAns.ValueMember = "Code";
            //TxtContent.Text = 
            DataSet dr = new DataSet();
            dr = client.DsQuestion();
            //TxtContent.Text = dr.Tables[0].Rows[0][0].ToString();
        }

        private void TxtOk_Click(object sender, EventArgs e)
        {
            ServiceReference1.Option obj = new ServiceReference1.Option();
            obj.contents = TxtContent.Text;
            if (obj.contents == TxtContent.Text)
            {
            }
            obj.deadlinetime = dateTimePicker1.Value;
            obj.idopt = CmbOption.Text;
            if (TxtContent.Text == "")
            {
                MessageBox.Show("Nhap Thieu Thong Tin", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            if (client.ThemContents(obj) == true)
            {
                MessageBox.Show("Da Them", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Id bị trùng", "Thong Bao", MessageBoxButtons.OK);
            }
            FrmLoadOption_Load(sender, e);
        }

        private void TxtNext_Click(object sender, EventArgs e)
        {
            ServiceReference1.Option obj = new ServiceReference1.Option();
            obj.contents = TxtAns.Text;
            if (obj.contents == TxtContent.Text)
            {
            }
            obj.deadlinetime = dateTimePicker1.Value;
            obj.idopt = CmbOption.Text;
            if (TxtAns.Text == "")
            {
                MessageBox.Show("Nhap Thieu Thong Tin", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            if (client.ThemContents(obj) == true)
            {
                MessageBox.Show("Da Them", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Id bị trùng", "Thong Bao", MessageBoxButtons.OK);
            }
            FrmLoadOption_Load(sender, e);
        }

        private void CmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLoadOption_Load(sender, e);
            MessageBox.Show("Đã lưu");
        }

        private void CmbAns_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtAns.Text = CmbAns.Text;
        }
    }
}
