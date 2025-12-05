using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ram_sharing_with_organization Terraform resource.
/// Manages a aws_ram_sharing_with_organization resource.
/// </summary>
public partial class AwsRamSharingWithOrganization(string name) : TerraformResource("aws_ram_sharing_with_organization", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

}
