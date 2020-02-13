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
    public partial class PersonForm : Form
    {
        private readonly LibraryDbContext _context;
        private Person _selectedPerson;
        public PersonForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillPerson();
        }

        private void FillPerson()
        {
            var ShowPerson = _context.Persons.ToList();

            foreach (var item in ShowPerson)
            {
                DgvPerson.Rows.Add(item.Id,
                                   item.Name,
                                   item.Surname,
                                   item.PhoneNumber,
                                   item.Email,
                                   item.Birthday);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtPersonName.Text)&&
               !string.IsNullOrEmpty(TxtPersonSurname.Text)&&
               !string.IsNullOrEmpty(TxtPersonPhone.Text)&&
               !string.IsNullOrEmpty(TxtPersonEmail.Text)&&
               DtpBirthday.Value!=null)
            {
                Person person = new Person
                {
                    Name = TxtPersonName.Text,
                    Surname = TxtPersonSurname.Text,
                    PhoneNumber = Convert.ToInt32(TxtPersonPhone.Text),
                    Email = TxtPersonEmail.Text,
                    Birthday = DtpBirthday.Value
                };

                _context.Persons.Add(person);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Xanaları doldurun");
            }
           
            DgvPerson.Rows.Clear();
            FillPerson();
            Reset();
        }

        private void DgvPerson_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedPerson = _context.Persons.Find(id);

            TxtPersonName.Text = _selectedPerson.Name;
            TxtPersonSurname.Text = _selectedPerson.Surname;
            TxtPersonPhone.Text = _selectedPerson.PhoneNumber.ToString();
            TxtPersonEmail.Text = _selectedPerson.Email;
            DtpBirthday.Text = _selectedPerson.Birthday.ToString();



        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi silməyə?", "Silmək?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Persons.Remove(_selectedPerson);
                _context.SaveChanges();
                DgvPerson.Rows.Clear();
                FillPerson();
            }
            Reset();
        }

        private void Reset()
        {
            _selectedPerson = null;
            TxtPersonName.Text = "";
            TxtPersonSurname.Text ="";
            TxtPersonPhone.Text = "";
            TxtPersonEmail.Text ="";
            DtpBirthday.Text = "";
        }
    }
}
