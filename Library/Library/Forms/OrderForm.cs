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
        private Order _selectedOrder;
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

            var ShowBooks = _context.Books.Where(b=>b.Count!=0).ToList();

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
                                  item.Count,
                                  item.OrderTime.ToString("MM.dd.yyyy"),
                                  item.DeadLine.ToString("MM.dd.yyyy")
                                  );
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
           
            if(DtpDeadline.Value > DtpTake.Value)
            {
                try
                {
                    Order order = new Order
                    {
                        BookId = _selecteBook.Id,
                        PersonId = _selectedPerson.Id,
                        Count = Convert.ToInt32(TxtBookCount.Text),
                        OrderTime = DtpTake.Value,
                        DeadLine = DtpDeadline.Value
                    };

                    _context.Orders.Add(order);
                    _selecteBook.Count -= Convert.ToInt32(TxtBookCount.Text);
                    _context.SaveChanges();
                    DgvOrder.Rows.Clear();
                    DgvBooks.Rows.Clear();
                    FillBooks();
                    FillOrder();


                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("Məlumatlar seçilməyib");
                }
                Reset();
            }
            else
            {
                MessageBox.Show("no");
            }

            
         

        }

        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selecteBook = _context.Books.Find(id);

            
               
        }

        private void DgvPerson_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(DgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString());

                 _selectedPerson = _context.Persons.Find(id);
            }
            catch (FormatException)
            {

                MessageBox.Show("Format təyin edilməyib");
            }
            
        }

        private void DgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedOrder = _context.Orders.Find(id);

        }

        private void BtnBookSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchBook.Text))
            {
                MessageBox.Show("Kitabın adını daxil edin");
                return;
            }

            var book = _context.Books
                                     .Where(b => TxtSearchBook.Text != string.Empty ? b.BookName.Contains(TxtSearchBook.Text) : false)
                                     .ToList();
            DgvBooks.Rows.Clear();

            foreach (var item in book)
            {
                DgvBooks.Rows.Add(item.Id,
                                  item.BookName,
                                  item.AuthorFullName,
                                  item.Count,
                                  item.Price);
            }
            Reset();
        }

        private void BtnPersonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchPerson.Text))
            {
                MessageBox.Show("Müştərinin adını yazın");
                    return;
            }

            var person = _context.Persons
                                         .Where(p => TxtSearchPerson.Text != string.Empty ? p.Name.Contains(TxtSearchPerson.Text) : false)
                                         .ToList();
            DgvPerson.Rows.Clear();

            foreach (var item in person)
            {
                DgvPerson.Rows.Add(item.Id, item.Name,
                                   item.Surname);
            }
            Reset();
        }

        private void Reset()
        {
            _selectedPerson = null;
            _selecteBook = null;
            DtpDeadline.Text = "";
            TxtSearchBook.Text = "";
            TxtSearchPerson.Text = "";
            TxtBookCount.Text = "";
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi silməyə?", "Silmək?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Orders.Remove(_selectedOrder);
                _context.SaveChanges();
                DgvOrder.Rows.Clear();
                DgvBooks.Rows.Clear();
                FillBooks();
                FillOrder();
                

            }
            Reset();
        }

       
    }
}
