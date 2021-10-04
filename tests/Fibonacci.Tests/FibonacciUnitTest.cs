using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciUnitTest
    {
        [Fact]
        public async Task Execute4ShouldReturnX()
        {
            var result = await Compute.ExecuteAsync(new[]{"6"});
            Assert.Equal(8, result[0]);
        }
    }
}