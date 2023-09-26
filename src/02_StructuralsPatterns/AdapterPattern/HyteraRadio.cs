using System;

namespace AdapterPattern
{


    // Abstract Adapter
    public interface ITextRadioAdapter
    {
        void SendMessage(string message, string channel);
    }

    // Abstract Adapter
    public interface IBinaryRadioAdapter
    {
        void SendFile(byte[] file, string channel);
    }

    // Concrete Adapter A
    // Wariant klasowy
    public class HyteraRadioClassAdapter : HyteraRadio, ITextRadioAdapter, IBinaryRadioAdapter
    {
        public void SendFile(byte[] file, string channel)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message, string channel)
        {
            throw new NotImplementedException();
        }

      
    }

    // Concrete Adapter A
    // Wariant obiektowy
    public class HyteraRadioAdapter : ITextRadioAdapter, IBinaryRadioAdapter
    {
        // Adaptee
        private readonly HyteraRadio radio;

        public HyteraRadioAdapter()
        {
            radio = new HyteraRadio();
        }

        public void SendFile(byte[] file, string channel)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message, string channel)
        {
            radio.Init();
            radio.SendMessage(byte.Parse(channel), message);
            radio.Release();
        }
    }

    public class HyteraRadio
    {

        private RadioStatus status;

        public void Init()
        {
            status = RadioStatus.On;
        }

        public void SendMessage(byte channel, string content)
        {
            if (status == RadioStatus.On)
            {
                Console.WriteLine($"CHANNEL {channel}, MESSAGE {content}");
            }
        }

        public void Release()
        {
            status = RadioStatus.Off;
        }

        public enum RadioStatus
        {
            On,
            Off
        }

    }
}
