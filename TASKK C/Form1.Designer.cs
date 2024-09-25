namespace TASKK_C
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.BookTitle = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.BooksTextBox = new System.Windows.Forms.RichTextBox();
            this.RemoveBook = new System.Windows.Forms.Button();
            this.RemoveISBNtextBox = new System.Windows.Forms.TextBox();
            this.ISBNofBook = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(118, 71);
            this.TitletextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(86, 20);
            this.TitletextBox.TabIndex = 0;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(118, 111);
            this.authorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(86, 20);
            this.authorNameTextBox.TabIndex = 1;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(118, 149);
            this.ISBNtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(86, 20);
            this.ISBNtextBox.TabIndex = 2;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Location = new System.Drawing.Point(22, 74);
            this.BookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(58, 13);
            this.BookTitle.TabIndex = 3;
            this.BookTitle.Text = "Book Title:";
            this.BookTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(22, 114);
            this.AuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(72, 13);
            this.AuthorName.TabIndex = 4;
            this.AuthorName.Text = "Author Name:";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(22, 151);
            this.ISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(35, 13);
            this.ISBN.TabIndex = 5;
            this.ISBN.Text = "ISBN:";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(25, 193);
            this.AddBook.Margin = new System.Windows.Forms.Padding(2);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(70, 19);
            this.AddBook.TabIndex = 6;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // BooksTextBox
            // 
            this.BooksTextBox.Location = new System.Drawing.Point(345, 53);
            this.BooksTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BooksTextBox.Name = "BooksTextBox";
            this.BooksTextBox.Size = new System.Drawing.Size(326, 335);
            this.BooksTextBox.TabIndex = 7;
            this.BooksTextBox.Text = "";
            // 
            // RemoveBook
            // 
            this.RemoveBook.Location = new System.Drawing.Point(25, 320);
            this.RemoveBook.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(85, 19);
            this.RemoveBook.TabIndex = 8;
            this.RemoveBook.Text = "Remove Book";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.RemoveBook_Click);
            // 
            // RemoveISBNtextBox
            // 
            this.RemoveISBNtextBox.Location = new System.Drawing.Point(118, 279);
            this.RemoveISBNtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveISBNtextBox.Name = "RemoveISBNtextBox";
            this.RemoveISBNtextBox.Size = new System.Drawing.Size(86, 20);
            this.RemoveISBNtextBox.TabIndex = 9;
            // 
            // ISBNofBook
            // 
            this.ISBNofBook.AutoSize = true;
            this.ISBNofBook.Location = new System.Drawing.Point(22, 282);
            this.ISBNofBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBNofBook.Name = "ISBNofBook";
            this.ISBNofBook.Size = new System.Drawing.Size(75, 13);
            this.ISBNofBook.TabIndex = 10;
            this.ISBNofBook.Text = "ISBN of Book:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(70, 389);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(200, 21);
            this.sortComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sort by:";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(25, 434);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(70, 19);
            this.SortButton.TabIndex = 13;
            this.SortButton.Text = "Sort Booklist";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 484);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.ISBNofBook);
            this.Controls.Add(this.RemoveISBNtextBox);
            this.Controls.Add(this.RemoveBook);
            this.Controls.Add(this.BooksTextBox);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.TitletextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.RichTextBox BooksTextBox;
        private System.Windows.Forms.Button RemoveBook;
        private System.Windows.Forms.TextBox RemoveISBNtextBox;
        private System.Windows.Forms.Label ISBNofBook;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SortButton;
    }
}

