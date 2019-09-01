using static System.Console;
using static System.Convert;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var next = true;

            while (next)
            {
                WriteLine("Fisrt number:");
                var value1 = ToInt32(ReadLine());
                WriteLine("Second number:");
                var value2 = ToInt32(ReadLine());

                int total;

                if (value1 > 0 && value2 > 0)
                    total = Multiply(value1, value2);
                else if (value1 < 0 && value2 < 0)
                    total = Multiply(ConvertValueForIntPositive(value1), ConvertValueForIntPositive(value2));
                else
                    total = ConvertValueForIntNegative(Multiply(ConvertValueForIntPositive(value1), ConvertValueForIntPositive(value2)));

                WriteLine($"Result of multiply: {total}");
                WriteLine();
                WriteLine("Continue? (S/N)");

                var desejaContinuar = ReadLine();

                if (desejaContinuar?.ToUpper() == "N")
                    next = false;

                Clear();
            }

            ReadKey();
        }

        public static int Multiply(int value1 = 0, int value2 = 0)
        {
            var total = 0;
            for (var i = 0; i < value2; i++)
                total += value1;
            return total;
        }

        public static int ConvertValueForIntPositive(int value)
        {
            if (value > 0)
                return value;
            return (0 - (value));
        }

        public static int ConvertValueForIntNegative(int value)
        {
            if (value < 0)
                return value;
            return (0 + (-value));
        }
    }
}
