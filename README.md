# Umbraco SrcSet Generator
*It's basically [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy") for Umbraco 9, so thanks to [Jeavon](https://github.com/Jeavon "Jeavon").*

## What it is
This is a port of [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy"), the core service, for Umbraco 9.0.1. It contains almost all the functionality, except for RTE support and a couple of arguments that is not supported anymore. You would use it the same way, as you are using [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy") today. This port is made out of a combination of interest and boredome. Read below what it is not.

## What is's not
It is not a ready-to-go package. It's just the source code. Use it as it is, copy paste it to your project, or fork it and do something with it. It is NOT thoruoughly tested, but it does build. It is not 100% stand-alone, as it is a port of [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy"), so beware of the [lazysizes](https://afarkas.github.io/lazysizes/index.html "lazysizes") and [picturefill](https://github.com/scottjehl/picturefill "picturefill") scripts, or modify it yourself to work without it and suit your needs.

## How to use it
It basically works the same way as [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy"). Check the `UmbracoSrcSetGeneratorConfig.cs` file to see configuration options you can override in the `appconfig.json `of your site.
As said, the operation is dependent on [lazysizes](https://afarkas.github.io/lazysizes/index.html "lazysizes")  and [picturefill](https://github.com/scottjehl/picturefill "picturefill"), as this is just a port of [Slimsy](https://github.com/Jeavon/Slimsy "Slimsy").

**The difference**
[Slimsy](https://github.com/Jeavon/Slimsy "Slimsy") used an extension of the UrlHelper. This is a service that you can inject directly into your view. Just do `@inject UmbracoSrcSetGeneratorService srcSetGenService` or similar. 

## What can I expect in the future
Don't expect anything. I am a 9-to-5 developer, and the chance that I will ever do any more work in the repo, is very slim (heh). I am amazed I even did this in the first place. Also, if the license file is filled out wrong, let me know, I am not trying to screw anyone out of their credits. Anyway...

**Have fun!**
