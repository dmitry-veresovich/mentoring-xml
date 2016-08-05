using System.IO;
using System.Linq;
using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    class Tests
    {
        const string LocalDir = @"E:/Workspace/mentoring-xml/Task1/";

        [Test]
        public void Test()
        {
            Directory.SetCurrentDirectory(LocalDir);

            var validator = new XsdValidator();
            var errors = validator.Validate("http://library.by/catalog", "booksSchema.xsd", "../books.xml").ToList();
            Assert.IsEmpty(errors);
        }
    }
}
