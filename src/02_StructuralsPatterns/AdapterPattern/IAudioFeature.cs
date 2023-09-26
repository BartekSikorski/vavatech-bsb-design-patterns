using System.IO;

namespace AdapterPattern
{
    public interface IAudioFeature
    {
        void SendAudio(Stream audio);
    }
}
