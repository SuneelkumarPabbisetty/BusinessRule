﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class MembershipUpgradePaymentInfo : IPaymentinfo
    {

        public bool UpgardeMembership()
        {
            Console.WriteLine("Membership upgraded successfully");
            return this.EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
             Console.WriteLine( "e-mail sent to the owner for Membership Upgraded");
             return true;
        }


        public bool ProcessPaymentInformation()
        {
            return UpgardeMembership();
        }
    }
}
