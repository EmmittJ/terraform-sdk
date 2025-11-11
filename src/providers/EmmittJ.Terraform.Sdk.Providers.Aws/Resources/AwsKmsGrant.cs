using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for constraints in .
/// Nesting mode: set
/// </summary>
public partial class AwsKmsGrantConstraintsBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_context_equals attribute.
    /// </summary>
    [TerraformProperty("encryption_context_equals")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EncryptionContextEquals { get; set; }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    [TerraformProperty("encryption_context_subset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EncryptionContextSubset { get; set; }

}

/// <summary>
/// Manages a aws_kms_grant resource.
/// </summary>
public partial class AwsKmsGrant : TerraformResource
{
    public AwsKmsGrant(string name) : base("aws_kms_grant", name)
    {
    }

    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    [TerraformProperty("grant_creation_tokens")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? GrantCreationTokens { get; set; }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    [TerraformProperty("grantee_principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GranteePrincipal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    [TerraformProperty("operations")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Operations { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    [TerraformProperty("retire_on_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetireOnDelete { get; set; }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    [TerraformProperty("retiring_principal")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RetiringPrincipal { get; set; }

    /// <summary>
    /// Block for constraints.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("constraints")]
    public partial TerraformSet<TerraformBlock<AwsKmsGrantConstraintsBlock>>? Constraints { get; set; }

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    [TerraformProperty("grant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GrantId { get; }

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    [TerraformProperty("grant_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GrantToken { get; }

}
