using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class VideoPaymentInfo : IPaymentinfo
    {
        public bool ProcessPaymentInformation()
        {
            return GenerateVideoPackagingSlip();
        }

        public bool GenerateVideoPackagingSlip()
        {
           Console.WriteLine("Generated video Packaging slip for shipping");
           return this.AddFreeVideotoPackagingSlip();
        }

        private bool AddFreeVideotoPackagingSlip()
        {
            Console.WriteLine("Added free First Aid video on Packaging slip");
            return true;
        }
    }
}
