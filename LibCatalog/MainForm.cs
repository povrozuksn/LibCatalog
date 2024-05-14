﻿using System;
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
    }
}