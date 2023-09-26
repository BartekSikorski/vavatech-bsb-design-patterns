using System;
using System.IO;

namespace AdapterPattern
{
    public class HDMIAdapterB : IVideoFeature
    {
        public void SendVideo(Stream video)
        {
            throw new NotImplementedException();
        }
    }
}
