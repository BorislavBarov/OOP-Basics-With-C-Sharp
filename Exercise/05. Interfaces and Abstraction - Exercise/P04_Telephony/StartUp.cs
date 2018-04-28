using System;

public class StartUp
{
    public static void Main()
    {
        var phoneNumbers = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();

        var smartphone = new Smartphone();
        
        foreach (var phoneNumber in phoneNumbers)
        {
            try
            {
                smartphone.PhoneNumber = phoneNumber;
                Console.WriteLine(smartphone.Call());
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        foreach (var site in sites)
        {
            try
            {
                smartphone.Site = site;
                Console.WriteLine(smartphone.Browse());
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}