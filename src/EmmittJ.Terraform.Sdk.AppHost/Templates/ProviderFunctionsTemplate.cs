using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ProviderFunctionsTemplate(TerraformCodeGenOptions options)
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static string? _templateCache;
    private readonly string _templatePath = Path.Combine(options.TemplatesDirectory, "provider_functions.mustache");

    private string LoadTemplate()
    {
        _templateCache ??= File.ReadAllText(_templatePath);
        return _templateCache;
    }

    public string Generate(List<ProviderFunctionModel> functions, string providerName, string providerDisplayName, string providerClassName)
    {
        var template = LoadTemplate();

        var data = new
        {
            ProviderName = providerName,
            ProviderDisplayName = providerDisplayName,
            ProviderClassName = providerClassName,
            Functions = functions.Select(f => new
            {
                f.Name,
                f.TerraformName,
                Summary = TemplateHelpers.EscapeXmlDoc(f.Summary ?? ""),
                Description = TemplateHelpers.EscapeXmlDoc(f.Description ?? ""),
                f.DeprecationMessage,
                f.TerraformFunctionCall,
                f.ParameterList,
                f.ArgumentList,
                f.HasParameters,
                Parameters = f.Parameters.Select(p => new
                {
                    p.Name,
                    Description = TemplateHelpers.EscapeXmlDoc(p.Description ?? ""),
                    p.IsNullable
                }).ToList(),
                VariadicParameter = f.VariadicParameter != null ? new
                {
                    f.VariadicParameter.Name,
                    Description = TemplateHelpers.EscapeXmlDoc(f.VariadicParameter.Description ?? ""),
                    f.VariadicParameter.IsNullable
                } : null
            }).ToList()
        };

        return Renderer.Render(template, data);
    }
}
