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

        private void FillBooks()//fill boks method to fill it in datagridview
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
        private void FillComboBox()//fill genres method to fill it in combobox
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

        private void BtnAddBook_Click(object sender, EventArgs e)//add books to database on click
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

       

        private void DgvBookAdd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//take given parametrs on rowheader click
        {
            int id = Convert.ToInt32(DgvBookAdd.Rows[e.RowIndex].Cells[0].Value.ToString());//take book id from datagridview
            _selectedBook = _context.Books.Find(id);//find book id in database
            TxtBookName.Text = _selectedBook.BookName;//equals selected name to name text box
            TxtBookAuthorFullName.Text = _selectedBook.AuthorFullName;//equals selected authorname to authirname text box
            TxtCount.Text = _selectedBook.Count.ToString();//equals selected count to count text box and convert it to string(text)
            TxtBookPrice.Text = _selectedBook.Price.ToString();//equals selected price to price text box and convert it to string(text)
            DtpWriteDate.Text = _selectedBook.WriteDate.ToString();//equals selected date to date text box and convert it to string(text)
            CmbGenre.Text= _selectedBook.Genre.Name;//equals selected genre to genre combobox text 

            BtnDeleteBook.Show();
            BtnUpdateBook.Show();
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)//delete books on click
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi silməyə?", "Silmək?", MessageBoxButtons.YesNo);//check if user want delete this book
            if (r == DialogResult.Yes)//if it yes
            {
                _context.Books.Remove(_selectedBook);//delete book contains selected id
                _context.SaveChanges();
                DgvBookAdd.Rows.Clear();
                 FillBooks();

            }
            Reset();
        }
        
        private void BtnUpdateBook_Click(object sender, EventArgs e)//update books on click
        {
            ComboBoxItem select = CmbGenre.SelectedItem as ComboBoxItem;
            DialogResult u = MessageBox.Show("Yeniləyim?", "Yenilə?", MessageBoxButtons.YesNo);//check if user want update this book
            if (u == DialogResult.Yes)
            {
                _selectedBook.BookName = TxtBookName.Text;//equals selected name to name text box
                _selectedBook.AuthorFullName = TxtBookAuthorFullName.Text;//equals selected authorname to authirname text box
                _selectedBook.Count = Convert.ToInt32(TxtCount.Text);//equals selected count to count text box and convert it to integer(number)
                _selectedBook.Price = Convert.ToInt32(TxtBookPrice.Text);//equals selected price to price text box and convert it to integer(number)
                _selectedBook.WriteDate = DtpWriteDate.Value;//equals selected date to date text box and convert it to datetime(date)
                _selectedBook.Genre.Name = CmbGenre.Text;//equals selected genre to genre combobox text 



                _context.SaveChanges();
                DgvBookAdd.Rows.Clear();
                FillBooks();

            }
            Reset();
        }

        public class ComboBoxItem // add text and values to combobox
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void Reset()//reset all textboxes and comboox
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

        
    }
}
