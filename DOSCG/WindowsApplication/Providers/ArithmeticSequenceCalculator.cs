using System;

namespace WindowsApplication.Providers
{ 
    public class ArithmeticSequenceCalculator
    {
        private readonly Func<int, int> GeneralTerm;

        public ArithmeticSequenceCalculator(Func<int, int> generalTerm)
        {
            this.GeneralTerm = generalTerm;
        }

        public int GetValue(int N) => this.GeneralTerm(N);
    }
}
