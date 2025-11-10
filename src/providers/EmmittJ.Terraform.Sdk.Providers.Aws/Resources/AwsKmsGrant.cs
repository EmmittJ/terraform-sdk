using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for constraints in .
/// Nesting mode: set
/// </summary>
public class AwsKmsGrantConstraintsBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption_context_equals attribute.
    /// </summary>
    [TerraformPropertyName("encryption_context_equals")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EncryptionContextEquals { get; set; }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    [TerraformPropertyName("encryption_context_subset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EncryptionContextSubset { get; set; }

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
    public TerraformProperty<HashSet<TerraformProperty<string>>>? GrantCreationTokens { get; set; }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    [TerraformPropertyName("grantee_principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GranteePrincipal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    [TerraformPropertyName("operations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Operations { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    [TerraformPropertyName("retire_on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RetireOnDelete { get; set; }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    [TerraformPropertyName("retiring_principal")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RetiringPrincipal { get; set; }

    /// <summary>
    /// Block for constraints.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("constraints")]
    public TerraformSet<TerraformBlock<AwsKmsGrantConstraintsBlock>>? Constraints { get; set; } = new();

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    [TerraformPropertyName("grant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GrantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grant_id");

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    [TerraformPropertyName("grant_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GrantToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grant_token");

}
