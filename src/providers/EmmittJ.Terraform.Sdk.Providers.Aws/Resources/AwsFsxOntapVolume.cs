using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aggregate_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeAggregateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The aggregates attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Aggregates
    {
        set => SetProperty("aggregates", value);
    }

    /// <summary>
    /// The constituents_per_aggregate attribute.
    /// </summary>
    public TerraformProperty<double>? ConstituentsPerAggregate
    {
        set => SetProperty("constituents_per_aggregate", value);
    }

    /// <summary>
    /// The total_constituents attribute.
    /// </summary>
    public TerraformProperty<double>? TotalConstituents
    {
        set => SetProperty("total_constituents", value);
    }

}

/// <summary>
/// Block type for snaplock_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The audit_log_volume attribute.
    /// </summary>
    public TerraformProperty<bool>? AuditLogVolume
    {
        set => SetProperty("audit_log_volume", value);
    }

    /// <summary>
    /// The privileged_delete attribute.
    /// </summary>
    public TerraformProperty<string>? PrivilegedDelete
    {
        set => SetProperty("privileged_delete", value);
    }

    /// <summary>
    /// The snaplock_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnaplockType is required")]
    public required TerraformProperty<string> SnaplockType
    {
        set => SetProperty("snaplock_type", value);
    }

    /// <summary>
    /// The volume_append_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VolumeAppendModeEnabled
    {
        set => SetProperty("volume_append_mode_enabled", value);
    }

}

/// <summary>
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeTieringPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The cooling_period attribute.
    /// </summary>
    public TerraformProperty<double>? CoolingPeriod
    {
        set => SetProperty("cooling_period", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapVolumeTimeoutsBlock : TerraformBlock
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
/// Manages a aws_fsx_ontap_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOntapVolume : TerraformResource
{
    public AwsFsxOntapVolume(string name) : base("aws_fsx_ontap_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("file_system_id");
        SetOutput("flexcache_endpoint_type");
        SetOutput("uuid");
        SetOutput("bypass_snaplock_enterprise_retention");
        SetOutput("copy_tags_to_backups");
        SetOutput("final_backup_tags");
        SetOutput("id");
        SetOutput("junction_path");
        SetOutput("name");
        SetOutput("ontap_volume_type");
        SetOutput("region");
        SetOutput("security_style");
        SetOutput("size_in_bytes");
        SetOutput("size_in_megabytes");
        SetOutput("skip_final_backup");
        SetOutput("snapshot_policy");
        SetOutput("storage_efficiency_enabled");
        SetOutput("storage_virtual_machine_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("volume_style");
        SetOutput("volume_type");
    }

    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    public TerraformProperty<bool> BypassSnaplockEnterpriseRetention
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bypass_snaplock_enterprise_retention");
        set => SetProperty("bypass_snaplock_enterprise_retention", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToBackups
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_backups");
        set => SetProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> FinalBackupTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => SetProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    public TerraformProperty<string> JunctionPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("junction_path");
        set => SetProperty("junction_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    public TerraformProperty<string> OntapVolumeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ontap_volume_type");
        set => SetProperty("ontap_volume_type", value);
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
    /// The security_style attribute.
    /// </summary>
    public TerraformProperty<string> SecurityStyle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_style");
        set => SetProperty("security_style", value);
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<string> SizeInBytes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("size_in_bytes");
        set => SetProperty("size_in_bytes", value);
    }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    public TerraformProperty<double> SizeInMegabytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size_in_megabytes");
        set => SetProperty("size_in_megabytes", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalBackup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_backup");
        set => SetProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_policy");
        set => SetProperty("snapshot_policy", value);
    }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> StorageEfficiencyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_efficiency_enabled");
        set => SetProperty("storage_efficiency_enabled", value);
    }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineId is required")]
    public required TerraformProperty<string> StorageVirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_virtual_machine_id");
        set => SetProperty("storage_virtual_machine_id", value);
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
    /// The volume_style attribute.
    /// </summary>
    public TerraformProperty<string> VolumeStyle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_style");
        set => SetProperty("volume_style", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string> VolumeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_type");
        set => SetProperty("volume_type", value);
    }

    /// <summary>
    /// Block for aggregate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregateConfiguration block(s) allowed")]
    public List<AwsFsxOntapVolumeAggregateConfigurationBlock>? AggregateConfiguration
    {
        set => SetProperty("aggregate_configuration", value);
    }

    /// <summary>
    /// Block for snaplock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnaplockConfiguration block(s) allowed")]
    public List<AwsFsxOntapVolumeSnaplockConfigurationBlock>? SnaplockConfiguration
    {
        set => SetProperty("snaplock_configuration", value);
    }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public List<AwsFsxOntapVolumeTieringPolicyBlock>? TieringPolicy
    {
        set => SetProperty("tiering_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOntapVolumeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformExpression FileSystemId => this["file_system_id"];

    /// <summary>
    /// The flexcache_endpoint_type attribute.
    /// </summary>
    public TerraformExpression FlexcacheEndpointType => this["flexcache_endpoint_type"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}
