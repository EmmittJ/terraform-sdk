using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ResourceTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static string? _templateCache;
    private readonly string _templatePath;

    public ResourceTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "Resource.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ResourceModel resource, string namespacePrefix)
    {
        var template = LoadTemplate();

        var data = new
        {
            Namespace = namespacePrefix,
            resource.ClassName,
            resource.TerraformType,
            Description = TemplateHelpers.EscapeXmlDoc(resource.Description),
            resource.IsDeprecated,
            Properties = resource.Properties.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            OutputAttributes = resource.OutputAttributes.Select(TemplateHelpers.PreparePropertyForTemplate).ToList()
        };

        return Renderer.Render(template, data);
    }
}
