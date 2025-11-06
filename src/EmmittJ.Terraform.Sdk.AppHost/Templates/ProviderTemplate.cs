using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ProviderTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static string? _templateCache;
    private readonly string _templatePath;

    public ProviderTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "Provider.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ProviderConfig providerConfig)
    {
        var template = LoadTemplate();

        var data = new
        {
            Namespace = providerConfig.Namespace,
            ClassName = GetProviderClassName(providerConfig.Namespace),
            ProviderName = providerConfig.Name,
            Version = providerConfig.Version
        };

        return Renderer.Render(template, data);
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
