namespace ExpenseTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblAmount = new Label();
            lblDate = new Label();
            numAmount = new NumericUpDown();
            dtpDate = new DateTimePicker();
            btnAdd = new Button();
            dataGridViewExpense = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpense).BeginInit();
            SuspendLayout();
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(12, 69);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(70, 15);
            lblDesc.TabIndex = 0;
            lblDesc.Text = "Description:\r\n";
            lblDesc.Click += label1_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(79, 41);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(276, 74);
            txtDesc.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(21, 134);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount:";
            lblAmount.Click += label2_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 176);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date:";
            lblDate.Click += label3_Click;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(79, 132);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 4;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(79, 170);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(199, 23);
            dtpDate.TabIndex = 5;
            dtpDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Expense";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExpense
            // 
            dataGridViewExpense.AllowUserToOrderColumns = true;
            dataGridViewExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpense.Location = new Point(12, 250);
            dataGridViewExpense.Name = "dataGridViewExpense";
            dataGridViewExpense.Size = new Size(394, 211);
            dataGridViewExpense.TabIndex = 7;
            dataGridViewExpense.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 488);
            Controls.Add(dataGridViewExpense);
            Controls.Add(btnAdd);
            Controls.Add(dtpDate);
            Controls.Add(numAmount);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesc;
        private TextBox txtDesc;
        private Label lblAmount;
        private Label lblDate;
        private NumericUpDown numAmount;
        private DateTimePicker dtpDate;
        private Button btnAdd;
        private DataGridView dataGridViewExpense;
    }
}
