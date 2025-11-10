using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_identity_source resource.
/// </summary>
public class AwsVerifiedpermissionsIdentitySource : TerraformResource
{
    public AwsVerifiedpermissionsIdentitySource(string name) : base("aws_verifiedpermissions_identity_source", name)
    {
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformPropertyName("policy_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicyStoreId { get; set; }

    /// <summary>
    /// The principal_entity_type attribute.
    /// </summary>
    [TerraformPropertyName("principal_entity_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrincipalEntityType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_entity_type");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
