using System;

public class Book
{

    int bookID;
   string title;
     string author;
     decimal price;
     int copiesAvailable;


    public Book(int bookID, string title, string author, decimal price, int copiesAvailable)
    {
        this.bookID = bookID;
        this.title = title;
        this.author = author;
        this.price = price;
        this.copiesAvailable = copiesAvailable;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Book ID: {bookID}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Copies Available: {copiesAvailable}");
    }

    
    public decimal CalculateTotalValue()
    {
        return price * copiesAvailable;
    }

}
public class exp1{
	public static void main(string[] args){
		Book b1=new Book;
		b1.Book(25,THE Book Of Nations,TEETAhook,2500.90,6);
		b1.DisplayDetails();
		b1.CalculateTotalValue();
	}
}

		


  