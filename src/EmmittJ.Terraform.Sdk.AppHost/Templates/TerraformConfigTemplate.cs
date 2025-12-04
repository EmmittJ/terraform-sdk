using System.Collections.Concurrent;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class TerraformConfigTemplate(TerraformCodeGenOptions options)
{
    private static readonly ConcurrentDictionary<string, BaseTemplate> _templateCache = new();
    private readonly string _templatesDirectory = options.TemplatesDirectory;

    /// <summary>
    /// Simple template wrapper for TerraformConfigTemplate's per-provider templates.
    /// </summary>
    private class SimpleTemplate(string templatePath) : BaseTemplate(templatePath, usePartials: false)
    {
    }

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

        var templateInstance = _templateCache.GetOrAdd(templateFileName, _ => new SimpleTemplate(templatePath));

        var data = new
        {
            ProviderName = providerName,
            Version = version
        };

        return templateInstance.Render(data);
    }
}
