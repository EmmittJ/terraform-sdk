using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_resource_tags in AwsRbinRule.
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleExcludeResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_resource_tags";

    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    public required TerraformValue<string> ResourceTagKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_tag_key");
        set => SetArgument("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTagValue
    {
        get => GetArgument<TerraformValue<string>>("resource_tag_value");
        set => SetArgument("resource_tag_value", value);
    }

}


/// <summary>
/// Block type for lock_configuration in AwsRbinRule.
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleLockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lock_configuration";

    /// <summary>
    /// UnlockDelay block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnlockDelay is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UnlockDelay block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UnlockDelay block(s) allowed")]
    public required TerraformList<AwsRbinRuleLockConfigurationBlockUnlockDelayBlock> UnlockDelay
    {
        get => GetRequiredArgument<TerraformList<AwsRbinRuleLockConfigurationBlockUnlockDelayBlock>>("unlock_delay");
        set => SetArgument("unlock_delay", value);
    }

}

/// <summary>
/// Block type for unlock_delay in AwsRbinRuleLockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleLockConfigurationBlockUnlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unlock_delay";

    /// <summary>
    /// The unlock_delay_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnlockDelayUnit is required")]
    public required TerraformValue<string> UnlockDelayUnit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unlock_delay_unit");
        set => SetArgument("unlock_delay_unit", value);
    }

    /// <summary>
    /// The unlock_delay_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnlockDelayValue is required")]
    public required TerraformValue<double> UnlockDelayValue
    {
        get => GetRequiredArgument<TerraformValue<double>>("unlock_delay_value");
        set => SetArgument("unlock_delay_value", value);
    }

}


/// <summary>
/// Block type for resource_tags in AwsRbinRule.
/// Nesting mode: set
/// </summary>
public class AwsRbinRuleResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_tags";

    /// <summary>
    /// The resource_tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTagKey is required")]
    public required TerraformValue<string> ResourceTagKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_tag_key");
        set => SetArgument("resource_tag_key", value);
    }

    /// <summary>
    /// The resource_tag_value attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTagValue
    {
        get => GetArgument<TerraformValue<string>>("resource_tag_value");
        set => SetArgument("resource_tag_value", value);
    }

}


/// <summary>
/// Block type for retention_period in AwsRbinRule.
/// Nesting mode: list
/// </summary>
public class AwsRbinRuleRetentionPeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_period";

    /// <summary>
    /// The retention_period_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodUnit is required")]
    public required TerraformValue<string> RetentionPeriodUnit
    {
        get => GetRequiredArgument<TerraformValue<string>>("retention_period_unit");
        set => SetArgument("retention_period_unit", value);
    }

    /// <summary>
    /// The retention_period_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodValue is required")]
    public required TerraformValue<double> RetentionPeriodValue
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_period_value");
        set => SetArgument("retention_period_value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRbinRule.
/// Nesting mode: single
/// </summary>
public class AwsRbinRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rbin_rule Terraform resource.
/// Manages a aws_rbin_rule resource.
/// </summary>
public partial class AwsRbinRule(string name) : TerraformResource("aws_rbin_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? AsReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The lock_end_time attribute.
    /// </summary>
    public TerraformValue<string> LockEndTime
        => AsReference("lock_end_time");

    /// <summary>
    /// The lock_state attribute.
    /// </summary>
    public TerraformValue<string> LockState
        => AsReference("lock_state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// ExcludeResourceTags block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExcludeResourceTags block(s) allowed")]
    public TerraformSet<AwsRbinRuleExcludeResourceTagsBlock>? ExcludeResourceTags
    {
        get => GetArgument<TerraformSet<AwsRbinRuleExcludeResourceTagsBlock>>("exclude_resource_tags");
        set => SetArgument("exclude_resource_tags", value);
    }

    /// <summary>
    /// LockConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfiguration block(s) allowed")]
    public TerraformList<AwsRbinRuleLockConfigurationBlock>? LockConfiguration
    {
        get => GetArgument<TerraformList<AwsRbinRuleLockConfigurationBlock>>("lock_configuration");
        set => SetArgument("lock_configuration", value);
    }

    /// <summary>
    /// ResourceTags block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTags block(s) allowed")]
    public TerraformSet<AwsRbinRuleResourceTagsBlock>? ResourceTags
    {
        get => GetArgument<TerraformSet<AwsRbinRuleResourceTagsBlock>>("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// RetentionPeriod block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    public required TerraformList<AwsRbinRuleRetentionPeriodBlock> RetentionPeriod
    {
        get => GetRequiredArgument<TerraformList<AwsRbinRuleRetentionPeriodBlock>>("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRbinRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRbinRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
