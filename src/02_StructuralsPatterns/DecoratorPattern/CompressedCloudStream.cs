namespace DecoratorPattern
{
    public class CompressedCloudStream : Stream
    {
        private readonly Stream stream;

        public CompressedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            stream.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }    

}
