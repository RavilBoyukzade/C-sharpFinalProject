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
using Library.Forms;

namespace Library.Forms
{
    public partial class OrderForm : Form
    {
        private readonly LibraryDbContext _context;
        private Book _selecteBook;
        private Person _selectedPerson;
        public OrderForm()
        {
            _context = new LibraryDbContext();
            
            InitializeComponent();
            FillBooks();
            FillPerson();
            FillOrder();
        }

        private void FillBooks()
        {
            var ShowBooks = _context.Books.ToList();

            foreach (var item in ShowBooks)
            {
                DgvBooks.Rows.Add(item.Id,
                                   item.BookName,
                                   item.AuthorFullName,
                                   item.Count,
                                   item.Price);
            }
        }

        private void FillPerson()
        {
            var ShowPerson = _context.Persons.ToList();
            foreach (var item in ShowPerson)
            {
                DgvPerson.Rows.Add(item.Id,
                                   item.Name,
                                   item.Surname);
                    
            }
        }

        private void FillOrder()
        {
            var ShowOrder = _context.Orders.Include("Book").Include("Person").ToList();
            foreach (var item in ShowOrder)
            {
                DgvOrder.Rows.Add(item.Id,
                                  item.Person.Name,
                                  item.Person.Surname,
                                  item.Book.BookName,
                                  DateTime.Now.ToString("MM.dd.yyyy"),
                                  item.DeadLine.ToString("MM.dd.yyyy")
                                  );
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if(DtpDeadline.Value == DateTime.Now)
            {
                MessageBox.Show("qaqa nagarasan?");
            }

            Order order = new Order
            {
                BookId = _selecteBook.Id, 
                PersonId=_selectedPerson.Id,
                OrderTime = DateTime.Now,
                DeadLine = DtpDeadline.Value
                

            };

            _context.Orders.Add(order);
            _context.SaveChanges();
            DgvOrder.Rows.Clear();
            FillOrder();

        }

        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selecteBook = _context.Books.Find(id);
        }

        private void DgvPerson_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedPerson = _context.Persons.Find(id);
        }
    }
}
