using System;
using System.Linq;

public class Smartphone : IBrowsable, ICallable
{
    private string phoneNumber;
    private string site;
    
    public string PhoneNumber
    {
        get { return this.phoneNumber; }
        set
        {
            if (value.Any(n => !char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid number!");
            }

            this.phoneNumber = value;
        }
    }

    public string Site
    {
        get { return this.site; }
        set
        {
            if (value.Any(s => char.IsDigit(s)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            this.site = value;
        }
    }

    public string Browse()
    {
        return $"Browsing: {this.Site}!";
    }

    public string Call()
    {
        return $"Calling... {this.PhoneNumber}";
    }
}