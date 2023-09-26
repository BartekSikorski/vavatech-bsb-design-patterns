using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgePattern.UnitTests
{
    [TestClass]
    public class BridgeCustomerTests
    {
        [TestMethod]
        public void Copy_FakeToPdf_Should()
        {
            // Arrange
            ICustomerQuery customerService = new FakeCustomerService();
            ICustomerCommands customerTarget = new PdfCustomerTarget();

            BridgeCustomer bridgeCustomer = new BridgeCustomer(customerService, customerTarget);

            // Act
            bridgeCustomer.Copy();

            // Assert

        }
    }


    [TestClass]
    public class BluetoothRemoteControlSamsungLedTVTests
    {
        private ILedTV ledTV;
        private IRemoteControl remoteControl;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            ledTV = new SamsungLedTV();
            remoteControl = new BluetoothRemoteControl(ledTV);
        }

        [TestMethod]
        public void SwitchOn_ShouldOnTrue()
        {
            // Act
            ledTV.SwitchOn();

            //
            Assert.IsTrue(ledTV.On);
        }

        [TestMethod]
        public void SwitchOn_ShouldOnFalse()
        {
            // Act
            ledTV.SwitchOff();

            //
            Assert.IsFalse(ledTV.On);
        }

        [TestMethod]
        public void SetChannel_ShouldSetCurrentChannel()
        {
            // Act
            ledTV.SetChannel(10);

            //
            Assert.AreEqual(10, ledTV.CurrentChannel);
        }
    }
}
