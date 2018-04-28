using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var commandParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = commandParts[0];
            var id = int.Parse(commandParts[1]);

            switch (command)
            {
                case "Create":
                    if (!accounts.ContainsKey(id))
                    {
                        accounts[id] = new BankAccount() { Id = id };
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }

                    break;

                case "Deposit":
                    var amount = int.Parse(commandParts[2]);

                    if (AccountExists(accounts, id))
                    {
                        accounts[id].Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine($"Account does not exist");
                    }

                    break;

                case "Withdraw":
                    amount = int.Parse(commandParts[2]);

                    if (AccountExists(accounts, id))
                    {
                        accounts[id].Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine($"Account does not exist");
                    }

                    break;

                case "Print":
                    if (AccountExists(accounts, id))
                    {
                        Console.WriteLine($"Account ID{accounts[id].Id}, balance {accounts[id].Balance:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Account does not exist");
                    }

                    break;
            }
        }
    }

    public static bool AccountExists(Dictionary<int, BankAccount> accounts, int id)
    {
        if (!accounts.ContainsKey(id))
        {
            return false;
        }

        return true;
    }
}