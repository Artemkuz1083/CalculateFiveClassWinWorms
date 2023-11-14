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
            str.Add($"\nПеревод числа {number} из 10-ой системы счисления в {system}-ую.");
            List<int> translateNumb = new List<int>();
            int ostatok = 0;
            int count = 0;
            str.Add($"\nБерем ближайшее число к {number} которое кратно {system} и записываем его остаток, потом тоже самое повторяем с частным.");
            while (number > 0)
            {
                count++;
                ostatok = number % system;
                str.Add($"\nШаг-{count}) {number} / {system} ближайшее число кратное {system} это {number - ostatok}, получаем остаток {ostatok}");
                translateNumb.Insert(0, ostatok);
                number = number / system;
            }
            str.Add($"\nрезультат: {string.Join("", translateNumb)}\n");
            str.Add(string.Empty);
            return str.ToArray();
        }
    }
}