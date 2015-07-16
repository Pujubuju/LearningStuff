using System.IO;

namespace AbstractFactory.Readers
{
    public class Mp4FileReader : FileReader
    {
        public override byte[] Read(Stream stream)
        {
            return new byte[0];
        }
    }
}
