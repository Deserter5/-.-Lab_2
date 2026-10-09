namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            if (int.TryParse(txtNumber.Text, out int n))
            {
                if (n == 0)
                {
                    MessageBox.Show("Для нуля дільники не визначаються.");
                    return;
                }

                int absN = Math.Abs(n);
                for (int i = -absN; i <= absN; i++)
                {
                    if (i != 0 && n % i == 0)
                    {
                        lstResults.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть число!");
            }
        }
    }
}
