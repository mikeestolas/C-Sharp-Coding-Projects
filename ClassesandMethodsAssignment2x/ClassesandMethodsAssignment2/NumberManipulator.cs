using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    public class MyDemo
    {
        public int AddNumber(int firstNumber, [Optional] int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void MainMethod()
        {
            AddNumber(12);
        }
    }
}