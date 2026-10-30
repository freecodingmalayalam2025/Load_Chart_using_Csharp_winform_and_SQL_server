using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAppLoadChart
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=LAPTOP-R9MRDLN3\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                string query = "select Name,TotalMarks from Student";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                chartstudent.Visible = true;
                chartstudent.Series.Clear();
                Series series = new Series("Total Marks");
                series.ChartType = SeriesChartType.Bar;
                series.IsValueShownAsLabel = true;

                foreach (DataRow dr in dt.Rows)
                {
                    series.Points.AddXY(dr["Name"].ToString(), dr["TotalMarks"].ToString());
                }
                series.LabelBackColor = Color.Red;

                chartstudent.Series.Add(series);
                chartstudent.Titles.Clear();
                chartstudent.Titles.Add("Student Marks Details");
                chartstudent.BackColor = Color.GreenYellow;
            }
        }
    }
}
