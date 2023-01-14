namespace FakeCalculator
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal num1, decimal num2)
        {
            return (num1 + num2);
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            throw new NotImplementedException();
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            throw new NotImplementedException();
        }

        public decimal Substract(decimal num1, decimal num2)
        {
            throw new NotImplementedException();
        }
    }
}