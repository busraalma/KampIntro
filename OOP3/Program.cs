using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(new ArtisanCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() 
            { 
                personalFinanceCreditManager, 
                vehicleCreditManager, 
                mortgageLoanManager
            };

            //applicationManager.CreditPreview(credits);
        }
    }
}
