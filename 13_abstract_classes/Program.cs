namespace _13_abstract_classes;

//Task
// Giving a Book class and a Solution class, write a MyBook class that does the following:

// Inherits from Book
// Has a parameterized constructor taking these 3 parameters:
// string title
// string author
// int price
// Implements the Book class' abstract display() method so it prints these 3 lines:
// Title:, a space, and then the current instance's title.
// Author:, a space, and then the current instance's author.
// Price:, a space, and then the current instance's price.
// Note: Because these classes are being written in the same file, you must not use an access modifier (e.g.: public) when declaring MyBook or your code will not execute.
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    protected int myPrice;
    public MyBook(string title, string author, int price): base(title, author)
    {
        myPrice = price;
    }
    
    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + myPrice);
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}