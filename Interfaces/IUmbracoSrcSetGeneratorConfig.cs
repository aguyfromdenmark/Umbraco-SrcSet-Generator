using System;
namespace UmbracoSrcSetGenerator.Interfaces
{
    public interface IUmbracoSrcSetGeneratorConfig
    {
        string Format { get;  }
        string BackgroundColor { get;  }
        int DefaultQuality { get;  }
        int MaxWidth { get;  }
        int WidthStep { get;  }
        string DomainPrefix { get; }
    }
}
