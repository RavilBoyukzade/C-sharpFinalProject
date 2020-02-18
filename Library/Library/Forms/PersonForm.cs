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

        private void FillPerson()//fill persons from person table to datagrid view
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

        private void BtnAdd_Click(object sender, EventArgs e)//add person to database on click
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtPersonName.Text) &&
               !string.IsNullOrEmpty(TxtPersonSurname.Text) &&
               !string.IsNullOrEmpty(TxtPersonPhone.Text) &&
               !string.IsNullOrEmpty(TxtPersonEmail.Text) &&
               DtpBirthday.Value != null)//if name,surname,phone,email,birthday boxes in not null
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
            catch (Exception)
            {

                MessageBox.Show("Nömrə yazılışı 501234567");
            }
        }

        private void DgvPerson_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select user id by clicking on datagridview row head
        {
            int id = Convert.ToInt32(DgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString());//find id of person

            _selectedPerson = _context.Persons.Find(id);

            TxtPersonName.Text = _selectedPerson.Name;//equal selected person name to name textbox
            TxtPersonSurname.Text = _selectedPerson.Surname;//equal selected person surname to surname textbox
            TxtPersonPhone.Text = _selectedPerson.PhoneNumber.ToString();//equal selected person phone to phone  textbox and convert it to string(text)
            TxtPersonEmail.Text = _selectedPerson.Email;//equal selected person mail to mail textbox
            DtpBirthday.Text = _selectedPerson.Birthday.ToString();//equal selected person birthday date to birthday textbox and convert it to string(text)

            BtnDelete.Show();
            BtnUpdate.Show();

        }

        private void BtnDelete_Click(object sender, EventArgs e)//delete persons from database
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult u = MessageBox.Show("Yeniləyim ? ", "Yenilə ? ", MessageBoxButtons.YesNo);
            if (u == DialogResult.Yes)
            {
                _selectedPerson.Name = TxtPersonName.Text;
                _selectedPerson.Surname = TxtPersonSurname.Text;
                _selectedPerson.PhoneNumber = Convert.ToInt32(TxtPersonPhone.Text);
                _selectedPerson.Email = TxtPersonEmail.Text;
                _selectedPerson.Birthday = DtpBirthday.Value;

                _context.SaveChanges();
                DgvPerson.Rows.Clear();
                FillPerson();
            }

            Reset();
        }

        private void Reset()//reset all textboxes
        {
            _selectedPerson = null;
            TxtPersonName.Text = "";
            TxtPersonSurname.Text ="";
            TxtPersonPhone.Text = "";
            TxtPersonEmail.Text ="";
            DtpBirthday.Text = "";

            BtnDelete.Hide();
            BtnUpdate.Hide();
        }

       
    }
}
