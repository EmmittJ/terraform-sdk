using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_volume_parameters in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetappVolumeReplicationDestinationVolumeParametersBlock() : TerraformBlock("destination_volume_parameters")
{
    /// <summary>
    /// Description for the destination volume.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Share name for destination volume. If not specified, name of source volume&#39;s share name will be used.
    /// </summary>
    [TerraformProperty("share_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// Name of an existing storage pool for the destination volume with format: &#39;projects/{{project}}/locations/{{location}}/storagePools/{{poolId}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePool is required")]
    [TerraformProperty("storage_pool")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StoragePool { get; set; }

    /// <summary>
    /// Name for the destination volume to be created. If not specified, the name of the source volume will be used.
    /// </summary>
    [TerraformProperty("volume_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetappVolumeReplicationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_netapp_volume_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetappVolumeReplication : TerraformResource
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
    [TerraformProperty("delete_destination_volume")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteDestinationVolume { get; set; }

    /// <summary>
    /// An description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Only replications with mirror_state=MIRRORED can be stopped. A replication in mirror_state=TRANSFERRING
    /// currently receives an update and stopping the update might be undesirable. Set this parameter to true
    /// to stop anyway. All data transferred to the destination will be discarded and content of destination
    /// volume will remain at the state of the last successful update. Default is false.
    /// </summary>
    [TerraformProperty("force_stopping")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceStopping { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of region for this resource. The resource needs to be created in the region of the destination volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the replication. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Set to false to stop/break the mirror. Stopping the mirror makes the destination volume read-write
    /// and act independently from the source volume.
    /// Set to true to enable/resume the mirror. WARNING: Resuming a mirror overwrites any changes
    /// done to the destination volume with the content of the source volume.
    /// </summary>
    [TerraformProperty("replication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReplicationEnabled { get; set; }

    /// <summary>
    /// Specifies the replication interval. Possible values: [&amp;quot;EVERY_10_MINUTES&amp;quot;, &amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSchedule is required")]
    [TerraformProperty("replication_schedule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationSchedule { get; set; }

    /// <summary>
    /// The name of the existing source volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    [TerraformProperty("volume_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeName { get; set; }

    /// <summary>
    /// Replication resource state is independent of mirror_state. With enough data, it can take many hours
    /// for mirror_state to reach MIRRORED. If you want Terraform to wait for the mirror to finish on
    /// create/stop/resume operations, set this parameter to true. Default is false.
    /// </summary>
    [TerraformProperty("wait_for_mirror")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForMirror { get; set; }

    /// <summary>
    /// Block for destination_volume_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationVolumeParameters block(s) allowed")]
    [TerraformProperty("destination_volume_parameters")]
    public TerraformList<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock> DestinationVolumeParameters { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetappVolumeReplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Full resource name of destination volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformProperty("destination_volume")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationVolume { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Condition of the relationship. Can be one of the following:
    ///   - true: The replication relationship is healthy. It has not missed the most recent scheduled transfer.
    ///   - false: The replication relationship is not healthy. It has missed the most recent scheduled transfer.
    /// </summary>
    [TerraformProperty("healthy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Healthy { get; }

    /// <summary>
    /// HybridPeeringDetails contains details about the hybrid peering.
    /// </summary>
    [TerraformProperty("hybrid_peering_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HybridPeeringDetails { get; }

    /// <summary>
    /// Hybrid replication type.
    /// </summary>
    [TerraformProperty("hybrid_replication_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HybridReplicationType { get; }

    /// <summary>
    /// Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
    /// </summary>
    [TerraformProperty("hybrid_replication_user_commands")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HybridReplicationUserCommands { get; }

    /// <summary>
    /// Indicates the state of the mirror between source and destination volumes. Depending on the amount of data
    /// in your source volume, PREPARING phase can take hours or days. mirrorState = MIRRORED indicates your baseline
    /// transfer ended and destination volume became accessible read-only. TRANSFERRING means a MIRRORED volume
    /// currently receives an update. Updated every 5 minutes.
    /// </summary>
    [TerraformProperty("mirror_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MirrorState { get; }

    /// <summary>
    /// Reverting a replication can swap source and destination volume roles. This field indicates if the &#39;location&#39; hosts
    /// the source or destination volume. For resume and revert and resume operations it is critical to understand
    /// which volume is the source volume, since it will overwrite changes done to the destination volume.
    /// </summary>
    [TerraformProperty("role")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Role { get; }

    /// <summary>
    /// Full resource name of source volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformProperty("source_volume")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceVolume { get; }

    /// <summary>
    /// Indicates the state of replication resource. State of the mirror itself is indicated in mirrorState.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// State details of the replication resource.
    /// </summary>
    [TerraformProperty("state_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateDetails { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Replication transfer statistics. All statistics are updated every 5 minutes.
    /// </summary>
    [TerraformProperty("transfer_stats")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TransferStats { get; }

}
