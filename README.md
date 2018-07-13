# Responsive Image Extension for Sitecore 9

This extension will allow you to remove inline width and height properties from images supplied by Sitecore.

## License
[MIT](/LICENSE.md)

## How to install:
- To begin, clone this repo into an existing Sitecore 9, Helix-based Solution under `/src/Foundation/Extension/ResponsiveImage`.
- Build project and ensure NuGet restores missing NuGet packages.
- Copy the contents of `/App_Config` into your primary web project alongside your existing `/App_Config` files.
- Add a reference of this project to your primary web app and rebuild the entire Solution.

## How to use:
- Whenever you use the HtmlHelper for Sitecore to display an ImageField, add `responsive = true` to your code as follows:
```C#
@Html.Sitecore().Field("Field Name", Model, new { responsive = true })
```

## Attribution:
- [Richard Seal](https://sitecore.stackexchange.com/a/1555/3838)
- [mikkelhm](https://www.mikkelhm.dk/archive/removing-width-and-height-tags-from-fieldrenderer-and-scimage/)

I originally found the Sitecore StackExchange post by Richard Seal (link above) while looking for a way to remove the inline `width` and `height` values on images produced by Sitecore's HtmlHelper in Razor. Since I use this in pretty much every Sitecore instance, I decided to make it into a module that can be easily added to any Helix-based Sitecore solution.
