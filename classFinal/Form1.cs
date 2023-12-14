namespace classFinal
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<Expense>> expenses = new Dictionary<string, List<Expense>>();
        private string expenseSummary = "";

        public Form1()
        {
            InitializeComponent();

            categoryComboBox.Items.AddRange(new string[] { "Groceries", "Rent", "Utilities", "Entertainment", "Other" });

            ViewButton.Click += ViewButton_Click;
            ClearButton.Click += ClearButton_Click;
            averageButton.Click += AverageButton_Click;

            successLabel.Visible = false;
            averageLabel.Visible = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Handle the button click synchronously
            AddButton_Click_1(sender, e);
        }


        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // Check if a category is selected
            if (string.IsNullOrWhiteSpace(categoryComboBox.Text))
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if an amount is entered
            if (string.IsNullOrWhiteSpace(amountTextBox.Text) || !double.TryParse(amountTextBox.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = descriptionTextBox.Text;
            string category = categoryComboBox.Text;

            AddExpense(category, amount, description);
            amountTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            descriptionTextBox.Clear();

            // Show a success message using a label
            successLabel.Text = "Expense added successfully.";
            successLabel.Visible = true;

            // Introduce a delay of 2 seconds (adjust as needed)
            Task.Delay(2000).Wait();

            successLabel.Visible = false;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            viewTextBox.Text = "";
            totalLabel.Text = "";

            if (expenses.Count == 0)
            {
                viewTextBox.Text = "No expenses recorded yet.";
                return;
            }

            string selectedCategory = categoryComboBox.Text;

            if (expenses.ContainsKey(selectedCategory))
            {
                ViewExpenses(selectedCategory);

                viewTextBox.Text = expenseSummary;

                double totalExpense = expenses[selectedCategory].Sum(expense => expense.Amount);
                totalLabel.Text = $"${totalExpense:F2}";

                summaryLabel.Text = $"Summary for {selectedCategory}";
            }
            else
            {
                viewTextBox.Text = $"No expenses recorded for {selectedCategory}.";
            }
        }

        private void ViewExpenses(string selectedCategory)
        {
            expenseSummary = "";

            List<Expense> expenseData = expenses[selectedCategory];

            foreach (Expense expense in expenseData)
            {
                expenseSummary += $"Amount: ${expense.Amount:F2}, Description: {expense.Description}{Environment.NewLine}";
            }
        }

        private void AddExpense(string category, double amount, string description)
        {
            Expense newExpense = new Expense { Amount = amount, Description = description };

            if (expenses.ContainsKey(category))
            {
                expenses[category].Add(newExpense);
            }
            else
            {
                expenses[category] = new List<Expense> { newExpense };
            }
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = categoryComboBox.Text;

                if (expenses.ContainsKey(selectedCategory) && expenses[selectedCategory].Count > 0)
                {
                    double totalExpense = expenses[selectedCategory].Sum(expense => expense.Amount);
                    double averageExpense = totalExpense / expenses[selectedCategory].Count;

                    averageLabel.Text = $"${averageExpense:F2}";
                }
                else
                {
                    averageLabel.Text = $"NA";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ClearButton_Click(object sender, EventArgs e)
        {
            viewTextBox.Text = "";
            totalLabel.Text = "";
            summaryLabel.Text = "";
            categoryComboBox.Text = "";
            averageLabel.Text = "";
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
        }

        private void discriptionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        public class Expense
        {
            public double Amount { get; set; }
            public string Description { get; set; }
        }
    }
}
