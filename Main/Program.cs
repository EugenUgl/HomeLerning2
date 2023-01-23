namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new();

            double value;
            bool testingImput = View.InputValue(out value);
            var testResult = test.ValueTest(value);

            if (testingImput) View.OutputTestResult(testResult);
        }
    }
}