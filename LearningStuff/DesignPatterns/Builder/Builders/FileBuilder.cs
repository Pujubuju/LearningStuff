using Builder.Common;

namespace Builder.Builders
{
    public abstract class FileBuilder
    {
        public File File { get; private set; }

        protected FileBuilder()
        {
            File = new File();
        }

        public abstract void SetHeader();
        public abstract void SetContent();
        public abstract void SetAdditionalInfo();
    }
}
