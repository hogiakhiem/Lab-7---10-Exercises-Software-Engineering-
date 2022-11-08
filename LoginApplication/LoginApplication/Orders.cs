using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void DataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewOrders.RowCount)
            {
                return;
            }
            try
            {
                DataGridViewRow row = dataGridViewOrders.Rows[index];
                String OrderID = Convert.ToString(row.Cells[0].Value);
                String OrderDate = Convert.ToString(row.Cells[1].Value);
                String AgentID = Convert.ToString(row.Cells[3].Value);
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured: " + ex.Message);
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = LAPTOP-5S178792; Initial Catalog = Lab7-10; Integrated Security = True";
            conn.Open();
            String ssQL = "select * from Orders";
            SqlCommand cmd = new SqlCommand(ssQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrders.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There is no data available.");
            }
        }
    }
}
