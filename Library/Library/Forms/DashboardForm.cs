using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data;
using Library.Models;
using System.Data.Entity;
using System.Data.Sql;

namespace Library.Forms
{

    public partial class DashboardForm : Form
    {
        
        public DashboardForm()
        {

            InitializeComponent();



        }

        private void istifadəçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            UserForm uf = new UserForm();
            uf.TopLevel = false;
            PnlDashboard.Controls.Add(uf);
            uf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            uf.Dock = DockStyle.Fill;
            uf.Show();

        }

    }
}

