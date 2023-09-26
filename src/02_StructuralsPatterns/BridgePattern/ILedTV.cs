using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // Abstract Interface
    public interface IRemoteControl
    {
        void On();
        void Off();
        void SetChannel(byte number);
    }

    public abstract class RemoteControl : IRemoteControl
    {
        // Implementor
        protected ILedTV ledTV;

        protected RemoteControl(ILedTV ledTV)
        {
            this.ledTV = ledTV;
        }

        public abstract void Off();

        public abstract void On();

        public abstract void SetChannel(byte number);
    }


    // Concrete A
    public class BluetoothRemoteControl : RemoteControl
    {
        public BluetoothRemoteControl(ILedTV ledTV) : base(ledTV)
        {
        }

        public override void Off()
        {
            Console.WriteLine($"Switch Off by BT");
            ledTV.SwitchOff();
        }

        public override void On()
        {
            Console.WriteLine($"Switch On by BT");
            ledTV.SwitchOn();
        }

        public override void SetChannel(byte number)
        {
            Console.WriteLine($"Set Channel by BT");
            ledTV.SetChannel(number);
        }
    }

    public class InfraredRemoteControl : RemoteControl
    {
        public InfraredRemoteControl(ILedTV ledTV) : base(ledTV)
        {
        }

        public override void Off()
        {
            Console.WriteLine($"Switch Off by IR");
            ledTV.SwitchOff();
        }

        public override void On()
        {
            Console.WriteLine($"Switch On by IR");
            ledTV.SwitchOn();
        }

        public override void SetChannel(byte number)
        {
            Console.WriteLine($"Set Channel by IR");
            ledTV.SetChannel(number);
        }
    }

    public class HdmiRemoteControl : RemoteControl
    {
        public HdmiRemoteControl(ILedTV ledTV) : base(ledTV)
        {
        }

        public override void Off()
        {
            ledTV.SwitchOff();
        }

        public override void On()
        {
            ledTV.SwitchOn();
        }

        public override void SetChannel(byte number)
        {
            ledTV.SetChannel(number);
        }
    }

    public interface ILedTV
    {
        public bool On { get; }
        public byte CurrentChannel { get; }

        void SwitchOn();
        void SwitchOff();
        void SetChannel(byte number);
    }


    public class SamsungLedTV : ILedTV
    {
        public bool On { get; private set; }
        public byte CurrentChannel { get; private set; }

        public void SetChannel(byte number)
        {
            CurrentChannel = number;
            Console.WriteLine($"Samsung: Setting channel #{number}");
        }

        public void SwitchOff()
        {
            On = false;
            Console.WriteLine("Samsung: Switch Off");
        }

        public void SwitchOn()
        {
            On = true;
            Console.WriteLine("Samsung: Switch On");
        }
    }

    public class SonyLedTV : ILedTV
    {
        public bool IsSwitchOn { get; private set; }
        public byte SelectedChannel { get; private set; }

        public bool On => IsSwitchOn;
        public byte CurrentChannel => SelectedChannel;

        public void SetChannel(byte number)
        {
            SelectedChannel = number;
            Console.WriteLine($"Sony: Setting channel #{number}");
        }

        public void SwitchOff()
        {
            IsSwitchOn = false;
            Console.WriteLine("Sony: Switch Off");
        }

        public void SwitchOn()
        {
            IsSwitchOn = true;
            Console.WriteLine("Sony: Switch On");
        }
    }

    public class PanasonicLedTV : ILedTV
    {
        public bool On { get; set; }

        public byte CurrentChannel { get; private set; }

        public void SetChannel(byte number)
        {
            CurrentChannel = number;
        }

        public void SwitchOff()
        {
            On = false;
        }

        public void SwitchOn()
        {
            On = true;
        }
    }
}
