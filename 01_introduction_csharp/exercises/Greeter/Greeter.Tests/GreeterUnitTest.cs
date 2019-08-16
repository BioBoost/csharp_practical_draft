using System;
using Xunit;

namespace Greeter.Tests
{
    public class GreeterUnitTest
    {
        [Fact]
        public void TestGreetMethod()
        {
            Greeter greeter = new Greeter();
            Assert.Equal("Hello there. Welcome to CSharp", greeter.greet());
        }
    }
}
