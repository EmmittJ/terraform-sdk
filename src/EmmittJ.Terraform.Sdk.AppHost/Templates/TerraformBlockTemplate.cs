using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

/// <summary>
/// Base template for generating Terraform block classes (resources, data sources, ephemeral resources).
/// </summary>
public abstract class TerraformBlockTemplate(string templatePath) : BaseTemplate(templatePath, usePartials: true)
{

    public string Generate(ResourceModel model, string namespacePrefix, string baseClassName, string blockKind, string? additionalDescription = null)
    {
        // Check if any block has validation attributes (which require MinLength/MaxLength)
        var requiresUnreferencedCode = model.BlockTypes.Any(b => b.MinItems.HasValue || b.MaxItems.HasValue);

        // Combine Arguments and OutputAttributes into AllArguments - they're all just properties
        var allArguments = model.Arguments
            .Concat(model.OutputAttributes)
            .Select(p => TemplateHelpers.PreparePropertyForTemplate(p, false))
            .ToList();

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
            AllArguments = allArguments,
            BlockTypes = model.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList(),
            HasArguments = allArguments.Count > 0,
            HasBlockTypes = model.BlockTypes.Count > 0
        };

        return Render(data);
    }
}
