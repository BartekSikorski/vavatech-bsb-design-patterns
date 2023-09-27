using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPattern.UnitTests
{
    [TestClass]
    public class CloudStreamTests
    {
        [TestMethod]
        public void Write_CloudStream()
        {
            // Arrange
            Stream cloudStream = new CloudStream();

            // Act
            cloudStream.Write("Here's some data");

            // Arrange

        }

        [TestMethod]
        public void Write_EncryptedCloudStream()
        {
            // Arrange
            Stream cloudStream = new EncryptedCloudStream(new CloudStream());

            // Act
            cloudStream.Write("Here's some data");

            // Arrange

        }


        [TestMethod]
        public void Write_CompressCloudStream()
        {
            // Arrange
            Stream cloudStream = new CompressedCloudStream(new CloudStream());

            // Act
            cloudStream.Write("Here's some data");

            // Arrange

        }

        //  
        [TestMethod]
        public void Write_EncryptedaAndCompressCloudStream()
        {
            // Arrange
            Stream cloudStream = new FooterCloudStream(
                new EncryptedCloudStream(
                     new CompressedCloudStream(
                         new CloudStream())));

            // Act
            cloudStream.Write("Here's some data");

            // Arrange

        }
    }
}
