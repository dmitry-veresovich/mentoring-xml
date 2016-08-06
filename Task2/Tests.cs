using System.IO;
using System.Xml.Xsl;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    public class Tests
    {
        const string LocalDir = @"E:/Workspace/mentoring-xml/Task2/";

        [Test]
        public void Run()
        {
            Directory.SetCurrentDirectory(LocalDir);

            var xsl = new XslCompiledTransform();
            xsl.Load("rss.xslt");
            xsl.Transform("../books.xml", "rss.xml");
        }
    }
}
