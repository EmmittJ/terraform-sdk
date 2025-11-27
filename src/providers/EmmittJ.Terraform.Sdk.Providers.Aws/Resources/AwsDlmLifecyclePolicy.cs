using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_details in AwsDlmLifecyclePolicy.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_details";

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTags
    {
        get => new TerraformReference<bool>(this, "copy_tags");
        set => SetArgument("copy_tags", value);
    }

    /// <summary>
    /// The create_interval attribute.
    /// </summary>
    public TerraformValue<double>? CreateInterval
    {
        get => new TerraformReference<double>(this, "create_interval");
        set => SetArgument("create_interval", value);
    }

    /// <summary>
    /// The extend_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? ExtendDeletion
    {
        get => new TerraformReference<bool>(this, "extend_deletion");
        set => SetArgument("extend_deletion", value);
    }

    /// <summary>
    /// The policy_language attribute.
    /// </summary>
    public TerraformValue<string> PolicyLanguage
    {
        get => new TerraformReference<string>(this, "policy_language");
        set => SetArgument("policy_language", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// The resource_locations attribute.
    /// </summary>
    public TerraformList<string> ResourceLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_locations").ResolveNodes(ctx));
        set => SetArgument("resource_locations", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The retain_interval attribute.
    /// </summary>
    public TerraformValue<double>? RetainInterval
    {
        get => new TerraformReference<double>(this, "retain_interval");
        set => SetArgument("retain_interval", value);
    }

    /// <summary>
    /// The target_tags attribute.
    /// </summary>
    public TerraformMap<string>? TargetTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "target_tags").ResolveNodes(ctx));
        set => SetArgument("target_tags", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// EventSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventSource block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlock>? EventSource
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlock>>("event_source");
        set => SetArgument("event_source", value);
    }

    /// <summary>
    /// Exclusions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exclusions block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockExclusionsBlock>? Exclusions
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockExclusionsBlock>>("exclusions");
        set => SetArgument("exclusions", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Schedule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for action in AwsDlmLifecyclePolicyPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// CrossRegionCopy block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CrossRegionCopy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CrossRegionCopy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CrossRegionCopy block(s) allowed")]
    public required TerraformSet<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlock> CrossRegionCopy
    {
        get => GetRequiredArgument<TerraformSet<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlock>>("cross_region_copy");
        set => SetArgument("cross_region_copy", value);
    }

}

/// <summary>
/// Block type for cross_region_copy in AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_region_copy";

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockEncryptionConfigurationBlock> EncryptionConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// RetainRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetainRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockRetainRuleBlock>? RetainRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockRetainRuleBlock>>("retain_rule");
        set => SetArgument("retain_rule", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The cmk_arn attribute.
    /// </summary>
    public TerraformValue<string>? CmkArn
    {
        get => new TerraformReference<string>(this, "cmk_arn");
        set => SetArgument("cmk_arn", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

}

/// <summary>
/// Block type for retain_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockActionBlockCrossRegionCopyBlockRetainRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retain_rule";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalUnit is required")]
    public required TerraformValue<string> IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for event_source in AwsDlmLifecyclePolicyPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_source";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlockParametersBlock> Parameters
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockEventSourceBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The description_regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DescriptionRegex is required")]
    public required TerraformValue<string> DescriptionRegex
    {
        get => new TerraformReference<string>(this, "description_regex");
        set => SetArgument("description_regex", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The snapshot_owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotOwner is required")]
    public required TerraformSet<string> SnapshotOwner
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "snapshot_owner").ResolveNodes(ctx));
        set => SetArgument("snapshot_owner", value);
    }

}

/// <summary>
/// Block type for exclusions in AwsDlmLifecyclePolicyPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusions";

    /// <summary>
    /// The exclude_boot_volumes attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeBootVolumes
    {
        get => new TerraformReference<bool>(this, "exclude_boot_volumes");
        set => SetArgument("exclude_boot_volumes", value);
    }

    /// <summary>
    /// The exclude_tags attribute.
    /// </summary>
    public TerraformMap<string>? ExcludeTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "exclude_tags").ResolveNodes(ctx));
        set => SetArgument("exclude_tags", value);
    }

    /// <summary>
    /// The exclude_volume_types attribute.
    /// </summary>
    public TerraformList<string>? ExcludeVolumeTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exclude_volume_types").ResolveNodes(ctx));
        set => SetArgument("exclude_volume_types", value);
    }

}

/// <summary>
/// Block type for parameters in AwsDlmLifecyclePolicyPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The exclude_boot_volume attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeBootVolume
    {
        get => new TerraformReference<bool>(this, "exclude_boot_volume");
        set => SetArgument("exclude_boot_volume", value);
    }

    /// <summary>
    /// The no_reboot attribute.
    /// </summary>
    public TerraformValue<bool>? NoReboot
    {
        get => new TerraformReference<bool>(this, "no_reboot");
        set => SetArgument("no_reboot", value);
    }

}

/// <summary>
/// Block type for schedule in AwsDlmLifecyclePolicyPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformValue<bool> CopyTags
    {
        get => new TerraformReference<bool>(this, "copy_tags");
        set => SetArgument("copy_tags", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags_to_add attribute.
    /// </summary>
    public TerraformMap<string>? TagsToAdd
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_to_add").ResolveNodes(ctx));
        set => SetArgument("tags_to_add", value);
    }

    /// <summary>
    /// The variable_tags attribute.
    /// </summary>
    public TerraformMap<string>? VariableTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "variable_tags").ResolveNodes(ctx));
        set => SetArgument("variable_tags", value);
    }

    /// <summary>
    /// ArchiveRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchiveRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlock>? ArchiveRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlock>>("archive_rule");
        set => SetArgument("archive_rule", value);
    }

    /// <summary>
    /// CreateRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CreateRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateRule block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlock> CreateRule
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlock>>("create_rule");
        set => SetArgument("create_rule", value);
    }

    /// <summary>
    /// CrossRegionCopyRule block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CrossRegionCopyRule block(s) allowed")]
    public TerraformSet<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlock>? CrossRegionCopyRule
    {
        get => GetArgument<TerraformSet<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlock>>("cross_region_copy_rule");
        set => SetArgument("cross_region_copy_rule", value);
    }

    /// <summary>
    /// DeprecateRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeprecateRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockDeprecateRuleBlock>? DeprecateRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockDeprecateRuleBlock>>("deprecate_rule");
        set => SetArgument("deprecate_rule", value);
    }

    /// <summary>
    /// FastRestoreRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FastRestoreRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockFastRestoreRuleBlock>? FastRestoreRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockFastRestoreRuleBlock>>("fast_restore_rule");
        set => SetArgument("fast_restore_rule", value);
    }

    /// <summary>
    /// RetainRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetainRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetainRule block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockRetainRuleBlock> RetainRule
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockRetainRuleBlock>>("retain_rule");
        set => SetArgument("retain_rule", value);
    }

    /// <summary>
    /// ShareRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockShareRuleBlock>? ShareRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockShareRuleBlock>>("share_rule");
        set => SetArgument("share_rule", value);
    }

}

/// <summary>
/// Block type for archive_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_rule";

    /// <summary>
    /// ArchiveRetainRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchiveRetainRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ArchiveRetainRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchiveRetainRule block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlock> ArchiveRetainRule
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlock>>("archive_retain_rule");
        set => SetArgument("archive_retain_rule", value);
    }

}

/// <summary>
/// Block type for archive_retain_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_retain_rule";

    /// <summary>
    /// RetentionArchiveTier block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionArchiveTier is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionArchiveTier block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionArchiveTier block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlockRetentionArchiveTierBlock> RetentionArchiveTier
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlockRetentionArchiveTierBlock>>("retention_archive_tier");
        set => SetArgument("retention_archive_tier", value);
    }

}

/// <summary>
/// Block type for retention_archive_tier in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockArchiveRuleBlockArchiveRetainRuleBlockRetentionArchiveTierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_archive_tier";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    public TerraformValue<string>? IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for create_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_rule";

    /// <summary>
    /// The cron_expression attribute.
    /// </summary>
    public TerraformValue<string>? CronExpression
    {
        get => new TerraformReference<string>(this, "cron_expression");
        set => SetArgument("cron_expression", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    public TerraformValue<string> IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The times attribute.
    /// </summary>
    public TerraformList<string> Times
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "times").ResolveNodes(ctx));
        set => SetArgument("times", value);
    }

    /// <summary>
    /// Scripts block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scripts block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlockScriptsBlock>? Scripts
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlockScriptsBlock>>("scripts");
        set => SetArgument("scripts", value);
    }

}

/// <summary>
/// Block type for scripts in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCreateRuleBlockScriptsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scripts";

    /// <summary>
    /// The execute_operation_on_script_failure attribute.
    /// </summary>
    public TerraformValue<bool> ExecuteOperationOnScriptFailure
    {
        get => new TerraformReference<bool>(this, "execute_operation_on_script_failure");
        set => SetArgument("execute_operation_on_script_failure", value);
    }

    /// <summary>
    /// The execution_handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionHandler is required")]
    public required TerraformValue<string> ExecutionHandler
    {
        get => new TerraformReference<string>(this, "execution_handler");
        set => SetArgument("execution_handler", value);
    }

    /// <summary>
    /// The execution_handler_service attribute.
    /// </summary>
    public TerraformValue<string> ExecutionHandlerService
    {
        get => new TerraformReference<string>(this, "execution_handler_service");
        set => SetArgument("execution_handler_service", value);
    }

    /// <summary>
    /// The execution_timeout attribute.
    /// </summary>
    public TerraformValue<double> ExecutionTimeout
    {
        get => new TerraformReference<double>(this, "execution_timeout");
        set => SetArgument("execution_timeout", value);
    }

    /// <summary>
    /// The maximum_retry_count attribute.
    /// </summary>
    public TerraformValue<double> MaximumRetryCount
    {
        get => new TerraformReference<double>(this, "maximum_retry_count");
        set => SetArgument("maximum_retry_count", value);
    }

    /// <summary>
    /// The stages attribute.
    /// </summary>
    public TerraformList<string>? Stages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "stages").ResolveNodes(ctx));
        set => SetArgument("stages", value);
    }

}

/// <summary>
/// Block type for cross_region_copy_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: set
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_region_copy_rule";

    /// <summary>
    /// The cmk_arn attribute.
    /// </summary>
    public TerraformValue<string>? CmkArn
    {
        get => new TerraformReference<string>(this, "cmk_arn");
        set => SetArgument("cmk_arn", value);
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformValue<bool> CopyTags
    {
        get => new TerraformReference<bool>(this, "copy_tags");
        set => SetArgument("copy_tags", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encrypted is required")]
    public required TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    public TerraformValue<string>? TargetRegion
    {
        get => new TerraformReference<string>(this, "target_region");
        set => SetArgument("target_region", value);
    }

    /// <summary>
    /// DeprecateRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeprecateRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockDeprecateRuleBlock>? DeprecateRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockDeprecateRuleBlock>>("deprecate_rule");
        set => SetArgument("deprecate_rule", value);
    }

    /// <summary>
    /// RetainRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetainRule block(s) allowed")]
    public TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockRetainRuleBlock>? RetainRule
    {
        get => GetArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockRetainRuleBlock>>("retain_rule");
        set => SetArgument("retain_rule", value);
    }

}

/// <summary>
/// Block type for deprecate_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockDeprecateRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deprecate_rule";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalUnit is required")]
    public required TerraformValue<string> IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for retain_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockCrossRegionCopyRuleBlockRetainRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retain_rule";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalUnit is required")]
    public required TerraformValue<string> IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for deprecate_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockDeprecateRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deprecate_rule";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    public TerraformValue<string>? IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for fast_restore_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockFastRestoreRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fast_restore_rule";

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZones is required")]
    public required TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    public TerraformValue<string>? IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for retain_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockRetainRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retain_rule";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The interval_unit attribute.
    /// </summary>
    public TerraformValue<string>? IntervalUnit
    {
        get => new TerraformReference<string>(this, "interval_unit");
        set => SetArgument("interval_unit", value);
    }

}

/// <summary>
/// Block type for share_rule in AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlockScheduleBlockShareRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_rule";

    /// <summary>
    /// The target_accounts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAccounts is required")]
    public required TerraformSet<string> TargetAccounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "target_accounts").ResolveNodes(ctx));
        set => SetArgument("target_accounts", value);
    }

    /// <summary>
    /// The unshare_interval attribute.
    /// </summary>
    public TerraformValue<double>? UnshareInterval
    {
        get => new TerraformReference<double>(this, "unshare_interval");
        set => SetArgument("unshare_interval", value);
    }

    /// <summary>
    /// The unshare_interval_unit attribute.
    /// </summary>
    public TerraformValue<string>? UnshareIntervalUnit
    {
        get => new TerraformReference<string>(this, "unshare_interval_unit");
        set => SetArgument("unshare_interval_unit", value);
    }

}


/// <summary>
/// Represents a aws_dlm_lifecycle_policy Terraform resource.
/// Manages a aws_dlm_lifecycle_policy resource.
/// </summary>
public partial class AwsDlmLifecyclePolicy(string name) : TerraformResource("aws_dlm_lifecycle_policy", name)
{
    /// <summary>
    /// The default_policy attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPolicy
    {
        get => new TerraformReference<string>(this, "default_policy");
        set => SetArgument("default_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => new TerraformReference<string>(this, "execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// PolicyDetails block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyDetails block(s) allowed")]
    public required TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlock> PolicyDetails
    {
        get => GetRequiredArgument<TerraformList<AwsDlmLifecyclePolicyPolicyDetailsBlock>>("policy_details");
        set => SetArgument("policy_details", value);
    }

}
