using Stubble.Core;
using Stubble.Core.Builders;
using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class DataSourceTemplate
{
    private static readonly StubbleVisitorRenderer Renderer = new StubbleBuilder().Build();
    private static string? _templateCache;
    private readonly string _templatePath;

    public DataSourceTemplate(string templatePath)
    {
        _templatePath = templatePath;
    }

    private string LoadTemplate()
    {
        if (_templateCache == null)
        {
            var templateFile = Path.Combine(_templatePath, "DataSource.mustache");
            _templateCache = File.ReadAllText(templateFile);
        }
        return _templateCache;
    }

    public string Generate(ResourceModel dataSource, string namespacePrefix)
    {
        var template = LoadTemplate();

        var data = new
        {
            Namespace = namespacePrefix,
            dataSource.ClassName,
            dataSource.TerraformType,
            Description = TemplateHelpers.EscapeXmlDoc(dataSource.Description),
            dataSource.IsDeprecated,
            Properties = dataSource.Properties.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            OutputAttributes = dataSource.OutputAttributes.Select(TemplateHelpers.PreparePropertyForTemplate).ToList(),
            BlockTypes = dataSource.BlockTypes.Select(TemplateHelpers.PrepareBlockTypeForTemplate).ToList()
        };

        return Renderer.Render(template, data);
    }
}
