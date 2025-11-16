using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ProviderTemplate(TerraformCodeGenOptions options)
    : BaseTemplate(Path.Combine(options.TemplatesDirectory, "provider.mustache"), usePartials: true)
{

    public string Generate(ProviderConfig providerConfig)
    {
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

        return Render(data);
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
