using System;
using Microsoft.Extensions.Configuration;
using UmbracoSrcSetGenerator.Interfaces;

namespace UmbracoSrcSetGenerator.Configuration
{
    public class UmbracoSrcSetGeneratorConfig : IUmbracoSrcSetGeneratorConfig
    {
        public UmbracoSrcSetGeneratorConfig(IConfiguration configuration)
        {
            
            var defaultQualityConfig = configuration.GetValue<string>("UmbracoSrcSetGenerator:Quality");
            if (!int.TryParse(defaultQualityConfig, out int defaultQuality))
            {
                defaultQuality = 90;
            }
            DefaultQuality = defaultQuality;

            var widthStepConfig = configuration.GetValue<string>("UmbracoSrcSetGenerator:WidthStep");
            if (!int.TryParse(widthStepConfig, out int widthStep))
            {
                widthStep = 160;
            }
            WidthStep = widthStep;

            var maxWidthConfig = configuration.GetValue<string>("UmbracoSrcSetGenerator:MaxWidth");
            if (!int.TryParse(maxWidthConfig, out int maxWidth))
            {
                maxWidth = 2048;
            }
            MaxWidth = maxWidth;

            var formatConfig = configuration.GetValue<string>("UmbracoSrcSetGenerator:Format");
            Format = formatConfig ?? "auto";

            var backgroundColorConfig = configuration.GetValue<string>("UmbracoSrcSetGenerator:BackgroundColor");
            BackgroundColor = backgroundColorConfig != null && backgroundColorConfig != "false" ? backgroundColorConfig : string.Empty;

            DomainPrefix = configuration.GetValue<string>("UmbracoSrcSetGenerator:DomainPrefix");
            if (string.IsNullOrEmpty(DomainPrefix))
                DomainPrefix = null;
        }

        public string Format { get ;}
        public string BackgroundColor { get; }
        public int DefaultQuality { get ;  }
        public int MaxWidth { get; }
        public int WidthStep { get;  }
        public string DomainPrefix { get; }
    }
}
