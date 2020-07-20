using BusinessRulesEngine.Payments;

namespace BusinessRulesEngine.Factory
{
    /// <summary>
    /// Payment object Factory
    /// More object can be added later
    /// </summary>
    public  class PaymentFactory
    {
        // Factory Method
        public static IPaymentinfo GetPaymentObject(int objType)
        {
            IPaymentinfo _IPaymentinfo;
  
            if (objType == Constant.PaymentTypeInformation.PhysicalProduct.GetHashCode())
            {
                _IPaymentinfo = new PhysicalProductPaymentInfo();
            }
            else if (objType == Constant.PaymentTypeInformation.Book.GetHashCode())
            {
                _IPaymentinfo = new BookPaymentInfo();
            }
            else if (objType == Constant.PaymentTypeInformation.MembershipActivate.GetHashCode())
            {
                _IPaymentinfo = new MembershipActivatePaymentInfo();
            }
            else if (objType == Constant.PaymentTypeInformation.MembershipUpgrade.GetHashCode())
            {
                _IPaymentinfo = new MembershipUpgradePaymentInfo();
            }
            else if (objType == Constant.PaymentTypeInformation.Video.GetHashCode())
            {
                _IPaymentinfo = new VideoPaymentInfo();
            }
            else
            {
                _IPaymentinfo = null;
            }
            return _IPaymentinfo;
        }

    }
}
