namespace Main
{
    static class View
    {
        public static bool InputValue(out double value)
        {
            Console.Write("Insert the value: ");
            string? valueStr = Console.ReadLine();
            Console.WriteLine();
            bool correct = double.TryParse(valueStr, out value);
            if (!correct) Console.WriteLine("Unable to read value. Incorrect input");
            return correct;
        }

        public static void OutputTestResult(string mess)
        {
            Console.WriteLine(mess);
            mess = "";
        }
    }
}