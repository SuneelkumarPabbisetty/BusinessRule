using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine;
using BusinessRulesEngine.Constant;
using BusinessRulesEngine.Factory;
using BusinessRulesEngine.Payments;

namespace UnitTestBusinessRulesEngine
{
    [TestClass]
    public class UnitTestPaymentProcess
    {

        [TestMethod]
        public void PaymentFactory_Should_Generate_PackagingSlip_ForPhysicalProduct()
        {
            //Arrange
            int physicalProduct = PaymentTypeInformation.PhysicalProduct.GetHashCode();
            IPaymentinfo paymentObject = PaymentFactory.GetPaymentObject(physicalProduct);
            //Act
            bool result = paymentObject.ProcessPaymentInformation();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Create_DuplicatePackagingSlip_RoyaltyDep_ForBook()
        {
            //Arrange
            int book = PaymentTypeInformation.Book.GetHashCode();
            IPaymentinfo paymentObject = PaymentFactory.GetPaymentObject(book);
            //Act
            bool result = paymentObject.ProcessPaymentInformation();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_ActiavteMembership()
        {
            //Arrange
            int activate = PaymentTypeInformation.MembershipActivate.GetHashCode();
            IPaymentinfo paymentObject = PaymentFactory.GetPaymentObject(activate);
            //Act
            bool result = paymentObject.ProcessPaymentInformation();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_UpgradeMembership()
        {
            //Arrange
            int upgrade = PaymentTypeInformation.MembershipUpgrade.GetHashCode();
            IPaymentinfo paymentObject = PaymentFactory.GetPaymentObject(upgrade);
            //Act
            bool result = paymentObject.ProcessPaymentInformation();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_Generate_FreeVideoSlip()
        {
            //Arrange
            int video = PaymentTypeInformation.Video.GetHashCode();
            IPaymentinfo paymentObject = PaymentFactory.GetPaymentObject(video);
                PaymentFactory.GetPaymentObject(video);
            //Act
            bool result = paymentObject.ProcessPaymentInformation();
            //Assert
            Assert.AreEqual(result, true);
        }


    }
}
