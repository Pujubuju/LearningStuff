using System.IO;

namespace SimpleFactory.Readers
{
    public interface IFileReader
    {
        byte[] Read(Stream stream);
    }
}