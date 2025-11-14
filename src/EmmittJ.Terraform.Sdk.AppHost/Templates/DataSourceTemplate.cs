using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class DataSourceTemplate : TerraformBlockTemplate
{
    public DataSourceTemplate(TerraformCodeGenOptions options)
        : base(Path.Combine(options.TemplatesDirectory, "datasource.mustache"))
    {
    }

    public string Generate(ResourceModel dataSource, string namespacePrefix)
    {
        return Generate(dataSource, namespacePrefix, "TerraformDataSource", "data source");
    }
}
