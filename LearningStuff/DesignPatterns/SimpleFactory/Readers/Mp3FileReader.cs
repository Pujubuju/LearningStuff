using System.IO;

namespace SimpleFactory.Readers
{
    public class Mp3FileReader : FileReader
    {
        public override byte[] Read(Stream stream)
        {
            return new byte[0];
        }
    }
}
