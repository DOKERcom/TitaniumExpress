
namespace TitaniumExpress.Core.DomainModels;

public class LogMessageDomainModel
{
    public string Message { get; set; }
    public string MessageColor { get; set; }

    public BasicColors Color = new();

    public class BasicColors
    {
        public string Red = "#db7b7b";
        public string Yellow = "#dbd87b";
        public string Green = "#7bdb91";
    }
}