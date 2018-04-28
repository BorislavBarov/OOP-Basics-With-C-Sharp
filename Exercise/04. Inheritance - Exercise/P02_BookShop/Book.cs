using System;
using System.Text;

public class Book
{
    private const int MinLength = 3;

    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get { return this.title; }
        private set
        {
            if (value.Length < MinLength)
            {
                throw new ArgumentException($"{nameof(this.Title)} not valid!");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        private set
        {
            var splitValue = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (splitValue.Length == 2 && char.IsDigit(splitValue[1][0]))
            {
                throw new ArgumentException($"{nameof(this.Author)} not valid!");
            }
            
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get { return this.price; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(this.Price)} not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        
        resultBuilder
            .AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"{nameof(this.Title)}: {this.Title}")
            .AppendLine($"{nameof(this.Author)}: {this.Author}")
            .AppendLine($"{nameof(this.Price)}: {this.Price:f2}");

        var result = resultBuilder.ToString().TrimEnd();
        return result;
    }

}