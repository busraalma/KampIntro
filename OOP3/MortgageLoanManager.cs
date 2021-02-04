using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan for mortgage loan calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
