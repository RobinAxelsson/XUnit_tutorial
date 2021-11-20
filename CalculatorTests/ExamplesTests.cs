using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name");
            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<ArgumentException>(typeof(Examples).GetMethod(nameof(Examples.ExampleLoadTextFile)).GetParameters().First().Name, () => Examples.ExampleLoadTextFile(""));
        }
    }
}
