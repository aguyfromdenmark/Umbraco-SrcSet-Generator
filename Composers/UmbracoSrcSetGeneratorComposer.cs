using System;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using UmbracoSrcSetGenerator.Interfaces;
using UmbracoSrcSetGenerator.Configuration;
using UmbracoSrcSetGenerator.Services;

namespace UmbracoSrcSetGenerator.Composers
{
    public class UmbracoSrcSetGeneratorComposer : IComposer
    {
        public UmbracoSrcSetGeneratorComposer()
        {
        }

        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddSingleton<IUmbracoSrcSetGeneratorConfig, UmbracoSrcSetGeneratorConfig>();
            builder.Services.AddSingleton<UmbracoSrcSetGeneratorService>();

        }
    }
}
