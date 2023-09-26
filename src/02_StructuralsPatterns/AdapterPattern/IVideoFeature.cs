using System.IO;

namespace AdapterPattern
{
    public interface IVideoFeature
    {
        void SendVideo(Stream video);
    }
}
