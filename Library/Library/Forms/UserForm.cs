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
    public partial class UserForm : Form
    {
        private readonly LibraryDbContext _context;
        private User _selectedUser;
        public UserForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();

            FillUsers();
        }

        private void FillUsers() // fill datagrid view from user table
        {
            var ShowUser = _context.Users.ToList();
            foreach (var item in ShowUser)
            {
                DgvAddUsers.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Email,
                                     item.Password,
                                     item.Level);
            }
            
        }


        private void BtnAddUser_Click(object sender, EventArgs e)// add users to user table
        {
            if (!string.IsNullOrEmpty(TxtUserName.Text) ||
              !string.IsNullOrEmpty(TxtUserSurname.Text) ||
              !string.IsNullOrEmpty(TxtUserMail.Text) ||
              !string.IsNullOrEmpty(TxtUserPassword.Text))
            {

                User user = new User//add user to database
                {
                    Name = TxtUserName.Text,
                    Surname = TxtUserSurname.Text,
                    Email = TxtUserMail.Text,
                    Password = TxtUserPassword.Text,
                    Level = UserLevel.Moderator,
                    Status = true

                };
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("doldur");
            }
            DgvAddUsers.Rows.Clear();// clear rows
            FillUsers();// add rows with new changes
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)//search user in my users table
        {
            if (string.IsNullOrEmpty(TxtUserName.Text) &&
              string.IsNullOrEmpty(TxtUserSurname.Text))
            {
                MessageBox.Show("Ya Adını, ya da Soyadını daxil edin");
                return;
            }
            var user = _context.Users
                                     .Where(u => u.Status && (TxtUserName.Text != string.Empty ? u.Name.Contains(TxtUserName.Text) : false) ||
                                                             (TxtUserSurname.Text != string.Empty ? u.Surname.Contains(TxtUserSurname.Text) : false))
                                     .ToList();//look if it contains my criterias
            DgvAddUsers.Rows.Clear();//clear my rows in data grid view

            foreach (var item in user) //add users to data grid view
            {
                DgvAddUsers.Rows.Add(item.Id,
                                         item.Name,
                                         item.Surname,
                                         item.Email,
                                         item.Password,
                                         item.Level
                                         );
            }
        }

        private void DgvAddUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//click on my datagrid row header
        {
            int id = Convert.ToInt32(DgvAddUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedUser = _context.Users.Find(id);//find user id
            TxtUserName.Text = _selectedUser.Name;//equals name to users name
            TxtUserSurname.Text = _selectedUser.Surname;//equals name to users surname
            TxtUserMail.Text = _selectedUser.Email;//equals name to users mail
            TxtUserPassword.Text = _selectedUser.Password;//equals name to users password

            BtnDelete.Show();// show delete button
            BtnUpdate.Show();// show update button
        }

        private void BtnDelete_Click(object sender, EventArgs e)// delete users from datagrid view
        {
            DialogResult r = MessageBox.Show("Əminsinizmi?", "Silməyə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Users.Remove(_selectedUser);//remoove user wich consist this id
                _context.SaveChanges();//save changes to serveer table
                DgvAddUsers.Rows.Clear();
                FillUsers();
            }
            Reset();//reset all textboxes
        }

        private void BtnUpdate_Click(object sender, EventArgs e)//update my users parametrs
        {
            DialogResult u = MessageBox.Show("Əminsinizmi?", "Dəyişiklik et?", MessageBoxButtons.YesNo);//ask if the user agree to update parameters

            if (u == DialogResult.Yes)//if user click yes
            {
                _selectedUser.Name = TxtUserName.Text;//equals selected user name to changes user name
                _selectedUser.Surname = TxtUserSurname.Text;//equals selected user surname to changes user surname
                _selectedUser.Email = TxtUserMail.Text;//equals selected user mail to changes user mail
                _selectedUser.Password = TxtUserPassword.Text;//equals selected Password name to changes user password



                _context.SaveChanges();
                DgvAddUsers.Rows.Clear();
                FillUsers();
                Reset();


            }
        }

        private void Reset()//reset all textboxes
        {
            _selectedUser = null;
            TxtUserName.Text = "";
            TxtUserSurname.Text = "";
            TxtUserMail.Text = "";
            TxtUserPassword.Text = "";

            BtnDelete.Hide();
            BtnUpdate.Hide();
        }
    }
}
