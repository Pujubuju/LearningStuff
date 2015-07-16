namespace Builder.Builders
{
    public class Mp3FileBuilder : FileBuilder
    {
        public override void SetHeader()
        {
            File.Header = "Mp4 file.";
        }

        public override void SetContent()
        {
            File.Content = "Mp4 file content.";
        }

        public override void SetAdditionalInfo()
        {
            File.AdditionalInfo = "All your bases are belong to us!!! :)";
        }
    }
}
