using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgePattern.UnitTests
{
    [TestClass]
    public class BluetoothRemoteControlSonyLedTVTests
    {
        private ILedTV ledTV;
        private IRemoteControl remoteControl;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            ledTV = new SonyLedTV();
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
