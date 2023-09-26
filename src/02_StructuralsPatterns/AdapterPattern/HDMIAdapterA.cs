using System.IO;

namespace AdapterPattern
{
    public class HDMIAdapterA : IAudioFeature, IVideoFeature
    {
        private readonly Device device = new Device();

        public HDMIAdapterA()
        {
            device.SwitchOn();
        }

        public void SendAudio(Stream audio)
        {           
            device.PlayAudio(audio);
        }

        public void SendVideo(Stream video)
        {
            device.PlayVideo(video);
        }
    }
}
