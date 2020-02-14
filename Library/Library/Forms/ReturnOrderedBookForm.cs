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
    public partial class ReturnOrderedBookForm : Form
    {
        private readonly LibraryDbContext _context;
        private Order _selectedOrder;
        public ReturnOrderedBookForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillOrders();
        }

        private void FillOrders()
        {
            var ShowOrder = _context.Orders.Include("Book").Include("Person").ToList();
            foreach (var item in ShowOrder)
            {
                DgvOrder.Rows.Add(item.Id,
                                  item.Person.Name,
                                  item.Person.Surname,
                                  item.Book.BookName,
                                  item.Count,
                                  item.OrderTime.ToString("dd.MM.yyyy"),
                                  item.DeadLine.ToString("dd.MM.yyyy")
                                  );
            }
        }

        private void DgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedOrder = _context.Orders.Find(id);

            LblDebt.Show();
            LblLate.Show();
            TxtDebt.Show();
            TxtLate.Show();

            TxtLate.Text = (_selectedOrder.OrderTime - _selectedOrder.DeadLine).ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           

            if(string.IsNullOrEmpty(TxtPersonName.Text)&&
               string.IsNullOrEmpty(TxtPersonSurname.Text))
            {
                MessageBox.Show("Müştərinin adını və ya soyadını daxil edin");
                return;
            }

            var person = _context.Orders
                                        .Where(p => (TxtPersonName.Text !=string.Empty ? p.Person.Name.Contains(TxtPersonName.Text):false)||
                                                    (TxtPersonSurname.Text !=string.Empty ? p.Person.Surname.Contains(TxtPersonSurname.Text):false))
                                        .ToList();
            DgvOrder.Rows.Clear();

            foreach (var item in person)
            {
                DgvOrder.Rows.Add(item.Id,
                                  item.Person.Name,
                                  item.Person.Surname,
                                  item.Book.BookName,
                                  item.Count,
                                  DateTime.Now.ToString("MM.dd.yyyy"),
                                  item.DeadLine.ToString("MM.dd.yyyy"));
            }
            Reset();
        }

        private void Reset()
        {
            TxtPersonSurname.Text = " ";
            TxtPersonName.Text = " ";
            LblDebt.Hide();
            LblLate.Hide();
            TxtDebt.Hide();
            TxtLate.Hide();

        }
    }
}
