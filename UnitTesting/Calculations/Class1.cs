namespace Calculations
{
    public class Calculator
    {
        private int num1, num2, Ans;
        public Calculator(int Num1, int Num2, int ans)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
            this.Ans = ans;

        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Ans1 { get => Ans; set => Ans = value; }

        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;
        }
        public int Mul()
        {
            return Num1 * Num2;
        }

    }
}