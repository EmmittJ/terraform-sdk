using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aggregate_configuration in AwsFsxOntapVolume.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeAggregateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregate_configuration";

    /// <summary>
    /// The aggregates attribute.
    /// </summary>
    public TerraformList<string>? Aggregates
    {
        get => GetArgument<TerraformList<string>>("aggregates");
        set => SetArgument("aggregates", value);
    }

    /// <summary>
    /// The constituents_per_aggregate attribute.
    /// </summary>
    public TerraformValue<double>? ConstituentsPerAggregate
    {
        get => GetArgument<TerraformValue<double>>("constituents_per_aggregate");
        set => SetArgument("constituents_per_aggregate", value);
    }

    /// <summary>
    /// The total_constituents attribute.
    /// </summary>
    public TerraformValue<double> TotalConstituents
        => AsReference("total_constituents");

}


/// <summary>
/// Block type for snaplock_configuration in AwsFsxOntapVolume.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snaplock_configuration";

    /// <summary>
    /// The audit_log_volume attribute.
    /// </summary>
    public TerraformValue<bool>? AuditLogVolume
    {
        get => GetArgument<TerraformValue<bool>>("audit_log_volume");
        set => SetArgument("audit_log_volume", value);
    }

    /// <summary>
    /// The privileged_delete attribute.
    /// </summary>
    public TerraformValue<string>? PrivilegedDelete
    {
        get => GetArgument<TerraformValue<string>>("privileged_delete");
        set => SetArgument("privileged_delete", value);
    }

    /// <summary>
    /// The snaplock_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnaplockType is required")]
    public required TerraformValue<string> SnaplockType
    {
        get => GetArgument<TerraformValue<string>>("snaplock_type");
        set => SetArgument("snaplock_type", value);
    }

    /// <summary>
    /// The volume_append_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VolumeAppendModeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("volume_append_mode_enabled");
        set => SetArgument("volume_append_mode_enabled", value);
    }

    /// <summary>
    /// AutocommitPeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutocommitPeriod block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockAutocommitPeriodBlock>? AutocommitPeriod
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockAutocommitPeriodBlock>>("autocommit_period");
        set => SetArgument("autocommit_period", value);
    }

    /// <summary>
    /// RetentionPeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPeriod block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock>? RetentionPeriod
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock>>("retention_period");
        set => SetArgument("retention_period", value);
    }

}

/// <summary>
/// Block type for autocommit_period in AwsFsxOntapVolumeSnaplockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlockAutocommitPeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autocommit_period";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for retention_period in AwsFsxOntapVolumeSnaplockConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_period";

    /// <summary>
    /// DefaultRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetention block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockDefaultRetentionBlock>? DefaultRetention
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockDefaultRetentionBlock>>("default_retention");
        set => SetArgument("default_retention", value);
    }

    /// <summary>
    /// MaximumRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumRetention block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMaximumRetentionBlock>? MaximumRetention
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMaximumRetentionBlock>>("maximum_retention");
        set => SetArgument("maximum_retention", value);
    }

    /// <summary>
    /// MinimumRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumRetention block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMinimumRetentionBlock>? MinimumRetention
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMinimumRetentionBlock>>("minimum_retention");
        set => SetArgument("minimum_retention", value);
    }

}

/// <summary>
/// Block type for default_retention in AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockDefaultRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_retention";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for maximum_retention in AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMaximumRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maximum_retention";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for minimum_retention in AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlockRetentionPeriodBlockMinimumRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minimum_retention";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for tiering_policy in AwsFsxOntapVolume.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeTieringPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tiering_policy";

    /// <summary>
    /// The cooling_period attribute.
    /// </summary>
    public TerraformValue<double>? CoolingPeriod
    {
        get => GetArgument<TerraformValue<double>>("cooling_period");
        set => SetArgument("cooling_period", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxOntapVolume.
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapVolumeTimeoutsBlock : TerraformBlock
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
/// Represents a aws_fsx_ontap_volume Terraform resource.
/// Manages a aws_fsx_ontap_volume resource.
/// </summary>
public partial class AwsFsxOntapVolume(string name) : TerraformResource("aws_fsx_ontap_volume", name)
{
    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    public TerraformValue<bool>? BypassSnaplockEnterpriseRetention
    {
        get => GetArgument<TerraformValue<bool>>("bypass_snaplock_enterprise_retention");
        set => SetArgument("bypass_snaplock_enterprise_retention", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToBackups
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_backups");
        set => SetArgument("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformMap<string>? FinalBackupTags
    {
        get => GetArgument<TerraformMap<string>>("final_backup_tags");
        set => SetArgument("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    public TerraformValue<string>? JunctionPath
    {
        get => GetArgument<TerraformValue<string>>("junction_path");
        set => SetArgument("junction_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    public TerraformValue<string>? OntapVolumeType
    {
        get => GetArgument<TerraformValue<string>>("ontap_volume_type");
        set => SetArgument("ontap_volume_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public TerraformValue<string>? SecurityStyle
    {
        get => GetArgument<TerraformValue<string>>("security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformValue<string>? SizeInBytes
    {
        get => GetArgument<TerraformValue<string>>("size_in_bytes");
        set => SetArgument("size_in_bytes", value);
    }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    public TerraformValue<double>? SizeInMegabytes
    {
        get => GetArgument<TerraformValue<double>>("size_in_megabytes");
        set => SetArgument("size_in_megabytes", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalBackup
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_backup");
        set => SetArgument("skip_final_backup", value);
    }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotPolicy
    {
        get => GetArgument<TerraformValue<string>>("snapshot_policy");
        set => SetArgument("snapshot_policy", value);
    }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEfficiencyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("storage_efficiency_enabled");
        set => SetArgument("storage_efficiency_enabled", value);
    }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineId is required")]
    public required TerraformValue<string> StorageVirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("storage_virtual_machine_id");
        set => SetArgument("storage_virtual_machine_id", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The volume_style attribute.
    /// </summary>
    public TerraformValue<string>? VolumeStyle
    {
        get => GetArgument<TerraformValue<string>>("volume_style");
        set => SetArgument("volume_style", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
        => AsReference("file_system_id");

    /// <summary>
    /// The flexcache_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> FlexcacheEndpointType
        => AsReference("flexcache_endpoint_type");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformValue<string> Uuid
        => AsReference("uuid");

    /// <summary>
    /// AggregateConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregateConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeAggregateConfigurationBlock>? AggregateConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeAggregateConfigurationBlock>>("aggregate_configuration");
        set => SetArgument("aggregate_configuration", value);
    }

    /// <summary>
    /// SnaplockConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnaplockConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlock>? SnaplockConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeSnaplockConfigurationBlock>>("snaplock_configuration");
        set => SetArgument("snaplock_configuration", value);
    }

    /// <summary>
    /// TieringPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public TerraformList<AwsFsxOntapVolumeTieringPolicyBlock>? TieringPolicy
    {
        get => GetArgument<TerraformList<AwsFsxOntapVolumeTieringPolicyBlock>>("tiering_policy");
        set => SetArgument("tiering_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxOntapVolumeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxOntapVolumeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
