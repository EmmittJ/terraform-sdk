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
        get => GetProperty<List<TerraformProperty<string>>>("aggregates");
        set => WithProperty("aggregates", value);
    }

    /// <summary>
    /// The constituents_per_aggregate attribute.
    /// </summary>
    public TerraformProperty<double>? ConstituentsPerAggregate
    {
        get => GetProperty<TerraformProperty<double>>("constituents_per_aggregate");
        set => WithProperty("constituents_per_aggregate", value);
    }

    /// <summary>
    /// The total_constituents attribute.
    /// </summary>
    public TerraformProperty<double>? TotalConstituents
    {
        get => GetProperty<TerraformProperty<double>>("total_constituents");
        set => WithProperty("total_constituents", value);
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
        get => GetProperty<TerraformProperty<bool>>("audit_log_volume");
        set => WithProperty("audit_log_volume", value);
    }

    /// <summary>
    /// The privileged_delete attribute.
    /// </summary>
    public TerraformProperty<string>? PrivilegedDelete
    {
        get => GetProperty<TerraformProperty<string>>("privileged_delete");
        set => WithProperty("privileged_delete", value);
    }

    /// <summary>
    /// The snaplock_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnaplockType is required")]
    public required TerraformProperty<string> SnaplockType
    {
        get => GetProperty<TerraformProperty<string>>("snaplock_type");
        set => WithProperty("snaplock_type", value);
    }

    /// <summary>
    /// The volume_append_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VolumeAppendModeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("volume_append_mode_enabled");
        set => WithProperty("volume_append_mode_enabled", value);
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
        get => GetProperty<TerraformProperty<double>>("cooling_period");
        set => WithProperty("cooling_period", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("file_system_id");
        this.DeclareOutput("flexcache_endpoint_type");
        this.DeclareOutput("uuid");
    }

    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    public TerraformProperty<bool>? BypassSnaplockEnterpriseRetention
    {
        get => GetProperty<TerraformProperty<bool>>("bypass_snaplock_enterprise_retention");
        set => this.WithProperty("bypass_snaplock_enterprise_retention", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToBackups
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_backups");
        set => this.WithProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? FinalBackupTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => this.WithProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    public TerraformProperty<string>? JunctionPath
    {
        get => GetProperty<TerraformProperty<string>>("junction_path");
        set => this.WithProperty("junction_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? OntapVolumeType
    {
        get => GetProperty<TerraformProperty<string>>("ontap_volume_type");
        set => this.WithProperty("ontap_volume_type", value);
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
    /// The security_style attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityStyle
    {
        get => GetProperty<TerraformProperty<string>>("security_style");
        set => this.WithProperty("security_style", value);
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<string>? SizeInBytes
    {
        get => GetProperty<TerraformProperty<string>>("size_in_bytes");
        set => this.WithProperty("size_in_bytes", value);
    }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    public TerraformProperty<double>? SizeInMegabytes
    {
        get => GetProperty<TerraformProperty<double>>("size_in_megabytes");
        set => this.WithProperty("size_in_megabytes", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalBackup
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_backup");
        set => this.WithProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotPolicy
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_policy");
        set => this.WithProperty("snapshot_policy", value);
    }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEfficiencyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("storage_efficiency_enabled");
        set => this.WithProperty("storage_efficiency_enabled", value);
    }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineId is required")]
    public required TerraformProperty<string> StorageVirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("storage_virtual_machine_id");
        set => this.WithProperty("storage_virtual_machine_id", value);
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
    /// The volume_style attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeStyle
    {
        get => GetProperty<TerraformProperty<string>>("volume_style");
        set => this.WithProperty("volume_style", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => this.WithProperty("volume_type", value);
    }

    /// <summary>
    /// Block for aggregate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregateConfiguration block(s) allowed")]
    public List<AwsFsxOntapVolumeAggregateConfigurationBlock>? AggregateConfiguration
    {
        get => GetProperty<List<AwsFsxOntapVolumeAggregateConfigurationBlock>>("aggregate_configuration");
        set => this.WithProperty("aggregate_configuration", value);
    }

    /// <summary>
    /// Block for snaplock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnaplockConfiguration block(s) allowed")]
    public List<AwsFsxOntapVolumeSnaplockConfigurationBlock>? SnaplockConfiguration
    {
        get => GetProperty<List<AwsFsxOntapVolumeSnaplockConfigurationBlock>>("snaplock_configuration");
        set => this.WithProperty("snaplock_configuration", value);
    }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public List<AwsFsxOntapVolumeTieringPolicyBlock>? TieringPolicy
    {
        get => GetProperty<List<AwsFsxOntapVolumeTieringPolicyBlock>>("tiering_policy");
        set => this.WithProperty("tiering_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOntapVolumeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFsxOntapVolumeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
