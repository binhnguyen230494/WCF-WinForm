using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FormBinhPhu
{
    public partial class FrmVote : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        ServiceReference1.Vote obj = new ServiceReference1.Vote();
        ServiceReference1.UserDetail obi = new ServiceReference1.UserDetail();

        public FrmVote()
        {
            InitializeComponent();
            Load += FrmVote_Load;
        }

        Timer t;
        DateTime endTime = new DateTime(2019, 03, 13, 14, 20, 00);
        private void FrmVote_Load(object sender, EventArgs e)
        {
            ServiceReference1.Vote obj = new ServiceReference1.Vote();
            GridResult_Click(sender, e);
            chart1_Click(sender, e);
            if (Class1.Role == 0)
            {
                chart1.Visible = false;
                GridResult.Visible = false;
            }
            
            DataSet ds = new DataSet();
            ds = client.DsAns();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Contents";
            comboBox1.ValueMember = "Contents";
            label7.Text = ds.Tables[0].Rows[0][2].ToString();

            DataSet dt = new DataSet();
            dt = client.DsQuestion();
            TxtYKien.Text = dt.Tables[0].Rows[0][0].ToString();
            t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;

            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");

            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");
            if (ts.TotalSeconds <= 0)
            {
                BtnVote.Enabled = false;
                t.Stop();
                label4.Text = "Đã hết giờ vote!!";
                chart1.Visible = true;
                GridResult.Visible = true;
            }
        }


        private void BtnVote_Click(object sender, EventArgs e)
        {
            obj.idopt = label7.Text;
            obj.idacc = Class1.IdAcc;
            obj.code = comboBox1.SelectedValue.ToString();
            if (client.KiemTraIdAcc(obj) == false)
            {
                client.ThemVote(obj);
                MessageBox.Show("Ghi nhận!!", "Thông báo");
                FrmVote_Load(sender, e);
            }
            else
            {
                if (client.KtSetFlag(obj) == false)
                {
                    client.SuaVote(obj);
                    MessageBox.Show("Đã cập nhật!!", "Thông báo");
                    FrmVote_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hết lượt Vote!!");
                }
            }
        }

        private void FrmVote_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.KtActivate(obi) == true)
            {
                client.RsActi(obi);
            }
            Application.Exit();
        }


        private void chart1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.LuotVote();

            chart1.DataSource = ds.Tables[0];
            

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Lượt Vote";

            chart1.Series["Series1"].XValueMember = "Code";
            chart1.Series["Series1"].YValueMembers = "Anwser";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
        }


        private void GridResult_Click(object sender, EventArgs e)
        {
            DataSet dd = new DataSet();
            if (Class1.Role == 1)
            {
                dd = client.DsCode1();
            }
            else
            {
                string idac = Class1.IdAcc;
                dd = client.DsCode(idac);
            }
            GridResult.DataSource = dd.Tables[0];
            GridResult.Columns[0].HeaderText = "Mã Vote";
            GridResult.Columns[1].HeaderText = "Tên người Vote";
            GridResult.Columns[2].HeaderText = "Câu trả lời";
            GridResult.Columns[3].HeaderText = "Giờ Vote";
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            FrmOption f = new FrmOption();
            this.Hide();
            f.ShowDialog();
        }
    }
}
