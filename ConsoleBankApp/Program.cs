using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApp
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string PIN { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public string PhoneNumber { get; set; }

        public Account(string cardNumber, string pin, string ownerName, decimal balance, string phoneNumber)
        {
            CardNumber = cardNumber;
            PIN = pin;
            OwnerName = ownerName;
            Balance = balance;
            PhoneNumber = phoneNumber;
        }
    }

    public class Program
    {
        public static List<Account> RegisteredAccounts { get; } = new List<Account>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            RegisteredAccounts.Add(new Account("1111222233334444", "1234", "Іван Петренко", 1000.0m, "123-456-7890"));
            RegisteredAccounts.Add(new Account("4444333322221111", "4321", "Петро Іванов", 500.0m, "987-654-3210"));

            Account userAccount = null;

            while (true)
            {
                Console.Clear();

                if (userAccount != null)
                {
                    Console.WriteLine($"Вітаємо, {userAccount.OwnerName}!");
                }
                else
                {
                    Console.WriteLine("Вас вітає Капіталіс-банк!");
                }

                if (userAccount == null)
                {
                    Console.Write("Введіть номер карти: ");
                    string enteredCardNumber = Console.ReadLine();

                    Console.Write("Введіть PIN-код: ");
                    string enteredPIN = Console.ReadLine();

                    userAccount = RegisteredAccounts.Find(account => account.CardNumber == enteredCardNumber && account.PIN == enteredPIN);

                    if (userAccount == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Невірний номер карти або PIN-код. Спробуйте ще раз.");
                        Console.ResetColor();

                        Console.WriteLine("Натисніть Enter для продовження...");
                        Console.ReadLine();
                        continue;
                    }
                }

                Console.WriteLine("\nВиберіть операцію:");
                Console.WriteLine("1. Перевести кошти");
                Console.WriteLine("2. Переглянути інформацію");
                Console.WriteLine("3. Сняти 100 гривень");
                Console.WriteLine("4. Начислить 100 гривень");
                Console.WriteLine("5. Змінити аккаунт");
                Console.WriteLine("6. Вийти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformTransfer(userAccount);
                        break;
                    case "2":
                        CheckBalance(userAccount);
                        break;
                    case "3":
                        Withdraw(userAccount);
                        break;
                    case "4":
                        Deposit(userAccount);
                        break;
                    case "5":
                        userAccount = null;
                        break;
                    case "6":
                        Console.WriteLine("Дякуємо за використання нашого банку!");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                        Console.ResetColor();

                        Console.WriteLine("Натисніть Enter для продовження...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void PerformTransfer(Account userAccount)
        {
            Console.Clear();

            Console.WriteLine($"Вітаємо, {userAccount.OwnerName}!");

            Console.Write("Введіть номер карти отримувача: ");
            string targetCardNumber = Console.ReadLine();

            Console.Write("Введіть суму для переведення: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal transferAmount))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некоректна сума для переведення.");
                Console.ResetColor();

                Console.WriteLine("Натисніть Enter для продовження...");
                Console.ReadLine();
                return;
            }

            Account recipientAccount = RegisteredAccounts.FirstOrDefault(account => account.CardNumber == targetCardNumber);

            if (recipientAccount != null)
            {
                if (userAccount.Balance >= transferAmount)
                {
                    userAccount.Balance -= transferAmount;
                    recipientAccount.Balance += transferAmount;

                    Console.WriteLine($"Ви успішно перевели {transferAmount} гривень на рахунок {recipientAccount.CardNumber}.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("У вас недостатньо коштів для переведення.");
                    Console.ResetColor();

                    Console.WriteLine("Натисніть Enter для продовження...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Рахунок отримувача не знайдено.");
                Console.ResetColor();

                Console.WriteLine("Натисніть Enter для продовження...");
                Console.ReadLine();
            }
        }

        static void CheckBalance(Account userAccount)
        {
            Console.Clear();

            Console.WriteLine($"Вітаємо, {userAccount.OwnerName}!");

            Console.WriteLine($"Номер карти: {userAccount.CardNumber}");
            Console.WriteLine($"Ім'я користувача: {userAccount.OwnerName}");
            Console.WriteLine($"Баланс: {userAccount.Balance} грн");
            Console.WriteLine($"Номер телефону: {userAccount.PhoneNumber}");

            Console.WriteLine("Натисніть Enter для продовження...");
            Console.ReadLine();
        }

        static void Withdraw(Account userAccount)
        {
            Console.Clear();

            Console.WriteLine($"Вітаємо, {userAccount.OwnerName}!");

            if (userAccount.Balance >= 100.0m)
            {
                userAccount.Balance -= 100.0m;
                Console.WriteLine("Знято 100 гривень з вашого рахунку.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас недостатньо коштів для зняття.");
                Console.ResetColor();
            }

            Console.WriteLine("Натисніть Enter для продовження...");
            Console.ReadLine();
        }

        static void Deposit(Account userAccount)
        {
            Console.Clear();

            Console.WriteLine($"Вітаємо, {userAccount.OwnerName}!");

            userAccount.Balance += 100.0m;
            Console.WriteLine("Зараховано 100 гривень на ваш рахунок.");

            Console.WriteLine("Натисніть Enter для продовження...");
            Console.ReadLine();
        }
    }
}
