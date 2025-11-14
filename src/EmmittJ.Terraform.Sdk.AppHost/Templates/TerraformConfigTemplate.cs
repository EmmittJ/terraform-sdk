using Stubble.Core;
using Stubble.Core.Builders;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class TerraformConfigTemplate(TerraformCodeGenOptions options)
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static readonly Dictionary<string, string> _templateCache = new();
    private readonly string _templatesDirectory = options.TemplatesDirectory;

    public string Generate(string providerName, string version)
    {
        var templateFileName = $"{providerName}.tf.mustache";
        var templatePath = Path.Combine(_templatesDirectory, templateFileName);

        // Check if provider-specific template exists
        if (!File.Exists(templatePath))
        {
            throw new FileNotFoundException(
                $"Terraform configuration template not found for provider '{providerName}'. " +
                $"Expected template at: {templatePath}");
        }

        if (!_templateCache.TryGetValue(templateFileName, out var template))
        {
            template = File.ReadAllText(templatePath);
            _templateCache[templateFileName] = template;
        }

        var data = new
        {
            ProviderName = providerName,
            Version = version
        };

        return Renderer.Render(template, data);
    }
}
