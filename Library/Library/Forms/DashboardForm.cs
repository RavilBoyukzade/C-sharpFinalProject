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



        private void istifadəçiYaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            UserForm uf = new UserForm();
            uf.TopLevel = false;
            PnlDashboard.Controls.Add(uf);
            uf.FormBorderStyle = FormBorderStyle.None;
            uf.Dock = DockStyle.Fill;
            uf.Show();
        }

        private void kitabYaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            BookForm bf = new BookForm();
            bf.TopLevel = false;
            PnlDashboard.Controls.Add(bf);
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            bf.Show();
        }

        private void müştəriYaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            PersonForm pf = new PersonForm();
            pf.TopLevel = false;
            PnlDashboard.Controls.Add(pf);
            pf.FormBorderStyle = FormBorderStyle.None;
            pf.Dock = DockStyle.Fill;
            pf.Show();
        }

        private void kitabTəhviliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            OrderForm of = new OrderForm();
            of.TopLevel = false;
            PnlDashboard.Controls.Add(of);
            of.FormBorderStyle = FormBorderStyle.None;
            of.Dock = DockStyle.Fill;
            of.Show();
        }

        private void kitabıQaytarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            ReturnOrderedBookForm robf = new ReturnOrderedBookForm();
            robf.TopLevel = false;
            PnlDashboard.Controls.Add(robf);
            robf.FormBorderStyle = FormBorderStyle.None;
            robf.Dock = DockStyle.Fill;
            robf.Show();
        }

        private void qecikənlərinSiyahisıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            DelayedListForm dlf = new DelayedListForm();
            dlf.TopLevel = false;
            PnlDashboard.Controls.Add(dlf);
            dlf.FormBorderStyle = FormBorderStyle.None;
            dlf.Dock = DockStyle.Fill;
            dlf.Show();
        }

        private void hesabatlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDashboard.Controls.Clear();
            ReportForm rf = new ReportForm();
            rf.TopLevel = false;
            PnlDashboard.Controls.Add(rf);
            rf.FormBorderStyle = FormBorderStyle.None;
            rf.Dock = DockStyle.Fill;
            rf.Show();
        }
    }
}

