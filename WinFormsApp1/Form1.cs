namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNumField.Text == string.Empty || !int.TryParse(firstNumField.Text, out int firstN))
            {
                MessageBox.Show("Первое число введено не корректно");
                return;
            }
            if (secondNumField.Text == string.Empty || !int.TryParse(secondNumField.Text, out int secondN))
            {
                MessageBox.Show("Второе число введено не корректно");
                return;
            }
            if (!Program.TestOperation(operationField.Text) || operationField.Text == string.Empty)
            {
                MessageBox.Show("Введите операцию!\nПример:+");
                return;
            }
            if (!int.TryParse(systemNumField.Text, out int systemNum) || systemNumField.Text == string.Empty || systemNum > 49 || systemNum < 2)
            {
                MessageBox.Show("Введите систему счисления от 2-ой до 50-ой");
                return;
            }
            Form2 form = new Form2();
            form.translateNumFirst.Lines = Program.Translate(firstN, systemNum);
            form.translateNumSecond.Lines = Program.Translate(secondN, systemNum);
            this.Hide();
            form.Show();
        }

        private void firstNumField_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(firstNumField.Text, out int firstN) || firstNumField.Text == string.Empty)
            {
                errorProviderFirstNum.SetError(firstNumField, "Число введено не корректно");
            }
            else
            {
                errorProviderFirstNum.Clear();
            }
        }

        private void secondNumField_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(secondNumField.Text, out int secondN) || secondNumField.Text == string.Empty)
            {
                errorProviderSecondNum.SetError(secondNumField, "Число введено не корректно");
            }
            else
            {
                errorProviderSecondNum.Clear();
            }
        }

        private void operationField_TextChanged(object sender, EventArgs e)
        {
            if (!Program.TestOperation(operationField.Text) || operationField.Text == string.Empty)
            {
                errorProviderOperation.SetError(operationField, "Введите операцию!\nПример:+");
            }
            else
            {
                errorProviderOperation.Clear();
            }
        }

        private void systemNumField_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(systemNumField.Text, out int systemNum) || systemNumField.Text == string.Empty || systemNum > 49 || systemNum < 2)
            {
                errorProviderSystemNum.SetError(systemNumField, "Введите систему счисления от 2-ой до 50-ой");
            }
            else
            {
                errorProviderSystemNum.Clear();
            }
        }
    }
}