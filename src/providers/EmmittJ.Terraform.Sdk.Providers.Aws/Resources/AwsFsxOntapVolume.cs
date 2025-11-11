using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aggregate_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOntapVolumeAggregateConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The aggregates attribute.
    /// </summary>
    [TerraformProperty("aggregates")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Aggregates { get; set; }

    /// <summary>
    /// The constituents_per_aggregate attribute.
    /// </summary>
    [TerraformProperty("constituents_per_aggregate")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ConstituentsPerAggregate { get; set; }


}

/// <summary>
/// Block type for snaplock_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOntapVolumeSnaplockConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The audit_log_volume attribute.
    /// </summary>
    [TerraformProperty("audit_log_volume")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AuditLogVolume { get; set; }

    /// <summary>
    /// The privileged_delete attribute.
    /// </summary>
    [TerraformProperty("privileged_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivilegedDelete { get; set; }

    /// <summary>
    /// The snaplock_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnaplockType is required")]
    [TerraformProperty("snaplock_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SnaplockType { get; set; }

    /// <summary>
    /// The volume_append_mode_enabled attribute.
    /// </summary>
    [TerraformProperty("volume_append_mode_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VolumeAppendModeEnabled { get; set; }

}

/// <summary>
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOntapVolumeTieringPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The cooling_period attribute.
    /// </summary>
    [TerraformProperty("cooling_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> CoolingPeriod { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxOntapVolumeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_ontap_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxOntapVolume : TerraformResource
{
    public AwsFsxOntapVolume(string name) : base("aws_fsx_ontap_volume", name)
    {
    }

    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    [TerraformProperty("bypass_snaplock_enterprise_retention")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BypassSnaplockEnterpriseRetention { get; set; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_backups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToBackups { get; set; }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    [TerraformProperty("final_backup_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? FinalBackupTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    [TerraformProperty("junction_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JunctionPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    [TerraformProperty("ontap_volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OntapVolumeType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformProperty("security_style")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityStyle { get; set; }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("size_in_bytes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SizeInBytes { get; set; }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    [TerraformProperty("size_in_megabytes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SizeInMegabytes { get; set; }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformProperty("skip_final_backup")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipFinalBackup { get; set; }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    [TerraformProperty("snapshot_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotPolicy { get; set; }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    [TerraformProperty("storage_efficiency_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StorageEfficiencyEnabled { get; set; }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineId is required")]
    [TerraformProperty("storage_virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageVirtualMachineId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The volume_style attribute.
    /// </summary>
    [TerraformProperty("volume_style")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeStyle { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeType { get; set; }

    /// <summary>
    /// Block for aggregate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregateConfiguration block(s) allowed")]
    [TerraformProperty("aggregate_configuration")]
    public partial TerraformList<TerraformBlock<AwsFsxOntapVolumeAggregateConfigurationBlock>>? AggregateConfiguration { get; set; }

    /// <summary>
    /// Block for snaplock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnaplockConfiguration block(s) allowed")]
    [TerraformProperty("snaplock_configuration")]
    public partial TerraformList<TerraformBlock<AwsFsxOntapVolumeSnaplockConfigurationBlock>>? SnaplockConfiguration { get; set; }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    [TerraformProperty("tiering_policy")]
    public partial TerraformList<TerraformBlock<AwsFsxOntapVolumeTieringPolicyBlock>>? TieringPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFsxOntapVolumeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileSystemId { get; }

    /// <summary>
    /// The flexcache_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("flexcache_endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FlexcacheEndpointType { get; }

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uuid { get; }

}
