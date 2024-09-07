namespace OOAD_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExpenseLib.ExpenseTasks.Load("expense.txt");
            dataGridView1.DataSource = ExpenseLib.ExpenseTasks.Expenses;
        }
    }
}
