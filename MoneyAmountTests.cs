using NUnit.Framework;

namespace PrototypeCheckoutSystem
{
    public class MoneyAmountTests
    {
        [Test]
        public void CanCreateMoneyAmountWithAmout()
        {
            MoneyAmount testAmount = new MoneyAmount
            {
                Amount = 1.00m
            };
            Assert.AreEqual(1.00m, testAmount.Amount);
        }

        [Test]
        public void CanExpressMoneyAmountAsAString()
        {
            MoneyAmount testAmount = new MoneyAmount
            {
                Amount = 2.39m
            };
            Assert.AreEqual("$2.39", testAmount.ToString());
        }

        [Test]
        public void CanCreateMoneyAmountUsingConstructor()
        {
            MoneyAmount testAmount = new MoneyAmount(4.56m);
            Assert.AreEqual("$4.56", testAmount.ToString());
        }

        [Test]
        public void CanCreateMoneyAmountUsingConstructorWithOneDoubleAmount()
        {
            MoneyAmount testAmount = new MoneyAmount(4.56);

            Assert.AreEqual("$4.56", testAmount.ToString());
        }

        [Test]
        public void CanCreateMoneyAmountUsingConstructorWithNoArguments()
        {
            MoneyAmount testAmount = new MoneyAmount();
            Assert.AreEqual("$0.00", testAmount.ToString());
        }
    }
}


