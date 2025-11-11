using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for matching in .
/// Nesting mode: list
/// </summary>
public partial class AwsCustomerprofilesDomainMatchingBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for rule_based_matching in .
/// Nesting mode: list
/// </summary>
public partial class AwsCustomerprofilesDomainRuleBasedMatchingBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The max_allowed_rule_level_for_matching attribute.
    /// </summary>
    [TerraformProperty("max_allowed_rule_level_for_matching")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAllowedRuleLevelForMatching { get; set; }

    /// <summary>
    /// The max_allowed_rule_level_for_merging attribute.
    /// </summary>
    [TerraformProperty("max_allowed_rule_level_for_merging")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAllowedRuleLevelForMerging { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCustomerprofilesDomain : TerraformResource
{
    public AwsCustomerprofilesDomain(string name) : base("aws_customerprofiles_domain", name)
    {
    }

    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    [TerraformProperty("dead_letter_queue_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeadLetterQueueUrl { get; set; }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    [TerraformProperty("default_encryption_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultEncryptionKey { get; set; }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultExpirationDays is required")]
    [TerraformProperty("default_expiration_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DefaultExpirationDays { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matching block(s) allowed")]
    [TerraformProperty("matching")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesDomainMatchingBlock>>? Matching { get; set; }

    /// <summary>
    /// Block for rule_based_matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleBasedMatching block(s) allowed")]
    [TerraformProperty("rule_based_matching")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesDomainRuleBasedMatchingBlock>>? RuleBasedMatching { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
