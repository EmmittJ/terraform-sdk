using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ram_sharing_with_organization resource.
/// </summary>
public partial class AwsRamSharingWithOrganization : TerraformResource
{
    public AwsRamSharingWithOrganization(string name) : base("aws_ram_sharing_with_organization", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

}
