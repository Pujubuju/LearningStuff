namespace Builder.Builders
{
    public class Mp4FileBuilder : FileBuilder
    {
        public override void SetHeader()
        {
            File.Header = "Mp3 file.";
        }

        public override void SetContent()
        {
            File.Content = "Mp3 file content.";
        }

        public override void SetAdditionalInfo()
        {
            File.AdditionalInfo = string.Empty;
        }
    }
}
