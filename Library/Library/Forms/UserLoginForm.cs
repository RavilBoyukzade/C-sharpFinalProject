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
        static string Encrypt(string value)
        {

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }

        private readonly LibraryDbContext _context;


        public UserLoginForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Email unvani daxil edin");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrəni Daxil Edin");
                return;

            }

           User user = _context.Users.FirstOrDefault
                (u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

            if(user!=null)
            {
                
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
                               
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
        }
    }
}
