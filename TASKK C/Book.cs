using System;

namespace TASKK_C
{
    internal class Book<T> where T : IComparable
    {
        private T title;
        private T isbn;
        private T author;

        // Gets or sets the book's title
        public T Title
        {
            set { title = value; }
            get { return title; }
        }

        // Gets or sets the author's name
        public T Author
        {
            set { author = value; }  // Sets the private field 'author'
            get { return author; }
        }

        // Gets or sets the book's ISBN
        public T ISBN
        {
            set { isbn = value; }
            get { return isbn; }
        }

        // Initializes a new book object with title, author, and ISBN
        public Book(T title, T author, T isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        // Implements the CompareTo method for the IComparable interface
        public int CompareTo(Object obj)
        {
            // Casts the object to a Book type
            Book<T> other = (Book<T>)obj;

            // Compares ISBN values to determine the order
            return ISBN.CompareTo(other.ISBN);
        }
    }
}
