namespace Exeption_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var caculator = new Caculator();
                var result = caculator.divide(5, 0);
            }
            catch (DivideByZeroException ex) { }

            catch (ArithmeticException)
            {

                Console.WriteLine("Cannot divid by zero");
            }

            catch (Exception ex) { }

            finally { Console.WriteLine(); }


        }
    }

    internal class Caculator
    {
        public int divide(int x, int y)
        {
            return x / y;
        }
    }
}
