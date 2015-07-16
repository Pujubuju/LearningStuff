using System.IO;

namespace AbstractFactory.Readers
{
    public class OtherFileReader : IFileReader
    {
        public byte[] Read(Stream stream)
        {
            return new byte[0];
        }
    }
}
