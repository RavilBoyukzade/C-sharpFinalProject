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
    
    public partial class BookForm : Form
    {
        private readonly LibraryDbContext _context;
        private Book _selectedBook;
        public BookForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillBooks();
            FillComboBox();
        }

        private void FillBooks()
        {
            var ShowBooks = _context.Books.Include("Genre").ToList();

            foreach (var item in ShowBooks)
            {
                 DgvBookAdd.Rows.Add(item.Id,
                                    item.BookName,
                                    item.AuthorFullName,
                                    item.WriteDate,
                                    item.Genre.Name,
                                    item.Count,
                                    item.Price);
            }
        }
        private void FillComboBox()
        {
            var ShowGenre = _context.Genres.ToList();
            foreach (var item in ShowGenre)
            {
                CmbGenre.Items.Add(new ComboBoxItem
                {
                    Text = item.Name,
                    Value = item.Id
                });
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {            
            ComboBoxItem select = CmbGenre.SelectedItem as ComboBoxItem;

            if (!string.IsNullOrEmpty(TxtBookName.Text) &&
                !string.IsNullOrEmpty(TxtBookAuthorFullName.Text))
            {
                Book book = new Book
                {
                    BookName = TxtBookName.Text,
                    AuthorFullName = TxtBookAuthorFullName.Text,
                    WriteDate = DtpWriteDate.Value,
                    GenreId = select.Value,
                    Count = Convert.ToInt32(TxtCount.Text),
                    Price =Convert.ToInt32(TxtBookPrice.Text) 

                };
                _context.Books.Add(book);
                _context.SaveChanges();
             }
            else
                {
                    MessageBox.Show("xanalari doldur");
                }
            DgvBookAdd.Rows.Clear();
            FillBooks();
           
        }

       

        private void DgvBookAdd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvBookAdd.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedBook = _context.Books.Find(id);
            TxtBookName.Text = _selectedBook.BookName;
            TxtBookAuthorFullName.Text = _selectedBook.AuthorFullName;
            TxtCount.Text = _selectedBook.Count.ToString();
            TxtBookPrice.Text = _selectedBook.Price.ToString();
            DtpWriteDate.Text = _selectedBook.WriteDate.ToString();
            CmbGenre.Text= _selectedBook.Genre.Name;

            BtnDeleteBook.Show();
            BtnUpdateBook.Show();
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi silməyə?", "Silmək?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();
                DgvBookAdd.Rows.Clear();
                 FillBooks();

            }
            Reset();
        }
        
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            ComboBoxItem select = CmbGenre.SelectedItem as ComboBoxItem;
            DialogResult u = MessageBox.Show("Yeniləyim?", "Yenilə?", MessageBoxButtons.YesNo);
            if (u == DialogResult.Yes)
            {
                _selectedBook.BookName = TxtBookName.Text;
                _selectedBook.AuthorFullName = TxtBookAuthorFullName.Text;
                _selectedBook.Count = Convert.ToInt32(TxtCount.Text);
                _selectedBook.Price = Convert.ToInt32(TxtBookPrice.Text);
                _selectedBook.WriteDate = DtpWriteDate.Value;
                _selectedBook.Genre.Name = CmbGenre.Text;



                _context.SaveChanges();
                DgvBookAdd.Rows.Clear();
                FillBooks();

            }
            Reset();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void Reset()
        {
            _selectedBook = null;
            TxtBookName.Text = "";
            TxtBookAuthorFullName.Text = "";
            TxtCount.Text = "";
            TxtBookPrice.Text = "";
            CmbGenre.Text = "";

            BtnDeleteBook.Hide();
            BtnUpdateBook.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
