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
            this.SuspendLayout();
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(235, 137);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(169, 31);
            this.TitletextBox.TabIndex = 0;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(235, 213);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(169, 31);
            this.authorNameTextBox.TabIndex = 1;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(235, 287);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(169, 31);
            this.ISBNtextBox.TabIndex = 2;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Location = new System.Drawing.Point(45, 143);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(114, 25);
            this.BookTitle.TabIndex = 3;
            this.BookTitle.Text = "Book Title:";
            this.BookTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(45, 219);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(143, 25);
            this.AuthorName.TabIndex = 4;
            this.AuthorName.Text = "Author Name:";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(45, 290);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(66, 25);
            this.ISBN.TabIndex = 5;
            this.ISBN.Text = "ISBN:";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(50, 372);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(140, 37);
            this.AddBook.TabIndex = 6;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // BooksTextBox
            // 
            this.BooksTextBox.Location = new System.Drawing.Point(571, 137);
            this.BooksTextBox.Name = "BooksTextBox";
            this.BooksTextBox.Size = new System.Drawing.Size(536, 469);
            this.BooksTextBox.TabIndex = 7;
            this.BooksTextBox.Text = "";
            // 
            // RemoveBook
            // 
            this.RemoveBook.Location = new System.Drawing.Point(50, 616);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(170, 37);
            this.RemoveBook.TabIndex = 8;
            this.RemoveBook.Text = "Remove Book";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.RemoveBook_Click);
            // 
            // RemoveISBNtextBox
            // 
            this.RemoveISBNtextBox.Location = new System.Drawing.Point(235, 537);
            this.RemoveISBNtextBox.Name = "RemoveISBNtextBox";
            this.RemoveISBNtextBox.Size = new System.Drawing.Size(169, 31);
            this.RemoveISBNtextBox.TabIndex = 9;
            // 
            // ISBNofBook
            // 
            this.ISBNofBook.AutoSize = true;
            this.ISBNofBook.Location = new System.Drawing.Point(45, 543);
            this.ISBNofBook.Name = "ISBNofBook";
            this.ISBNofBook.Size = new System.Drawing.Size(145, 25);
            this.ISBNofBook.TabIndex = 10;
            this.ISBNofBook.Text = "ISBN of Book:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 727);
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
    }
}

