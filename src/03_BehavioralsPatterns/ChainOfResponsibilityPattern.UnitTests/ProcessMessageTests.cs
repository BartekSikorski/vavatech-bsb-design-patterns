using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Metadata;

namespace ChainOfResponsibilityPattern.UnitTests.UnitTests
{
    [TestClass]
    public class ProcessMessageTests
    {
        private MessageProcessor messageProcessor;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            string[] whiteList = new string[] { "john@domain.com", "bob@domain.com" };
            string content = "Order";

            // Konfiguracja lancucha
            IMessageHandler exceptionHandler = new ConsoleLoggerExceptionMessageHandler();
            IMessageHandler validateFromWhiteListHandler = new ValidateFromWhiteListHandler(whiteList);
            IMessageHandler validateTitleContainsHandler = new ValidateTitleContainsHandler(content);
            IMessageHandler extractTaxNumberHandler = new ExtractTaxNumberHandler();

            exceptionHandler.SetNext(validateFromWhiteListHandler);
            validateFromWhiteListHandler.SetNext(validateTitleContainsHandler);
            validateTitleContainsHandler.SetNext(extractTaxNumberHandler);

            messageProcessor = new MessageProcessor(exceptionHandler);

        }

        [TestMethod]
        public void ProcessMessage_SenderFromWhiteListWithOrder_ShouldByProcess()
        {
            Message message = new Message { From = "john@domain.com", Title = "Order #1", Body = "Lorem ipsum 953-120-45-91" };

            // Act
            var result = messageProcessor.Process(message);

            // Assert
            Assert.AreEqual("953-120-45-91", result);

        }

        [TestMethod]
        public void ProcessMessage_TitleContainsOrder_ShouldByProcess()
        {
            // Arrange
            Message message = new Message { From = "john@domain.com", Title = "Order #1", Body = "Lorem ipsum 953-120-45-91" };

            // Act
            var result = messageProcessor.Process(message);

            // Assert
            Assert.AreEqual("953-120-45-91", result);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ProcessMessage_TitleNotContainsOrder_ShouldByProcess()
        {
            // Arrange
            Message message = new Message { From = "john@domain.com", Title = "a", Body = "Lorem ipsum 953-120-45-91" };

            // Act
            var result = messageProcessor.Process(message);

            // Assert

        }

        [TestMethod]
        public void ProcessMessage_BodyContainsValidTaxNumber_ShouldReturnsTaxNumber()
        {
            // Arrange
            Message message = new Message { From = "john@domain.com", Title = "Order #1", Body = "Lorem ipsum 953-120-45-91" };

            // Act
            var result = messageProcessor.Process(message);

            // Assert
            Assert.AreEqual("953-120-45-91", result);

        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ProcessMessage_BodyContainsInvalidTaxNumber_ShouldReturnsTaxNumber()
        {
            // Arrange
            Message message = new Message { From = "john@domain.com", Title = "Order #1", Body = "Lorem ipsum 000-000-00-000" };

            // Act
            var result = messageProcessor.Process(message);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ProcessMessage_SenderFromNotWhiteListWithOrder_ShouldNotByProcess()
        {
            // Arrange
            Message message = new Message { From = "a@b.pl", Title = "Order #1" };

            // Act
            messageProcessor.Process(message);           

            // Assert

        }
    }
}
