namespace C_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numeria data type
            /*  int age = -33;
                Console.WriteLine(age);
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);

                long bigNumber = -900000000L;
                Console.WriteLine(bigNumber);
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);

                double negative = -55.2D;
                Console.WriteLine(negative);
                Console.WriteLine(double.MaxValue);
                Console.WriteLine(double.MinValue);

                float precision = 5.000001F;
                Console.WriteLine(precision);
                Console.WriteLine(float.MaxValue);
                Console.WriteLine(float.MinValue);

                decimal money = 14.99M;
                Console.WriteLine(money);
                Console.WriteLine(decimal.MaxValue);
                Console.WriteLine(decimal.MinValue);*/

            //Data type

            /*string name = "Fakhara ";
            char letter = 'F';
            Console.Write("Youe name is ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(letter);*/

            //string convert to int,long,double, float and decimal

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
        }
    }
}