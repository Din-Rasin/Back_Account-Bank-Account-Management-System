using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back_AccountClass
{
    public partial class Form1 : Form
    {

        private decimal balance = 0; // Starting balance
        public Form1()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(depositTextBox.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    balance += amount;
                    balanceLabel.Text = $"Balance: {balance}";
                    depositTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a positive amount to deposit.", "Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for deposit.", "Invalid Input");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(withdrawTextBox.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    if (amount <= balance)
                    {
                        balance -= amount;
                        balanceLabel.Text = $"Balance: {balance}";
                        withdrawTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds for withdrawal.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a positive amount to withdraw.", "Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for withdrawal.", "Invalid Input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
