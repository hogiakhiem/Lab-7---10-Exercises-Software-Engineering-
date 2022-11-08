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

namespace LoginApplication
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void dataGridViewAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index < 0 || index >= dataGridViewAgents.RowCount)
            {
                return;
            }
            try
            {
                DataGridViewRow row = dataGridViewAgents.Rows[index];
                String AgentID = Convert.ToString(row.Cells[0].Value);
                String AgentName = Convert.ToString(row.Cells[1].Value);
                String Add_ress = Convert.ToString(row.Cells[3].Value);
            } catch(Exception ex)
            {
                throw new Exception("An error has occured: " + ex.Message);
            }
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = LAPTOP-5S178792; Initial Catalog = Lab7-10; Integrated Security = True";
            conn.Open();
            String ssQL = "select * from Agents";
            SqlCommand cmd = new SqlCommand(ssQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridViewAgents.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There is no data available.");
            }
        }
    }
}
