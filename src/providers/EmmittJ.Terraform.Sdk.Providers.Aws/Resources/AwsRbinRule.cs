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
        set => SetProperty("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceTagValue
    {
        set => SetProperty("resource_tag_value", value);
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
        set => SetProperty("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceTagValue
    {
        set => SetProperty("resource_tag_value", value);
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
        set => SetProperty("retention_period_unit", value);
    }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    public required TerraformProperty<double> RetentionPeriodValue
    {
        set => SetProperty("retention_period_value", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("lock_end_time");
        SetOutput("lock_state");
        SetOutput("status");
        SetOutput("description");
        SetOutput("region");
        SetOutput("resource_type");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for exclude_resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    public HashSet<AwsRbinRuleExcludeResourceTagsBlock>? ExcludeResourceTags
    {
        set => SetProperty("exclude_resource_tags", value);
    }

    /// <summary>
    /// Block for lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    public List<AwsRbinRuleLockConfigurationBlock>? LockConfiguration
    {
        set => SetProperty("lock_configuration", value);
    }

    /// <summary>
    /// Block for resource_tags.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    public HashSet<AwsRbinRuleResourceTagsBlock>? ResourceTags
    {
        set => SetProperty("resource_tags", value);
    }

    /// <summary>
    /// Block for retention_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    public List<AwsRbinRuleRetentionPeriodBlock>? RetentionPeriod
    {
        set => SetProperty("retention_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRbinRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
