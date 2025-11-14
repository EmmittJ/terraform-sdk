using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class ResourceTemplate : TerraformBlockTemplate
{
    public ResourceTemplate(TerraformCodeGenOptions options)
        : base(Path.Combine(options.TemplatesDirectory, "resource.mustache"))
    {
    }

    public string Generate(ResourceModel resource, string namespacePrefix)
    {
        return Generate(resource, namespacePrefix, "TerraformResource", "resource");
    }
}
