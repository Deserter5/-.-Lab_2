namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numLen.Value < 4)
            {
                MessageBox.Show("Довжина пароля має бути мінімум 4 символи!");
                return;
            }

            decimal totalPercent = numUpper.Value + numLower.Value + numDigits.Value + numSpec.Value;
            if (totalPercent != 100)
            {
                MessageBox.Show("Помилка: Сума всіх відсотків має дорівнювати 100%!");
                return;
            }

            int totalLength = (int)numLen.Value;

            string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string digitChars = "0123456789";
            string specChars = "_!;*";

            Random rnd = new Random();
            List<char> passwordList = new List<char>();

            int upperCount = (int)Math.Round((double)numUpper.Value / 100 * totalLength);
            int lowerCount = (int)Math.Round((double)numLower.Value / 100 * totalLength);
            int digitCount = (int)Math.Round((double)numDigits.Value / 100 * totalLength);
            int specCount = totalLength - upperCount - lowerCount - digitCount;

            if (upperCount < 1) { upperCount = 1; specCount--; } 
            if (lowerCount < 1) { lowerCount = 1; specCount--; }
            if (digitCount < 1) { digitCount = 1; specCount--; }
            if (specCount < 1) { specCount = 1; }

            for (int i = 0; i < upperCount; i++) passwordList.Add(upperChars[rnd.Next(upperChars.Length)]);
            for (int i = 0; i < lowerCount; i++) passwordList.Add(lowerChars[rnd.Next(lowerChars.Length)]);
            for (int i = 0; i < digitCount; i++) passwordList.Add(digitChars[rnd.Next(digitChars.Length)]);
            for (int i = 0; i < specCount; i++) passwordList.Add(specChars[rnd.Next(specChars.Length)]);

            string result = new string(passwordList.OrderBy(x => rnd.Next()).ToArray());
            txtPassword.Text = result;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numUpper_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
