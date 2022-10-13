namespace automateWork.Models
{
    public class ConfigModel
    {
        public PropertiesConfigFolder Folder { get; set; }
    }

    public class PropertiesConfigFolder
    {
        public string pathCreateFolder { get; set; }

        public string pathToCopyFiles { get; set; }

        public string allowDecompress { get; set; }

        public string compressedFormat { get; set; }
    }
}
