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

            // Populates the ComboBox with sorting options
            sortComboBox.Items.AddRange(new string[] { "Title", "Author", "ISBN" });
            sortComboBox.SelectedIndex = 2; // Default to ISBN
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
                MessageBox.Show("All fields (Title, Author, ISBN) must be filled.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            // Get the selected sorting option
            string selectedSortOption = sortComboBox.SelectedItem?.ToString() ?? "ISBN"; // Default to ISBN if no option is selected

            // Sort the book list based on the selected option
            bookList.Sort(selectedSortOption);

            // Display the updated list
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

        private void SortButton_Click(object sender, EventArgs e)
        {
            // Gets the selected sorting option from the ComboBox
            string selectedSortOption = sortComboBox.SelectedItem?.ToString() ?? "ISBN"; // Default to ISBN if nothing is selected

            // Sorts the book list based on the selected option
            bookList.Sort(selectedSortOption);

            // Refreshes the display after sorting
            BooksTextBox.Text = bookList.DisplayItems();
        }
    }
}
