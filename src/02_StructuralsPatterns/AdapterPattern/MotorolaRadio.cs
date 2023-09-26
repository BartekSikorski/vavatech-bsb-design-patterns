using System;

namespace AdapterPattern
{

    public class MotorolaRadioAdapter : ITextRadioAdapter
    {
        private readonly MotorolaRadio radio;

        private string pincode;

        public MotorolaRadioAdapter(string pincode)
        {
            radio = new MotorolaRadio();

            this.pincode = pincode;
        }

        public void SendMessage(string message, string channel)
        {
            radio.PowerOn(pincode);
            radio.SelectChannel(byte.Parse(channel));
            radio.Send(message);
            radio.PowerOff();
        }
    }

    public sealed class MotorolaRadio
    {
        private bool enabled;

        private byte? selectedChannel;

        public MotorolaRadio()
        {
            enabled = false;
        }

        public void PowerOn(string pincode)
        {
            if (pincode == "1234")
            {
                enabled = true;
            }
        }

        public void SelectChannel(byte channel)
        {
            this.selectedChannel = channel;
        }

        public void Send(string message)
        {
            if (enabled && selectedChannel!=null)
            {
                Console.WriteLine($"<Xml><Send Channel={selectedChannel}><Message>{message}</Message></xml>");
            }
        }

        public void PowerOff()
        {
            enabled = false;
        }



    }
}
