using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aggregate_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeAggregateConfigurationBlock
{
    /// <summary>
    /// The aggregates attribute.
    /// </summary>
    [TerraformPropertyName("aggregates")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Aggregates { get; set; } = default!;

    /// <summary>
    /// The constituents_per_aggregate attribute.
    /// </summary>
    [TerraformPropertyName("constituents_per_aggregate")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ConstituentsPerAggregate { get; set; } = default!;


}

/// <summary>
/// Block type for snaplock_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeSnaplockConfigurationBlock
{
    /// <summary>
    /// The audit_log_volume attribute.
    /// </summary>
    [TerraformPropertyName("audit_log_volume")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AuditLogVolume { get; set; }

    /// <summary>
    /// The privileged_delete attribute.
    /// </summary>
    [TerraformPropertyName("privileged_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivilegedDelete { get; set; }

    /// <summary>
    /// The snaplock_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnaplockType is required")]
    [TerraformPropertyName("snaplock_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SnaplockType { get; set; }

    /// <summary>
    /// The volume_append_mode_enabled attribute.
    /// </summary>
    [TerraformPropertyName("volume_append_mode_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VolumeAppendModeEnabled { get; set; }

}

/// <summary>
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapVolumeTieringPolicyBlock
{
    /// <summary>
    /// The cooling_period attribute.
    /// </summary>
    [TerraformPropertyName("cooling_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> CoolingPeriod { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapVolumeTimeoutsBlock
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
/// Manages a aws_fsx_ontap_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOntapVolume : TerraformResource
{
    public AwsFsxOntapVolume(string name) : base("aws_fsx_ontap_volume", name)
    {
    }

    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    [TerraformPropertyName("bypass_snaplock_enterprise_retention")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BypassSnaplockEnterpriseRetention { get; set; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_backups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToBackups { get; set; }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    [TerraformPropertyName("final_backup_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? FinalBackupTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    [TerraformPropertyName("junction_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JunctionPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    [TerraformPropertyName("ontap_volume_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OntapVolumeType { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformPropertyName("security_style")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityStyle { get; set; } = default!;

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_bytes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SizeInBytes { get; set; } = default!;

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_megabytes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SizeInMegabytes { get; set; } = default!;

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_backup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipFinalBackup { get; set; }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnapshotPolicy { get; set; } = default!;

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    [TerraformPropertyName("storage_efficiency_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StorageEfficiencyEnabled { get; set; }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineId is required")]
    [TerraformPropertyName("storage_virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageVirtualMachineId { get; set; }

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
    /// The volume_style attribute.
    /// </summary>
    [TerraformPropertyName("volume_style")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VolumeStyle { get; set; } = default!;

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VolumeType { get; set; }

    /// <summary>
    /// Block for aggregate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregateConfiguration block(s) allowed")]
    [TerraformPropertyName("aggregate_configuration")]
    public TerraformList<TerraformBlock<AwsFsxOntapVolumeAggregateConfigurationBlock>>? AggregateConfiguration { get; set; }

    /// <summary>
    /// Block for snaplock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnaplockConfiguration block(s) allowed")]
    [TerraformPropertyName("snaplock_configuration")]
    public TerraformList<TerraformBlock<AwsFsxOntapVolumeSnaplockConfigurationBlock>>? SnaplockConfiguration { get; set; }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    [TerraformPropertyName("tiering_policy")]
    public TerraformList<TerraformBlock<AwsFsxOntapVolumeTieringPolicyBlock>>? TieringPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxOntapVolumeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FileSystemId => new TerraformReference(this, "file_system_id");

    /// <summary>
    /// The flexcache_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("flexcache_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FlexcacheEndpointType => new TerraformReference(this, "flexcache_endpoint_type");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformPropertyName("uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uuid => new TerraformReference(this, "uuid");

}
