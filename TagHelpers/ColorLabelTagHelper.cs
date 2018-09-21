using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelpers.TagHelpers
{
    public class ColorLabelTagHelper : TagHelper
    {
        public string Color { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "coloredlabel";

            var colorStyle = $"color:{Color}";
            output.Attributes.SetAttribute("style", colorStyle);
        }
    }
}
