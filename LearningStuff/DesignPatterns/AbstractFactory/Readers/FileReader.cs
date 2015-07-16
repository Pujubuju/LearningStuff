using System.IO;

namespace AbstractFactory.Readers
{
    public abstract class FileReader : IFileReader
    {
        public abstract byte[] Read(Stream stream);
    }
}
