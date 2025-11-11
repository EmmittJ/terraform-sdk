using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlock
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_policy resource.
/// </summary>
public class AwsVerifiedpermissionsPolicy : TerraformResource
{
    public AwsVerifiedpermissionsPolicy(string name) : base("aws_verifiedpermissions_policy", name)
    {
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformPropertyName("policy_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("definition")]
    public TerraformList<TerraformBlock<AwsVerifiedpermissionsPolicyDefinitionBlock>>? Definition { get; set; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyId => new TerraformReference(this, "policy_id");

}
