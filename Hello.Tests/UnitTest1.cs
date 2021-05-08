using Xunit;
using Hello;

namespace Hello.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Hello_Returns_HelloWorld()
        {
            Assert.Equal("Hello, World!", Program.Hello());
            Assert.True(!!true);
        }
    }
}
