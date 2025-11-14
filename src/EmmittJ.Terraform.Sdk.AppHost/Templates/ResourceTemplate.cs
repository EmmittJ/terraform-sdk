using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ResourceTemplate(TerraformCodeGenOptions options) : TerraformBlockTemplate(Path.Combine(options.TemplatesDirectory, "resource.mustache"))
{
    public string Generate(ResourceModel resource, string namespacePrefix)
    {
        return Generate(resource, namespacePrefix, "TerraformResource", "resource");
    }
}
