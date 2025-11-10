using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleExcludeResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    public required TerraformProperty<string> ResourceTagKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_tag_key");
        set => WithProperty("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceTagValue
    {
        get => GetProperty<TerraformProperty<string>>("resource_tag_value");
        set => WithProperty("resource_tag_value", value);
    }

}

/// <summary>
/// Block type for lock_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleLockConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for resource_tags in .
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    public required TerraformProperty<string> ResourceTagKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_tag_key");
        set => WithProperty("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceTagValue
    {
        get => GetProperty<TerraformProperty<string>>("resource_tag_value");
        set => WithProperty("resource_tag_value", value);
    }

}

/// <summary>
/// Block type for retention_period in .
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleRetentionPeriodBlock : TerraformBlock
{
    /// <summary>
    /// The retention_period_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodUnit is required")]
    public required TerraformProperty<string> RetentionPeriodUnit
    {
        get => GetRequiredProperty<TerraformProperty<string>>("retention_period_unit");
        set => WithProperty("retention_period_unit", value);
    }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    public required TerraformProperty<double> RetentionPeriodValue
    {
        get => GetRequiredProperty<TerraformProperty<double>>("retention_period_value");
        set => WithProperty("retention_period_value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRbinRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_rbin_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRbinRule : TerraformResource
{
    public AwsRbinRule(string name) : base("aws_rbin_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("lock_end_time");
        this.WithOutput("lock_state");
        this.WithOutput("status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for exclude_resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    public HashSet<AwsRbinRuleExcludeResourceTagsBlock>? ExcludeResourceTags
    {
        get => GetProperty<HashSet<AwsRbinRuleExcludeResourceTagsBlock>>("exclude_resource_tags");
        set => this.WithProperty("exclude_resource_tags", value);
    }

    /// <summary>
    /// Block for lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    public List<AwsRbinRuleLockConfigurationBlock>? LockConfiguration
    {
        get => GetProperty<List<AwsRbinRuleLockConfigurationBlock>>("lock_configuration");
        set => this.WithProperty("lock_configuration", value);
    }

    /// <summary>
    /// Block for resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    public HashSet<AwsRbinRuleResourceTagsBlock>? ResourceTags
    {
        get => GetProperty<HashSet<AwsRbinRuleResourceTagsBlock>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// Block for retention_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    public List<AwsRbinRuleRetentionPeriodBlock>? RetentionPeriod
    {
        get => GetProperty<List<AwsRbinRuleRetentionPeriodBlock>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRbinRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRbinRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The lock_end_time attribute.
    /// </summary>
    public TerraformExpression LockEndTime => this["lock_end_time"];

    /// <summary>
    /// The lock_state attribute.
    /// </summary>
    public TerraformExpression LockState => this["lock_state"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
