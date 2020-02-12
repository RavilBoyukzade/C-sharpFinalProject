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
            uf.FormBorderStyle = FormBorderStyle.None;
            uf.Dock = DockStyle.Fill;
            uf.Show();

        }

        private void kitabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();           
            BookForm bf = new BookForm();
            bf.TopLevel = false;
            PnlDashboard.Controls.Add(bf);
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            bf.Show();
        }
    }
}

