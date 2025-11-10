using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleExcludeResourceTagsBlock : ITerraformBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformPropertyName("resource_tag_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for lock_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleLockConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleResourceTagsBlock : ITerraformBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    [TerraformPropertyName("resource_tag_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceTagKey { get; set; }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceTagValue { get; set; }

}

/// <summary>
/// Block type for retention_period in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleRetentionPeriodBlock : ITerraformBlock
{
    /// <summary>
    /// The retention_period_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodUnit is required")]
    [TerraformPropertyName("retention_period_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RetentionPeriodUnit { get; set; }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    [TerraformPropertyName("retention_period_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RetentionPeriodValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRbinRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for exclude_resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    [TerraformPropertyName("exclude_resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleExcludeResourceTagsBlock>>? ExcludeResourceTags { get; set; } = new();

    /// <summary>
    /// Block for lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    [TerraformPropertyName("lock_configuration")]
    public TerraformList<TerraformBlock<AwsRbinRuleLockConfigurationBlock>>? LockConfiguration { get; set; } = new();

    /// <summary>
    /// Block for resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    [TerraformPropertyName("resource_tags")]
    public TerraformSet<TerraformBlock<AwsRbinRuleResourceTagsBlock>>? ResourceTags { get; set; } = new();

    /// <summary>
    /// Block for retention_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    [TerraformPropertyName("retention_period")]
    public TerraformList<TerraformBlock<AwsRbinRuleRetentionPeriodBlock>>? RetentionPeriod { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRbinRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lock_end_time attribute.
    /// </summary>
    [TerraformPropertyName("lock_end_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LockEndTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lock_end_time");

    /// <summary>
    /// The lock_state attribute.
    /// </summary>
    [TerraformPropertyName("lock_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LockState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lock_state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
