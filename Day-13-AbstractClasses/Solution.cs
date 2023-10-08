namespace Day_13_AbstractClasses;

abstract class Book
{
    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();
}

class MyBook : Book
{
    public int price { get; set; }
    public MyBook(string title, string author, int price)
        : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}

internal class Solution
{
    static void Main(string[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}
