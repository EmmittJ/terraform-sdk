using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public class EphemeralResourceTemplate : TerraformBlockTemplate
{
    public EphemeralResourceTemplate(TerraformCodeGenOptions options)
        : base(Path.Combine(options.TemplatesDirectory, "ephemeral_resource.mustache"))
    {
    }

    public string Generate(ResourceModel ephemeralResource, string namespacePrefix)
    {
        return Generate(
            ephemeralResource,
            namespacePrefix,
            "TerraformEphemeralResource",
            "ephemeral resource",
            "Ephemeral resources are used for temporary credentials, tokens, and secrets.");
    }
}
