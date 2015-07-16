using AbstractFactory.Common;
using AbstractFactory.Readers;

namespace AbstractFactory.Factories
{
    public class BetterFileReaderFactory
    {
        public IFileReader CreateFileReader(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Mp3:
                    {
                        return new Mp3FileReader();
                    }
                case FileType.Mp4:
                    {
                        return new Mp4FileReader();
                    }
                case FileType.Avi:
                    {
                        return new AviFileReader();
                    }
                default:
                    {
                        return new OtherFileReader();
                    }
            }
        }
    }
}
