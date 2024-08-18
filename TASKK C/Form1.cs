using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKK_C
{
    public partial class Form1 : Form
    {
        BookLinkListGen<string> bookList = new BookLinkListGen<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookTitle = TitletextBox.Text;
            string authorName = authorNameTextBox.Text;
            string isbn = ISBNtextBox.Text;

            // Validates that none of the fields are empty
            if (string.IsNullOrWhiteSpace(bookTitle) || string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(isbn))
            {
                // Shows a message box indicating that all fields must be filled
                MessageBox.Show("All fields (Title, Author, ISBN) must be filled.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exits the method to prevent adding an invalid book
            }

            // Validates that the ISBN is unique
            if (!bookList.checkISBN(isbn))
            {
                MessageBox.Show("That ISBN already exists, insert a different one please.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creates a new book and adds it to the list
            Book<string> newBook = new Book<string>(bookTitle, authorName, isbn);
            bookList.AddItem(newBook);
            bookList.Sort();
            BooksTextBox.Text = bookList.DisplayItems();
        }




        private void RemoveBook_Click(object sender, EventArgs e)
        {
            string removeBookISBN;
            if (bookList.checkISBN(RemoveISBNtextBox.Text))
            {
                MessageBox.Show("There is no book with that ISBN. Sorry.");
                return;
            }
            removeBookISBN = RemoveISBNtextBox.Text;
            bookList.RemoveItem(removeBookISBN.ToString());
            BooksTextBox.Text = bookList.DisplayItems();
        }
    }
}
