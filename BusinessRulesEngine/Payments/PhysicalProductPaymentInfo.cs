using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class PhysicalProductPaymentInfo : IPaymentinfo
    {
        public bool GeneratePackagingSlip()
        {
            Console.WriteLine("Generated Packaging slip for shipping successfully");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Commssion Payment to agent done successfully");
            return true;
        }

        public bool ProcessPaymentInformation()
        {
            return GeneratePackagingSlip();
        }
    }
}
