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
    public partial class TestChart : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        ServiceReference1.Vote obj = new ServiceReference1.Vote();

        public TestChart()
        {
            InitializeComponent();
        }

        private void TestChart_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.LuotVote();

            chart1.DataSource = ds.Tables[0];

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Nhóm";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "SL";

            chart1.Series["Series1"].XValueMember = "Code";
            chart1.Series["Series1"].YValueMembers = "Anwser";
        }
    }
}
