using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_volume_parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleNetappVolumeReplicationDestinationVolumeParametersBlock
{
    /// <summary>
    /// Description for the destination volume.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Share name for destination volume. If not specified, name of source volume&#39;s share name will be used.
    /// </summary>
    [TerraformPropertyName("share_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ShareName { get; set; } = default!;

    /// <summary>
    /// Name of an existing storage pool for the destination volume with format: &#39;projects/{{project}}/locations/{{location}}/storagePools/{{poolId}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePool is required")]
    [TerraformPropertyName("storage_pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StoragePool { get; set; }

    /// <summary>
    /// Name for the destination volume to be created. If not specified, the name of the source volume will be used.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VolumeId { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappVolumeReplicationTimeoutsBlock
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
/// Manages a google_netapp_volume_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetappVolumeReplication : TerraformResource
{
    public GoogleNetappVolumeReplication(string name) : base("google_netapp_volume_replication", name)
    {
    }

    /// <summary>
    /// A destination volume is created as part of replication creation. The destination volume will not became
    /// under Terraform management unless you import it manually. If you delete the replication, this volume
    /// will remain.
    /// Setting this parameter to true will delete the *current* destination volume when destroying the
    /// replication. If you reversed the replication direction, this will be your former source volume!
    /// For production use, it is recommended to keep this parameter false to avoid accidental volume
    /// deletion. Handle with care. Default is false.
    /// </summary>
    [TerraformPropertyName("delete_destination_volume")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteDestinationVolume { get; set; }

    /// <summary>
    /// An description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Only replications with mirror_state=MIRRORED can be stopped. A replication in mirror_state=TRANSFERRING
    /// currently receives an update and stopping the update might be undesirable. Set this parameter to true
    /// to stop anyway. All data transferred to the destination will be discarded and content of destination
    /// volume will remain at the state of the last successful update. Default is false.
    /// </summary>
    [TerraformPropertyName("force_stopping")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceStopping { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of region for this resource. The resource needs to be created in the region of the destination volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the replication. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Set to false to stop/break the mirror. Stopping the mirror makes the destination volume read-write
    /// and act independently from the source volume.
    /// Set to true to enable/resume the mirror. WARNING: Resuming a mirror overwrites any changes
    /// done to the destination volume with the content of the source volume.
    /// </summary>
    [TerraformPropertyName("replication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReplicationEnabled { get; set; }

    /// <summary>
    /// Specifies the replication interval. Possible values: [&amp;quot;EVERY_10_MINUTES&amp;quot;, &amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSchedule is required")]
    [TerraformPropertyName("replication_schedule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationSchedule { get; set; }

    /// <summary>
    /// The name of the existing source volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    [TerraformPropertyName("volume_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VolumeName { get; set; }

    /// <summary>
    /// Replication resource state is independent of mirror_state. With enough data, it can take many hours
    /// for mirror_state to reach MIRRORED. If you want Terraform to wait for the mirror to finish on
    /// create/stop/resume operations, set this parameter to true. Default is false.
    /// </summary>
    [TerraformPropertyName("wait_for_mirror")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForMirror { get; set; }

    /// <summary>
    /// Block for destination_volume_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationVolumeParameters block(s) allowed")]
    [TerraformPropertyName("destination_volume_parameters")]
    public TerraformList<TerraformBlock<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock>>? DestinationVolumeParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappVolumeReplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Full resource name of destination volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformPropertyName("destination_volume")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestinationVolume => new TerraformReference(this, "destination_volume");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Condition of the relationship. Can be one of the following:
    ///   - true: The replication relationship is healthy. It has not missed the most recent scheduled transfer.
    ///   - false: The replication relationship is not healthy. It has missed the most recent scheduled transfer.
    /// </summary>
    [TerraformPropertyName("healthy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Healthy => new TerraformReference(this, "healthy");

    /// <summary>
    /// HybridPeeringDetails contains details about the hybrid peering.
    /// </summary>
    [TerraformPropertyName("hybrid_peering_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HybridPeeringDetails => new TerraformReference(this, "hybrid_peering_details");

    /// <summary>
    /// Hybrid replication type.
    /// </summary>
    [TerraformPropertyName("hybrid_replication_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HybridReplicationType => new TerraformReference(this, "hybrid_replication_type");

    /// <summary>
    /// Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
    /// </summary>
    [TerraformPropertyName("hybrid_replication_user_commands")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HybridReplicationUserCommands => new TerraformReference(this, "hybrid_replication_user_commands");

    /// <summary>
    /// Indicates the state of the mirror between source and destination volumes. Depending on the amount of data
    /// in your source volume, PREPARING phase can take hours or days. mirrorState = MIRRORED indicates your baseline
    /// transfer ended and destination volume became accessible read-only. TRANSFERRING means a MIRRORED volume
    /// currently receives an update. Updated every 5 minutes.
    /// </summary>
    [TerraformPropertyName("mirror_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MirrorState => new TerraformReference(this, "mirror_state");

    /// <summary>
    /// Reverting a replication can swap source and destination volume roles. This field indicates if the &#39;location&#39; hosts
    /// the source or destination volume. For resume and revert and resume operations it is critical to understand
    /// which volume is the source volume, since it will overwrite changes done to the destination volume.
    /// </summary>
    [TerraformPropertyName("role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Role => new TerraformReference(this, "role");

    /// <summary>
    /// Full resource name of source volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformPropertyName("source_volume")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceVolume => new TerraformReference(this, "source_volume");

    /// <summary>
    /// Indicates the state of replication resource. State of the mirror itself is indicated in mirrorState.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// State details of the replication resource.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateDetails => new TerraformReference(this, "state_details");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Replication transfer statistics. All statistics are updated every 5 minutes.
    /// </summary>
    [TerraformPropertyName("transfer_stats")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TransferStats => new TerraformReference(this, "transfer_stats");

}
