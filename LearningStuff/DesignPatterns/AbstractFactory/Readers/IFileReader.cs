using System.IO;

namespace AbstractFactory.Readers
{
    public interface IFileReader
    {
        byte[] Read(Stream stream);
    }
}