using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADT_LAB_01
{
    public partial class Login : Form
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
        public static Account UserAccount { get; private set; }
        public static List<Account> RegisteredAccounts { get; } = new List<Account>();
        private TextBox activeTextBox;

        public Login()
        {
            InitializeComponent();


            RegisteredAccounts.Add(new Account("1111222233334444", "1234", "Іван Петренко", 1000.0m, "123-456-7890"));
            RegisteredAccounts.Add(new Account("4444333322221111", "4321", "Петро Іванов", 500.0m, "987-654-3210"));
            PinCodeTextBox.MaxLength = 4;
            CardNumberTextBox.MaxLength = 16;

            CardNumberTextBox.Enter += TextBox_Enter;
            PinCodeTextBox.Enter += TextBox_Enter;
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string enteredCardNumber = CardNumberTextBox.Text;
            string enteredPIN = PinCodeTextBox.Text;

            UserAccount = RegisteredAccounts.Find(account => account.CardNumber == enteredCardNumber);

            if (UserAccount != null && UserAccount.PIN == enteredPIN)
            {
                MessageBox.Show($"Вітаємо, {UserAccount.OwnerName}!");

                Bank form1 = new Bank();

                form1.UserAccount = UserAccount;

                form1.  Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний номер карти або PIN-код. Спробуйте ще раз.");
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }
    }
}