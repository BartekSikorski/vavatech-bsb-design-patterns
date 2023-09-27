namespace DecoratorPattern
{
    public class EncryptedCloudStream : Stream
    {
        private readonly Stream stream;
        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "!@$%^%&^&^$%^#";
        }
    }

}
