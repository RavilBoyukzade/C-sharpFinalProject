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
using ClosedXML.Excel;

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

        private void FillOrderReport()//fill orders whch retun books and return status equals to true
        {
            var ShowReport = _context.Orders
                                            .Include("Book")
                                            .Include("Person")
                                            //.Where(r => r.IsReturnd != false)
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

        private void BtnSearch_Click(object sender, EventArgs e)//search orders between two dates
        {

            var StartDate = DtpFrom.Value.Date;//start search point
            var EndaDate = DtpTo.Value.Date;//end search point
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

        private void BtnExport_Click(object sender, EventArgs e)//export datas to excell
        {
            if(DgvReportOrders.Rows.Count > 0)
            {

                try
                {

                    var workbook = new XLWorkbook();
                    var workSheet = workbook.Worksheets.Add("Hesabat sheet");
                    for(int i = 1; i < DgvReportOrders.Columns.Count; i++)
                    {
                        workSheet.Cell(1, i).SetValue(DgvReportOrders.Columns[i].HeaderText);
                        workSheet.Column(i).Width = 15; 
                    }
                    for(int i = 1; i < DgvReportOrders.Columns.Count-1; i++)
                    {
                        for(int j = 1; j < DgvReportOrders.Columns.Count; j++)
                        {
                            workSheet.Cell(i + 2, j).SetValue(DgvReportOrders.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    workbook.SaveAs(@"C:\Users\Lenovo\Desktop\Hesabat.xlsx");//way to export
                    MessageBox.Show("Excell waas created");
                }
                catch (System.IO.IOException)
                {

                    MessageBox.Show("Bu fayl açıqdı, zəhmət olmasa faylı bağlıyannan sonra bir daha təkrar edin");
                        return;
                }
                
            }
        }
    }
}
