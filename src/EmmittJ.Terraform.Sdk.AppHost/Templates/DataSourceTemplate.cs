using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class DataSourceTemplate : TerraformConstructTemplate
{
    public DataSourceTemplate(string templatePath) : base(templatePath)
    {
    }

    public string Generate(ResourceModel dataSource, string namespacePrefix)
    {
        return Generate(dataSource, namespacePrefix, "TerraformDataSource", "data source");
    }
}
