using System.Text;
using System;

namespace TASKK_C
{
    internal class BookLinkListGen<T> where T : IComparable
    {
        // Holds the head of the linked list
        private BookLinkGen<T> BookList;

        // Adds a new book to the linked list
        public void AddItem(Book<T> item)
        {
            BookList = new BookLinkGen<T>(item, BookList);  // Adds the new book as the head of the list
        }

        // Displays all books in the linked list
        public string DisplayItems()
        {
            StringBuilder books = new StringBuilder();
            BookLinkGen<T> temp = BookList;

            // Traverses through the list and displays each book's details
            while (temp != null)
            {
                books.Append("Title: " + temp.Book.Title + " Author: " + temp.Book.Author + " ISBN: " + temp.Book.ISBN);
                books.AppendFormat("\n");
                temp = temp.Next;
            }

            return books.ToString();
        }

        // Removes a book from the linked list based on ISBN
        public void RemoveItem(string ISBNitem)
        {
            BookLinkGen<T> prev = null;
            BookLinkGen<T> curr = BookList;

            // Checks if the list is empty
            if (curr == null) return;

            // Checks if the head node has the matching ISBN
            if (ISBNitem.CompareTo(curr.Book.ISBN) == 0)
            {
                // Checks if there's only one item in the list
                if (curr.Next == null)
                {
                    BookList = null;
                }
                else
                {
                    // Updates head to the next node
                    BookList = curr.Next;
                }
                return;
            }

            // Traverses through the list to find the matching node
            while (curr != null)
            {
                if (ISBNitem.CompareTo(curr.Book.ISBN) == 0)
                {
                    // Removes the current node by updating the previous node's 'Next' pointer
                    prev.Next = curr.Next;
                    return;
                }

                prev = curr;
                curr = curr.Next;
            }
        }

        // Checks if a book with the given ISBN already exists
        public bool checkISBN(string item)
        {
            BookLinkGen<T> temp = BookList;

            // Traverses the list to find the matching ISBN
            while (temp != null)
            {
                if (item.CompareTo(temp.Book.ISBN) == 0)
                {
                    return false;  // ISBN is found
                }
                temp = temp.Next;
            }

            return true;  // ISBN is not found
        }

        // Sorts the linked list of books based on ISBN
        public void Sort()
        {
            BookLinkGen<T> temp = BookList;

            // Performs selection sort on the linked list
            while (temp != null)
            {
                BookLinkGen<T> smallValue = temp;
                BookLinkGen<T> tempList = temp.Next;

                // Finds the smallest item in the remaining list
                while (tempList != null)
                {
                    if (smallValue.Book.CompareTo(tempList.Book) > 0)
                    {
                        smallValue = tempList;
                    }
                    tempList = tempList.Next;
                }

                // Swaps the books
                Book<T> x = temp.Book;
                temp.Book = smallValue.Book;
                smallValue.Book = x;

                // Moves to the next node
                temp = temp.Next;
            }
        }
    }
}
