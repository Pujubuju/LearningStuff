using System.IO;

namespace SimpleFactory.Readers
{
    public abstract class FileReader : IFileReader
    {
        public abstract byte[] Read(Stream stream);
    }
}
