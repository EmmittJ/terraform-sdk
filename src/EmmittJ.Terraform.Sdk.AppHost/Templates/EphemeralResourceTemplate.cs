using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class EphemeralResourceTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static string? _templateCache;
    private readonly string _templatePath;

    public EphemeralResourceTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "EphemeralResource.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ResourceModel ephemeralResource, string namespacePrefix)
    {
        var template = LoadTemplate();

        var data = new
        {
            Namespace = namespacePrefix,
            ephemeralResource.ClassName,
            ephemeralResource.TerraformType,
            Description = TemplateHelpers.EscapeXmlDoc(ephemeralResource.Description),
            ephemeralResource.IsDeprecated,
            Properties = ephemeralResource.Properties.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            OutputAttributes = ephemeralResource.OutputAttributes.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            BlockTypes = ephemeralResource.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList()
        };

        return Renderer.Render(template, data);
    }
}
