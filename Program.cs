using System;
using System.Collections.Generic;

// Public class Book



Book reference = new Book()
{
    Author = "Samuel P. Harbison and Guy R. Steele",
    Title = "C: A Reference Manual (5th Edition) ",
    NumberOfPages = 345,
    Rating = 10,
};

Book cProgramming = new Book()
{
    Author = "The C Programming Language (2nd Edition) ",
    Title = "Brian W. Kernighan and Dennis M. Ritchie ",
    NumberOfPages = 403,
    Rating = 9,
};

Book easySteps = new Book()
{
    Author = "Mike McGrath",
    Title = "C In Easy Steps (5th Edition)",
    NumberOfPages = 320,
    Rating = 9.5,
};


List<Book> myBooks = new List<Book>();

myBooks.Add(reference);
myBooks.Add(cProgramming);
myBooks.Add(easySteps);


foreach (Book books in myBooks)
{
    Console.WriteLine($"{books.Title} {books.Author}");
}

// books.forech(book) => { Console.Writeline()}


public class Book
{
    public Book() { }
    public Book(string title, string author, int numberOfPages, double rating)
    {
        Title = title;
        Author = author;
        NumberOfPages = numberOfPages;
        Rating = rating;


    }
    public string Author { get; set; }
    public string Title { get; set; }
    public int NumberOfPages { get; set; }
    public double Rating { get; set; }
    // public string Display
    // {
    //     get { return $"{Title} by {Author}. Published on"}
    // }
};