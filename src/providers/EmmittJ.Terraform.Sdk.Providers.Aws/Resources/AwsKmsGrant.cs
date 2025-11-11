using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for constraints in .
/// Nesting mode: set
/// </summary>
public class AwsKmsGrantConstraintsBlock
{
    /// <summary>
    /// The encryption_context_equals attribute.
    /// </summary>
    [TerraformPropertyName("encryption_context_equals")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EncryptionContextEquals { get; set; }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    [TerraformPropertyName("encryption_context_subset")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EncryptionContextSubset { get; set; }

}

/// <summary>
/// Manages a aws_kms_grant resource.
/// </summary>
public class AwsKmsGrant : TerraformResource
{
    public AwsKmsGrant(string name) : base("aws_kms_grant", name)
    {
    }

    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    [TerraformPropertyName("grant_creation_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? GrantCreationTokens { get; set; }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    [TerraformPropertyName("grantee_principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GranteePrincipal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    [TerraformPropertyName("operations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Operations { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    [TerraformPropertyName("retire_on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RetireOnDelete { get; set; }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    [TerraformPropertyName("retiring_principal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RetiringPrincipal { get; set; }

    /// <summary>
    /// Block for constraints.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("constraints")]
    public TerraformSet<TerraformBlock<AwsKmsGrantConstraintsBlock>>? Constraints { get; set; }

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    [TerraformPropertyName("grant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GrantId => new TerraformReference(this, "grant_id");

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    [TerraformPropertyName("grant_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GrantToken => new TerraformReference(this, "grant_token");

}
