using System.IO;

namespace SimpleFactory.Readers
{
    public class OtherFileReader : IFileReader
    {
        public byte[] Read(Stream stream)
        {
            return new byte[0];
        }
    }
}
