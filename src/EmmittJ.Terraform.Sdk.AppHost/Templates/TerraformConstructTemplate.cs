using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

/// <summary>
/// Base template for generating Terraform block classes (resources, data sources, ephemeral resources).
/// </summary>
public abstract class TerraformBlockTemplate(string templatePath)
{
    private static StubbleVisitorRenderer? _renderer;
    private static Dictionary<string, string>? _partials;
    private readonly string _templatePath = templatePath;
    private string? _templateCache;

    private StubbleVisitorRenderer GetRenderer()
    {
        if (_renderer == null)
        {
            // Get the directory containing the templates for partial resolution
            var templateDirectory = Path.GetDirectoryName(_templatePath) ?? throw new InvalidOperationException("Template path has no directory");
            
            // Load all partial templates
            _partials = new Dictionary<string, string>();
            foreach (var partialFile in Directory.GetFiles(templateDirectory, "_*.mustache"))
            {
                var partialName = Path.GetFileNameWithoutExtension(partialFile);
                _partials[partialName] = File.ReadAllText(partialFile);
            }
            
            _renderer = new StubbleBuilder()
                .Configure(settings =>
                {
                    settings.SetPartialTemplateLoader(new Stubble.Core.Loaders.DictionaryLoader(_partials));
                })
                .Build();
        }
        return _renderer;
    }

    private string LoadTemplate()
    {
        _templateCache ??= File.ReadAllText(_templatePath);
        return _templateCache;
    }

    public string Generate(ResourceModel model, string namespacePrefix, string baseClassName, string blockKind, string? additionalDescription = null)
    {
        var template = LoadTemplate();
        var renderer = GetRenderer();

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
            Arguments = model.Arguments.Select(p => TemplateHelpers.PreparePropertyForTemplate(p, false)).ToList(),
            OutputAttributes = model.OutputAttributes.Select(p => TemplateHelpers.PreparePropertyForTemplate(p, false)).ToList(),
            BlockTypes = model.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList()
        };

        return renderer.Render(template, data);
    }
}
