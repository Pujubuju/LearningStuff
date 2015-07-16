using Builder.Builders;
using Builder.Common;

namespace Builder.BuilderClients
{
    public class FilesFactory
    {
        public File CreateFile(FileBuilder builder)
        {
            builder.SetHeader();
            builder.SetContent();
            builder.SetAdditionalInfo();
            return builder.File;
        }
    }
}
