using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

/// <summary>
/// Base template for generating Terraform block classes (resources, data sources, ephemeral resources).
/// </summary>
public abstract class TerraformBlockTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private readonly string _templatePath;
    private string? _templateCache;

    protected TerraformBlockTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "TerraformBlock.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ResourceModel model, string namespacePrefix, string baseClassName, string blockKind, string? additionalDescription = null)
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
            BlockKind = blockKind,
            AdditionalDescription = additionalDescription,
            IsResource = baseClassName == "TerraformResource",
            IsDataSource = baseClassName == "TerraformDataSource",
            IsEphemeralResource = baseClassName == "TerraformEphemeralResource",
            Properties = model.Properties.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            OutputAttributes = model.OutputAttributes.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            BlockTypes = model.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList()
        };

        return Renderer.Render(template, data);
    }
}
