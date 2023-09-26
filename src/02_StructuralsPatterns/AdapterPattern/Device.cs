using System.IO;

namespace AdapterPattern
{
    public class Device
    {
        private bool isEnabled = false;

        public void SwitchOn()
        {
            isEnabled = true;
        }

        public void PlayVideo(Stream video)
        {
            if (isEnabled)
            {

            }
        }

        public void PlayAudio(Stream audio)
        {
            if (isEnabled)
            {

            }

        }
    }
}
