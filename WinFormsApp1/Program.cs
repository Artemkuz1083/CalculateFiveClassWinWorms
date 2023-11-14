namespace WinFormsApp1
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());

        }

        public static string Calculate(int firstNum, int secondNum, string oper)
        {
            switch (oper)
            {
                case "*": return (firstNum * secondNum).ToString();
                case "+": return (firstNum + secondNum).ToString();
                case "-": return (firstNum - secondNum).ToString();
                default: return "0";
            }
        }

        public static bool TestOperation(string oper)
        {
            string[] operations = new string[] { "+", "-", "*" };
            if (operations.Contains(oper))
                return true;
            return false;
        }

        public static string[] Translate(int number, int system)
        {
            List<string> str = new List<string>();
            str.Add($"\n������� ����� {number} �� 10-�� ������� ��������� � {system}-��.");
            List<int> translateNumb = new List<int>();
            int ostatok = 0;
            int count = 0;
            str.Add($"\n����� ��������� ����� � {number} ������� ������ {system} � ���������� ��� �������, ����� ���� ����� ��������� � �������.");
            while (number > 0)
            {
                count++;
                ostatok = number % system;
                str.Add($"\n���-{count}) {number} / {system} ��������� ����� ������� {system} ��� {number - ostatok}, �������� ������� {ostatok}");
                translateNumb.Insert(0, ostatok);
                number = number / system;
            }
            str.Add($"\n���������: {string.Join("", translateNumb)}\n");
            str.Add(string.Empty);
            return str.ToArray();
        }
    }
}