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
    public partial class DelayedListForm : Form
    {
        private readonly LibraryDbContext _context;

        public DelayedListForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
            FillDelayedList();
        }

        private void FillDelayedList()//add delayed users to my datagridview
        {
            var DelayedShow = _context.Orders.
                                              Include("Book").
                                              Include("Person").
                                              Where(d => d.DeadLine < DateTime.Now).//add orders wich less than datetime now
                                              ToList();
            foreach (var item in DelayedShow)
            {
                DgvDelayed.Rows.Add(item.Id,
                                    item.Person.Name,
                                    item.Person.Surname,
                                    item.Person.PhoneNumber,
                                    item.OrderTime.ToString("dd.MM.yyyy"),
                                    item.DeadLine.ToString("dd.MM.yyyy"));
            }
        }
    }
}
