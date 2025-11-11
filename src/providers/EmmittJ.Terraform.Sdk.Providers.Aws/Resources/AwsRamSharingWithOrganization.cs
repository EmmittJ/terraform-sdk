using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ram_sharing_with_organization resource.
/// </summary>
public class AwsRamSharingWithOrganization : TerraformResource
{
    public AwsRamSharingWithOrganization(string name) : base("aws_ram_sharing_with_organization", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

}
