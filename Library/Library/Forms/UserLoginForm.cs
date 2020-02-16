using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Library.Data;
using Library.Models;

namespace Library.Forms
{
    public partial class UserLoginForm : Form
    {

        private readonly LibraryDbContext _context; // Call database connection


        public UserLoginForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)//click on button to login
        {

            if (string.IsNullOrEmpty(TxtEmail.Text)) //check that is email is null
            {
                MessageBox.Show("Email unvani daxil edin");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))// check that password is null
            {
                MessageBox.Show("Şifrəni Daxil Edin");
                return;

            }

           User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text); 
              

            if(user!=null)
            {
                
                DashboardForm dashboard = new DashboardForm();
                this.Hide();
                dashboard.Show();
                


                return;
            }

            MessageBox.Show("E-poçt və ya şifrə yalnışdır");

            
        }

        private void UserLoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                BtnLogIn_Click(BtnLogIn,null);
            }
        }//catch enter press key 

      
    }
}
