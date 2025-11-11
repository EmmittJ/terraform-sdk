using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_resource_tags in .
/// Nesting mode: set
/// </summary>
public partial class AwsRbinRuleExcludeResourceTagsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformProperty("resource_tag_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformProperty("resource_tag_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for lock_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsRbinRuleLockConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for resource_tags in .
/// Nesting mode: set
/// </summary>
public partial class AwsRbinRuleResourceTagsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformProperty("resource_tag_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformProperty("resource_tag_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for retention_period in .
/// Nesting mode: list
/// </summary>
public partial class AwsRbinRuleRetentionPeriodBlock : TerraformBlockBase
{
    /// <summary>
    /// The retention_period_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodUnit is required")]
    [TerraformProperty("retention_period_unit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RetentionPeriodUnit { get; set; }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    [TerraformProperty("retention_period_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RetentionPeriodValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRbinRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rbin_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRbinRule : TerraformResource
{
    public AwsRbinRule(string name) : base("aws_rbin_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceType { get; set; }

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
    /// Block for exclude_resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    [TerraformProperty("exclude_resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleExcludeResourceTagsBlock>>? ExcludeResourceTags { get; set; }

    /// <summary>
    /// Block for lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    [TerraformProperty("lock_configuration")]
    public TerraformList<TerraformBlock<AwsRbinRuleLockConfigurationBlock>>? LockConfiguration { get; set; }

    /// <summary>
    /// Block for resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    [TerraformProperty("resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleResourceTagsBlock>>? ResourceTags { get; set; }

    /// <summary>
    /// Block for retention_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    [TerraformProperty("retention_period")]
    public TerraformList<TerraformBlock<AwsRbinRuleRetentionPeriodBlock>>? RetentionPeriod { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRbinRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The lock_end_time attribute.
    /// </summary>
    [TerraformProperty("lock_end_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LockEndTime { get; }

    /// <summary>
    /// The lock_state attribute.
    /// </summary>
    [TerraformProperty("lock_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LockState { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
