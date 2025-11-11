using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedpermissionsIdentitySourceConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_identity_source resource.
/// </summary>
public partial class AwsVerifiedpermissionsIdentitySource : TerraformResource
{
    public AwsVerifiedpermissionsIdentitySource(string name) : base("aws_verifiedpermissions_identity_source", name)
    {
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformProperty("policy_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyStoreId { get; set; }

    /// <summary>
    /// The principal_entity_type attribute.
    /// </summary>
    [TerraformProperty("principal_entity_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrincipalEntityType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("configuration")]
    public TerraformList<TerraformBlock<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
