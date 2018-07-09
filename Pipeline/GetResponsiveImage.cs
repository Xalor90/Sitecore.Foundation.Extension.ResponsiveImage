using Sitecore.Pipelines.RenderField;
using System.Text.RegularExpressions;

namespace Sitecore.Foundation.Extension.ResponsiveImage.Pipeline
{
    public class GetResponsiveImage
    {
        public void Process(RenderFieldArgs args)
        {
            if (args.FieldTypeKey != "image")
            {
                return;
            }

            if (args.Parameters.ContainsKey("responsive"))
            {
                string imageTag = args.Result.FirstPart;
                imageTag = Regex.Replace(imageTag, @"(<img[^>]*?)\s+height\s*=\s*\S+", "$1", RegexOptions.IgnoreCase);
                imageTag = Regex.Replace(imageTag, @"(<img[^>]*?)\s+width\s*=\s*\S+", "$1", RegexOptions.IgnoreCase);
                imageTag = Regex.Replace(imageTag, @"(<img[^>]*?)\s+responsive\s*=\s*\S+", "$1", RegexOptions.IgnoreCase);
                args.Result.FirstPart = imageTag;
            }
        }
    }
}