using System.IO;

namespace AbstractFactory.Readers
{
    public class AviFileReader : FileReader
    {
        public override byte[] Read(Stream stream)
        {
            return new byte[0];
        }
    }
}
