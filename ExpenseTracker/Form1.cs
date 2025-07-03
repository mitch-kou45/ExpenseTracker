using System;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Runs when the form is first loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            LoadExpenses();
        }

        // Button click event for adding an expense
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var expense = new Expense
            {
                Description = txtDesc.Text.Trim(),
                Amount = (double)numAmount.Value,
                Date = dtpDate.Value.Date
            };

            DatabaseHelper.AddExpense(expense);
            LoadExpenses();
            ClearForm();
        }

        // Loads all expenses into the DataGridView
        private void LoadExpenses()
        {
            var expenses = DatabaseHelper.GetAllExpenses();
            dataGridViewExpenses.DataSource = null;
            dataGridViewExpenses.DataSource = expenses;

            // Optional: format DataGridView
            dataGridViewExpenses.Columns["Id"].Visible = false;
            dataGridViewExpenses.Columns["Description"].Width = 200;
            dataGridViewExpenses.Columns["Amount"].DefaultCellStyle.Format = "C2";
            dataGridViewExpenses.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        // Resets input controls
        private void ClearForm()
        {
            txtDesc.Text = "";
            numAmount.Value = 0;
            dtpDate.Value = DateTime.Today;
        }
    }
}

