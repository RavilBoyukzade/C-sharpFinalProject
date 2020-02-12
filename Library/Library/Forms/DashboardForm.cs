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
using System.Data.Entity;
using System.Data.Sql;

namespace Library.Forms
{

    public partial class DashboardForm : Form
    {
        private readonly LibraryDbContext _context;
        private User _selectedUser;
        public DashboardForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
            //FillUsers();



        }

        //private void istifadəçiToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //   panel1.Show();
           
        //}

       

        //private void FillUsers()
        //{
        //    var ShowUser = _context.Users.ToList();
        //    foreach (var item in ShowUser)
        //    {
        //        DgvAddUsers.Rows.Add(item.Id,
        //                             item.Name,
        //                             item.Surname,
        //                             item.Email,
        //                             item.Password,
        //                             item.Level);
        //    }
        //}

        //private void BtnAddUser_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(TxtUserName.Text) ||
        //       !string.IsNullOrEmpty(TxtUserSurname.Text) ||
        //       !string.IsNullOrEmpty(TxtUserMail.Text) ||
        //       !string.IsNullOrEmpty(TxtUserPassword.Text))
        //    {

        //        User user = new User//add user to database
        //        {
        //            Name = TxtUserName.Text,
        //            Surname = TxtUserSurname.Text,
        //            Email = TxtUserMail.Text,
        //            Password = TxtUserPassword.Text,
        //            Level = UserLevel.Moderator,
        //            Status = true
                    
        //        };
        //        _context.Users.Add(user);
        //        _context.SaveChanges();
        //    }
        //    else { 
        //        MessageBox.Show("doldur");
        //    }
        //    DgvAddUsers.Rows.Clear();
        //    FillUsers();

        //}//User create method

        //private void BtnSearchUser_Click(object sender, EventArgs e)
        //{
        //   if(string.IsNullOrEmpty(TxtUserName.Text) &&
        //      string.IsNullOrEmpty(TxtUserSurname.Text))
        //    {
        //        MessageBox.Show("Ya Adını, ya da Soyadını daxil edin");
        //        return;
        //    }
        //    var user = _context.Users
        //                             .Where(u => u.Status && (TxtUserName.Text != string.Empty ? u.Name.Contains(TxtUserName.Text) : false) ||
        //                                                     (TxtUserSurname.Text != string.Empty ? u.Surname.Contains(TxtUserSurname.Text) : false))
        //                             .ToList();
        //    DgvAddUsers.Rows.Clear();

        //    foreach (var item in user)
        //    {
        //        DgvAddUsers.Rows.Add(item.Id,
        //                                 item.Name,
        //                                 item.Surname,
        //                                 item.Email,
        //                                 item.Password,
        //                                 item.Level
        //                                 );
        //    }
        //} //User search method

        //private void DgvAddUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int id = Convert.ToInt32(DgvAddUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

        //    _selectedUser = _context.Users.Find(id);
        //    TxtUserName.Text = _selectedUser.Name;
        //    TxtUserSurname.Text = _selectedUser.Surname;
        //    TxtUserMail.Text = _selectedUser.Email;
        //    TxtUserPassword.Text = _selectedUser.Password;


        //    BtnDelete.Show();
        //    BtnUpdate.Show();
           

        //}

        //private void BtnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("Əminsinizmi?", "Silməyə", MessageBoxButtons.YesNo);
        //    if (r == DialogResult.Yes)
        //    {
        //        _context.Users.Remove(_selectedUser);
        //        _context.SaveChanges();
        //        DgvAddUsers.Rows.Clear();
        //        FillUsers();
        //    }
           
        //}

        //private void BtnUpdate_Click(object sender, EventArgs e)
        //{
        //    DialogResult u = MessageBox.Show("Əminsinizmi?", "Dəyişiklik et?",MessageBoxButtons.YesNo);

        //    if( u == DialogResult.Yes)
        //    {
                
                


        //    }
        //}
    }
}

