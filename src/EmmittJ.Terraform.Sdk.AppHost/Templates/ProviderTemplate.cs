using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ProviderTemplate(TerraformCodeGenOptions options)
{
    private static StubbleVisitorRenderer? _renderer;
    private static Dictionary<string, string>? _partials;
    private static string? _templateCache;
    private readonly string _templatePath = Path.Combine(options.TemplatesDirectory, "provider.mustache");

    private StubbleVisitorRenderer GetRenderer()
    {
        if (_renderer == null)
        {
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

    public string Generate(ProviderConfig providerConfig)
    {
        var template = LoadTemplate();
        var renderer = GetRenderer();

        var data = new
        {
            Namespace = providerConfig.Namespace,
            ClassName = GetProviderClassName(providerConfig.Namespace),
            ProviderName = providerConfig.Name,
            Version = providerConfig.Version,
            Description = providerConfig.Description != null ? TemplateHelpers.EscapeXmlDoc(providerConfig.Description) : null,
            ResourceCount = providerConfig.ResourceCount,
            DataSourceCount = providerConfig.DataSourceCount,
            Arguments = providerConfig.Arguments.Select(p => TemplateHelpers.PreparePropertyForTemplate(p, false)).ToList()
        };

        return renderer.Render(template, data);
    }

    private static string GetProviderClassName(string namespaceName)
    {
        // Extract the last segment of the namespace and append "Provider"
        // e.g., "EmmittJ.Terraform.Sdk.Providers.Aws" -> "AwsProvider"
        // e.g., "EmmittJ.Terraform.Sdk.Providers.AzureRM" -> "AzureRMProvider"

        var lastSegment = namespaceName.Split('.').Last();
        return $"{lastSegment}Provider";
    }
}
