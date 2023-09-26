using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static ADT_LAB_01.Login;

namespace ADT_LAB_01
{
    public partial class Bank : Form
    {
        public Account UserAccount { get; set; }

        public Bank()
        {
            InitializeComponent();
            EnumerationNTBX.MaxLength = 16;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label7.Text = "Номер карти: " + UserAccount.CardNumber;
            label6.Text = "Баланс: " + UserAccount.Balance.ToString("N2") + " грн";
        }

        private void EnumerationBTN_Click(object sender, EventArgs e)
        {
            string targetCardNumber = EnumerationNTBX.Text;
            if (!decimal.TryParse(EnumerationBTBX.Text, out decimal transferAmount))
            {
                MessageBox.Show("Введіть корректную суму для транзакції.");
                return;
            }
            if (UserAccount.Balance >= transferAmount)
            {
                Account recipientAccount = Login.RegisteredAccounts.Find(account => account.CardNumber == targetCardNumber);

                if (recipientAccount != null)
                {
                    UserAccount.Balance -= transferAmount;
                    recipientAccount.Balance += transferAmount;
                    UpdateBalanceLabel();
                    MessageBox.Show($"Ви успішно перевели {transferAmount} гривень на рахунок {targetCardNumber}.");
                }
                else
                {
                    MessageBox.Show("Рахунок користувача не знайден.");
                }
            }
            else
            {
                MessageBox.Show("У вас недостатньо коштів на рахунду для транзакції.");
            }
        }

        private void Information_Click(object sender, EventArgs e)
        {
            string message = $"Ім'я: {UserAccount.OwnerName}\n" +
                             $"Номер карти: {UserAccount.CardNumber}\n" +
                             $"Баланс: {UserAccount.Balance.ToString("N2")} грн\n" +
                             $"Номер телефону: {UserAccount.PhoneNumber}";

            MessageBox.Show(message, "Інформація про користувача");
        }

        private void EnrollmentBTN_Click(object sender, EventArgs e)
        {
            UserAccount.Balance += 100.0m;
            UpdateBalanceLabel();
            MessageBox.Show("Зараховано 100 гривень на ваш рахунок.");
        }

        private void BreedingBTN_Click(object sender, EventArgs e)
        {
            if (UserAccount.Balance >= 100.0m)
            {
                UserAccount.Balance -= 100.0m;
                UpdateBalanceLabel();
                MessageBox.Show("Знято 100 гривень с вашего рахунку.");
            }
            else
            {
                MessageBox.Show("У вас недостатньо коштів на рахунку для зняття.");
            }
        }

        private void UpdateBalanceLabel()
        {
            label6.Text = "Баланс: " + UserAccount.Balance.ToString("N2") + " грн";
        }
    }
}
