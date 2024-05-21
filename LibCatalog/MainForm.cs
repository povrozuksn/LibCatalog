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
    public partial class MainForm : Form
    {
        private List<Book> books = new List<Book>();
        private bool cancelContextMenu = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitBookData()
        {
            books.Add(new Book("Война и мир", "Толстой Лев Николаевич", DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Толстой Лев Николаевич", DateTime.Parse("1877-01-01")));
            books.Add(new Book("Юность", "Толстой Лев Николаевич", DateTime.Parse("1857-01-01")));
            books.Add(new Book("После бала", "Толстой Лев Николаевич", DateTime.Parse("1911-01-01")));
            books.Add(new Book("Кавказкий пленник", "Толстой Лев Николаевич", DateTime.Parse("1872-01-01")));
            books.Add(new Book("Евгений Онегин", "Пушкин Александр Сергеевич", DateTime.Parse("1833-01-01")));
            books.Add(new Book("Капитанская дочка", "Пушкин Александр Сергеевич", DateTime.Parse("1833-01-01")));
            books.Add(new Book("Руслан и Людмила", "Пушкин Александр Сергеевич", DateTime.Parse("1820-01-01")));
            books.Add(new Book("Мёртвые души", "Гоголь Николай Васильевич", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Шинель", "Гоголь Николай Васильевич", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Му-Му", "Тургенев Иван Сергеевич", DateTime.Parse("1854-01-01")));
            books.Add(new Book("Ревизор", "Гоголь Николай Васильевич", DateTime.Parse("1835-01-01")));
        }

        private List<Book> FilteredBooks()
        { 
            List<Book> result = new List<Book>();
            string searchString = SearchTextBox.Text;

            if (searchString.Length == 0)
            {
                return books;
            }

            searchString = searchString.ToLower();

            foreach ( Book book in books )
            {
                if (book.Name.ToLower().Contains(searchString) || 
                    book.Author.ToLower().Contains(searchString) ||
                    book.YearPublished.Contains(searchString))
                {
                    result.Add(book);
                }
            }
            return result;             
        }

        private void FillDataGridView()
        {
            DataGridViewBooks.DataSource = null;
            DataGridViewBooks.DataSource = FilteredBooks();

            DataGridViewBooks.Columns["Name"].HeaderText = "Название";
            DataGridViewBooks.Columns["Name"].Width = 250;

            DataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            DataGridViewBooks.Columns["Author"].Width = 300;

            DataGridViewBooks.Columns["DatePublished"].HeaderText = "Дата Издания";
            DataGridViewBooks.Columns["DatePublished"].Width = 150;
            DataGridViewBooks.Columns["DatePublished"].Visible = false;

            DataGridViewBooks.Columns["YearPublished"].HeaderText = "Год Издания";
            DataGridViewBooks.Columns["YearPublished"].Width = 150;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitBookData();
            FillDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DatePublishedDateTimePicker.Value;
            DateTime date = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy"));

            Book newBook = new Book(NameTextBox.Text, AuthorTextBox.Text, date);
            books.Add(newBook);
            FillDataGridView();

            NameTextBox.Text = "";
            AuthorTextBox.Text = "";
            DatePublishedDateTimePicker.Value = DateTime.Now;

            NameTextBox.Focus();
        }

        private void DataGridViewBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            DataGridViewCell cell = DataGridViewBooks[col, row];

            object cellValue = cell.Value;

            Book book = books[row];

            switch (col)
            {
                case 0:
                    book.Name = (string)cellValue;
                    break;
                case 1:
                    book.Author = (string)cellValue;
                    break;
                case 2:
                    book.DatePublished = (DateTime)cellValue;
                    break;
            }
        }

        private void DataGridViewBooks_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hitTextInfo = DataGridViewBooks.HitTest(e.X, e.Y);
                if(hitTextInfo.RowIndex >= 0 && hitTextInfo.ColumnIndex >= 0)
                {
                    DataGridViewBooks.ClearSelection();
                    DataGridViewBooks.Rows[hitTextInfo.RowIndex].Selected = true;
                    cancelContextMenu = false;
                }
                else
                {
                    cancelContextMenu = true;
                }
            }
        }

        private void contextMenuStripForGrid_Opening(object sender, CancelEventArgs e)
        {
            if(cancelContextMenu)
            {
                e.Cancel = true;
            }
        }

        private void EditBookMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach(DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                Book book = books[rowIndex];
                EditBookForm editForm = new EditBookForm();
                editForm.EditedBook = book;
                editForm.BookUpdateEvent += editForm_BookUpdateEvent;
                editForm.ShowDialog();
            }
        }

        private void editForm_BookUpdateEvent(Book updatedBook)
        {
            FillDataGridView();
        }

        private void RemoveBookMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                Book book = books[rowIndex];

                DialogResult result = MessageBox.Show("Удалить выбранную книгу?\r\n\r\nАвтор: " + book.Author + 
                                                        "\r\nНазвание: " + book.Name + 
                                                        "\r\nГод публикации: " + book.YearPublished, "Подтвердите",
                                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    books.RemoveAt(rowIndex);
                }

                FillDataGridView();
            }
        }
    }
}
