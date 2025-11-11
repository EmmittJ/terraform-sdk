using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleExcludeResourceTagsBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformPropertyName("resource_tag_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for lock_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleLockConfigurationBlock
{
}

/// <summary>
/// Block type for resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleResourceTagsBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformPropertyName("resource_tag_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for retention_period in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleRetentionPeriodBlock
{
    /// <summary>
    /// The retention_period_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodUnit is required")]
    [TerraformPropertyName("retention_period_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RetentionPeriodUnit { get; set; }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    [TerraformPropertyName("retention_period_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RetentionPeriodValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRbinRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rbin_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRbinRule : TerraformResource
{
    public AwsRbinRule(string name) : base("aws_rbin_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceType { get; set; }

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
    /// Block for exclude_resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    [TerraformPropertyName("exclude_resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleExcludeResourceTagsBlock>>? ExcludeResourceTags { get; set; }

    /// <summary>
    /// Block for lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    [TerraformPropertyName("lock_configuration")]
    public TerraformList<TerraformBlock<AwsRbinRuleLockConfigurationBlock>>? LockConfiguration { get; set; }

    /// <summary>
    /// Block for resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    [TerraformPropertyName("resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleResourceTagsBlock>>? ResourceTags { get; set; }

    /// <summary>
    /// Block for retention_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    [TerraformPropertyName("retention_period")]
    public TerraformList<TerraformBlock<AwsRbinRuleRetentionPeriodBlock>>? RetentionPeriod { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRbinRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The lock_end_time attribute.
    /// </summary>
    [TerraformPropertyName("lock_end_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LockEndTime => new TerraformReference(this, "lock_end_time");

    /// <summary>
    /// The lock_state attribute.
    /// </summary>
    [TerraformPropertyName("lock_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LockState => new TerraformReference(this, "lock_state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
