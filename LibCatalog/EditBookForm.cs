using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibCatalog
{
    public partial class EditBookForm : Form
    {
        public delegate void DelegateUpdateBook(Book updatedBook);
        public event DelegateUpdateBook BookUpdateEvent;
        public Book EditedBook { get; set; }

        public EditBookForm()
        {
            InitializeComponent();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            bookBindingSource.Add(EditedBook);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Book bookUpdated = (Book)bookBindingSource.Current;
            if (BookUpdateEvent != null)
            {
                BookUpdateEvent(bookUpdated);
            }
            Close();
        }
    }
}
