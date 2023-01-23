namespace Main
{
    class Test
    {
        string 
            Byte = "byte",
            Short = "short",
            Ushort = "ushort",
            Int = "int",
            Uint = "uint",
            Long = "long",
            Ulong = "ulong";

        string mess = "";

        

        void TypeOfTest(double min, double max, string type, double value)
        {
            if (value > min && value < max)
                mess += $"It is possible to explicitly convert a number to a {type} value {value}\n\n";
            else
                mess += $"To cast a number {value} of values {type}, the number cannot begreater than {max} and less than {min}\n\n";
        }

        public string ValueTest(double value)
        {
            TypeOfTest(byte.MinValue, byte.MaxValue, Byte, value);
            TypeOfTest(short.MinValue, short.MaxValue, Short, value);
            TypeOfTest(ushort.MinValue, ushort.MaxValue, Ushort, value);
            TypeOfTest(int.MinValue, int.MaxValue, Int, value);
            TypeOfTest(uint.MinValue, uint.MaxValue, Uint, value);
            TypeOfTest(long.MinValue, long.MaxValue, Long, value);
            TypeOfTest(ulong.MinValue, ulong.MaxValue, Ulong, value);
            return mess;
        }
    }
}