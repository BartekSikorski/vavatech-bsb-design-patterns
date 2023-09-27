namespace DecoratorPattern
{
    public class FooterCloudStream : Stream
    {
        private readonly Stream stream;

        public FooterCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            data += "|header|";

            stream.Write(data); 
        }
    }

}
