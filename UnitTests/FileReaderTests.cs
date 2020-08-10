using Project;
using System;
using Xunit;

namespace ProjectTests
{
    public class FileReaderTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = FileReader.ExampleLoadTextFile("This is a valid file name.");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<ArgumentException>("file", () => FileReader.ExampleLoadTextFile(""));
        }
    }
}
