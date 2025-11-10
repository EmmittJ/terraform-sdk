using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

/// <summary>
/// Base template for generating Terraform construct classes (resources, data sources, ephemeral resources).
/// </summary>
public abstract class TerraformConstructTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private readonly string _templatePath;
    private string? _templateCache;

    protected TerraformConstructTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "TerraformConstruct.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ResourceModel model, string namespacePrefix, string baseClassName, string constructKind, string? additionalDescription = null)
    {
        var template = LoadTemplate();

        // Check if any block has validation attributes (which require MinLength/MaxLength)
        var requiresUnreferencedCode = model.BlockTypes.Any(b => b.MinItems.HasValue || b.MaxItems.HasValue);

        var data = new
        {
            Namespace = namespacePrefix,
            model.ClassName,
            model.TerraformType,
            Description = TemplateHelpers.EscapeXmlDoc(model.Description),
            model.IsDeprecated,
            RequiresUnreferencedCode = requiresUnreferencedCode,
            BaseClassName = baseClassName,
            ConstructKind = constructKind,
            AdditionalDescription = additionalDescription,
            Properties = model.Properties.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            OutputAttributes = model.OutputAttributes.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            BlockTypes = model.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList()
        };

        return Renderer.Render(template, data);
    }
}
