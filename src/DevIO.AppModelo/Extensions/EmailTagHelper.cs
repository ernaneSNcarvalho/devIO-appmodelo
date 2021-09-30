using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace DevIO.AppModelo.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + "appmodelo.io";
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
