using Xunit;
using TheLipBar;

namespace TheLipBarTests
{
    public class CashOutTest
    {
<<<<<<< HEAD
=======
        [Fact]
        public void SubtotalCheck1()
        {
            ShoppingCart.UserCart[1] = 1;

            double result = CashOut.Subtotal();

            Assert.Equal(13.00, result);
        }

        [Fact]
        public void TaxCheck()
        {
            ShoppingCart.UserCart[1] = 1;
            
            double result = CashOut.Tax();

            Assert.Equal(.78, result);
        }

        [Fact]
        public void TotalCheck()
        {
            ShoppingCart.UserCart[1] = 1;

            double result = CashOut.Total();

            Assert.Equal(13.78, result);
        }
>>>>>>> 40a3aafd43b10e6c767967b6d253bc971623fa29

    }
}
