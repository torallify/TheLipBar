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

            Assert.Equal("\tBawse Lady - $13.00", result);
        }

        [Theory]
        [InlineData(3, "\tMan Eater - $13.00")]
        [InlineData(4, "\tKnow It All - $13.00")]
        [InlineData(5, "\tProm Queen - $13.00")]
        [InlineData(6,"\tCrown Me - $13.00")]
        [InlineData(7,"\tMinimalist - $14.00")]

        public void BasicInventoryTest(int a, string expected)
        {
            var result = Inventory.InventoryDic[a].ToString();

            Assert.Equal(expected, result);
        }
    }
}

