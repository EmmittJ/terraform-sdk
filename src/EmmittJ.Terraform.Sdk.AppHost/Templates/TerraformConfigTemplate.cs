namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class TerraformConfigTemplate(TerraformCodeGenOptions options)
{
    private static readonly Dictionary<string, BaseTemplate> _templateCache = new();
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

        if (!_templateCache.TryGetValue(templateFileName, out var templateInstance))
        {
            templateInstance = new SimpleTemplate(templatePath);
            _templateCache[templateFileName] = templateInstance;
        }

        var data = new
        {
            ProviderName = providerName,
            Version = version
        };

        return templateInstance.Render(data);
    }
}
