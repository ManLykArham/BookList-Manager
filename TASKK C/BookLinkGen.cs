using System;

namespace TASKK_C
{
    internal class BookLinkGen<T> where T : IComparable
    {
        // Holds the book object
        private Book<T> book;

        // Holds the reference to the next node in the linked list
        private BookLinkGen<T> next;

        // Gets or sets the book object in this node
        public Book<T> Book
        {
            get { return book; }
            set { book = value; }
        }

        // Gets or sets the next node in the linked list
        public BookLinkGen<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        // Initializes a node with a book, setting 'next' to null
        public BookLinkGen(Book<T> item)
        {
            book = item;
            next = null;
        }

        // Initializes a node with a book and links it to another node
        public BookLinkGen(Book<T> item, BookLinkGen<T> list)
        {
            book = item;
            Next = list;
        }
    }
}
