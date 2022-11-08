using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class InformationManager : Form
    {
        public InformationManager()
        {
            InitializeComponent();
        }

        private void ButtonItems_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.ShowDialog();
        }

        private void ButtonAgents_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.ShowDialog();
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void ButtonOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetails details = new OrderDetails();
            details.ShowDialog();
        }
    }
}
