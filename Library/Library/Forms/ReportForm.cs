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

namespace Library.Forms
{
    public partial class ReportForm : Form
    {
        private readonly LibraryDbContext _context;
        public ReportForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillOrderReport();



        }

        private void FillOrderReport()
        {
            var ShowReport = _context.Orders
                                            .Include("Book")
                                            .Include("Person")
                                            .Where(r => r.IsReturnd != false)
                                            .ToList();

            foreach (var item in ShowReport)
            {
                DgvReportOrders.Rows.Add(item.Id,
                                         item.Person.Name,
                                         item.Person.Surname,
                                         item.Book.BookName,
                                         item.Count,
                                         item.OrderTime.ToString("dd.MM.yyyy"),
                                         item.DeadLine.ToString("dd.MM.yyyy"),
                                         item.ReturnPrice,
                                         item.ReturnTime.ToString("dd.MM.yyyy"));
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            var StartDate = DtpFrom.Value.Date;
            var EndaDate = DtpTo.Value.Date;
            DgvReportOrders.Rows.Clear();
            var ShowReport = _context.Orders
                                            .Include("Book")
                                            .Include("Person")
                                            .ToList();

            foreach (var item in ShowReport)
            {
                if(item.IsReturnd == true && StartDate <= item.ReturnTime && item.ReturnTime <= EndaDate)
                {
                    DgvReportOrders.Rows.Add(item.Id,
                                         item.Person.Name,
                                         item.Person.Surname,
                                         item.Book.BookName,
                                         item.Count,
                                         item.OrderTime.ToString("dd.MM.yyyy"),
                                         item.DeadLine.ToString("dd.MM.yyyy"),
                                         item.ReturnPrice,
                                         item.ReturnTime.ToString("dd.MM.yyyy"));
                }
            }


        }
    }
}
