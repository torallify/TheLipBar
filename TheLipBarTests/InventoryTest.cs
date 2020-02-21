using Xunit;
using TheLipBar;

namespace TheLipBarTests
{
    public class InventoryTest
    {
        [Fact]
        public void BawseLadyCheck()
        {
            var result = Inventory.InventoryDic[1].ToString();

            Assert.Equal("Bawse Lady - $13.00", result);
        }

        [Theory]
        [InlineData(2, "Man Eater - $13.00")]
        [InlineData(3, "Know It All - $13.00")]
        [InlineData(4, "Prom Queen - $13.00")]
        [InlineData(5,"Crown Me - $13.00")]
        [InlineData(6,"Minimalist - $14.00")]

        public void BasicInventoryTest(int a, string expected)
        {
            var result = Inventory.InventoryDic[a].ToString();

            Assert.Equal(expected, result);
        }
    }
}

