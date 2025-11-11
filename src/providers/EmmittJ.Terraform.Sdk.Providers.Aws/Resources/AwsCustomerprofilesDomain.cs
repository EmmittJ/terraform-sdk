using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for matching in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for rule_based_matching in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The max_allowed_rule_level_for_matching attribute.
    /// </summary>
    [TerraformPropertyName("max_allowed_rule_level_for_matching")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAllowedRuleLevelForMatching { get; set; }

    /// <summary>
    /// The max_allowed_rule_level_for_merging attribute.
    /// </summary>
    [TerraformPropertyName("max_allowed_rule_level_for_merging")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAllowedRuleLevelForMerging { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

}

/// <summary>
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCustomerprofilesDomain : TerraformResource
{
    public AwsCustomerprofilesDomain(string name) : base("aws_customerprofiles_domain", name)
    {
    }

    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    [TerraformPropertyName("dead_letter_queue_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeadLetterQueueUrl { get; set; }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("default_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultEncryptionKey { get; set; }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultExpirationDays is required")]
    [TerraformPropertyName("default_expiration_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DefaultExpirationDays { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matching block(s) allowed")]
    [TerraformPropertyName("matching")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesDomainMatchingBlock>>? Matching { get; set; }

    /// <summary>
    /// Block for rule_based_matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleBasedMatching block(s) allowed")]
    [TerraformPropertyName("rule_based_matching")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesDomainRuleBasedMatchingBlock>>? RuleBasedMatching { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
