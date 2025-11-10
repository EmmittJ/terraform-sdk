using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ResourceTemplate : TerraformConstructTemplate
{
    public ResourceTemplate(string templatePath) : base(templatePath)
    {
    }

    public string Generate(ResourceModel resource, string namespacePrefix)
    {
        return Generate(resource, namespacePrefix, "TerraformResource", "resource");
    }
}
