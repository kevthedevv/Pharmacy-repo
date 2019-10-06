using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
          
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button_Inventory_MouseEnter(object sender, EventArgs e)
        {
            panel_inventory.BackColor = Color.Teal;
        }

        private void button_Inventory_MouseLeave(object sender, EventArgs e)
        {
            panel_inventory.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button_Sales_MouseEnter(object sender, EventArgs e)
        {
            panel_sales.BackColor = Color.Teal;
        }

        private void button_Sales_MouseLeave(object sender, EventArgs e)
        {
            panel_sales.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button_Pos_MouseEnter(object sender, EventArgs e)
        {
            panel_pos.BackColor = Color.Teal;
        }

        private void button_Pos_MouseLeave(object sender, EventArgs e)
        {
            panel_pos.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button_Accounts_MouseEnter(object sender, EventArgs e)
        {
            panel_accounts.BackColor = Color.Teal;
        }

        private void button_Accounts_MouseLeave(object sender, EventArgs e)
        {
            panel_accounts.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
