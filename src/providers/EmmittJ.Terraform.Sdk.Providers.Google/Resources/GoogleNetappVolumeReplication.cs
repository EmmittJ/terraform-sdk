using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_volume_parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleNetappVolumeReplicationDestinationVolumeParametersBlock : ITerraformBlock
{
    /// <summary>
    /// Description for the destination volume.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Share name for destination volume. If not specified, name of source volume&#39;s share name will be used.
    /// </summary>
    [TerraformPropertyName("share_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ShareName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "share_name");

    /// <summary>
    /// Name of an existing storage pool for the destination volume with format: &#39;projects/{{project}}/locations/{{location}}/storagePools/{{poolId}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePool is required")]
    [TerraformPropertyName("storage_pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StoragePool { get; set; }

    /// <summary>
    /// Name for the destination volume to be created. If not specified, the name of the source volume will be used.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_id");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappVolumeReplicationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? DeleteDestinationVolume { get; set; }

    /// <summary>
    /// An description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Only replications with mirror_state=MIRRORED can be stopped. A replication in mirror_state=TRANSFERRING
    /// currently receives an update and stopping the update might be undesirable. Set this parameter to true
    /// to stop anyway. All data transferred to the destination will be discarded and content of destination
    /// volume will remain at the state of the last successful update. Default is false.
    /// </summary>
    [TerraformPropertyName("force_stopping")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceStopping { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Name of region for this resource. The resource needs to be created in the region of the destination volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the replication. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Set to false to stop/break the mirror. Stopping the mirror makes the destination volume read-write
    /// and act independently from the source volume.
    /// Set to true to enable/resume the mirror. WARNING: Resuming a mirror overwrites any changes
    /// done to the destination volume with the content of the source volume.
    /// </summary>
    [TerraformPropertyName("replication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReplicationEnabled { get; set; }

    /// <summary>
    /// Specifies the replication interval. Possible values: [&amp;quot;EVERY_10_MINUTES&amp;quot;, &amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSchedule is required")]
    [TerraformPropertyName("replication_schedule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationSchedule { get; set; }

    /// <summary>
    /// The name of the existing source volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    [TerraformPropertyName("volume_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VolumeName { get; set; }

    /// <summary>
    /// Replication resource state is independent of mirror_state. With enough data, it can take many hours
    /// for mirror_state to reach MIRRORED. If you want Terraform to wait for the mirror to finish on
    /// create/stop/resume operations, set this parameter to true. Default is false.
    /// </summary>
    [TerraformPropertyName("wait_for_mirror")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForMirror { get; set; }

    /// <summary>
    /// Block for destination_volume_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationVolumeParameters block(s) allowed")]
    [TerraformPropertyName("destination_volume_parameters")]
    public TerraformList<TerraformBlock<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock>>? DestinationVolumeParameters { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappVolumeReplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Full resource name of destination volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformPropertyName("destination_volume")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestinationVolume => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_volume");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Condition of the relationship. Can be one of the following:
    ///   - true: The replication relationship is healthy. It has not missed the most recent scheduled transfer.
    ///   - false: The replication relationship is not healthy. It has missed the most recent scheduled transfer.
    /// </summary>
    [TerraformPropertyName("healthy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Healthy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "healthy");

    /// <summary>
    /// HybridPeeringDetails contains details about the hybrid peering.
    /// </summary>
    [TerraformPropertyName("hybrid_peering_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HybridPeeringDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hybrid_peering_details");

    /// <summary>
    /// Hybrid replication type.
    /// </summary>
    [TerraformPropertyName("hybrid_replication_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HybridReplicationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hybrid_replication_type");

    /// <summary>
    /// Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
    /// </summary>
    [TerraformPropertyName("hybrid_replication_user_commands")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HybridReplicationUserCommands => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hybrid_replication_user_commands");

    /// <summary>
    /// Indicates the state of the mirror between source and destination volumes. Depending on the amount of data
    /// in your source volume, PREPARING phase can take hours or days. mirrorState = MIRRORED indicates your baseline
    /// transfer ended and destination volume became accessible read-only. TRANSFERRING means a MIRRORED volume
    /// currently receives an update. Updated every 5 minutes.
    /// </summary>
    [TerraformPropertyName("mirror_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MirrorState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mirror_state");

    /// <summary>
    /// Reverting a replication can swap source and destination volume roles. This field indicates if the &#39;location&#39; hosts
    /// the source or destination volume. For resume and revert and resume operations it is critical to understand
    /// which volume is the source volume, since it will overwrite changes done to the destination volume.
    /// </summary>
    [TerraformPropertyName("role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Role => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role");

    /// <summary>
    /// Full resource name of source volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    [TerraformPropertyName("source_volume")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceVolume => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_volume");

    /// <summary>
    /// Indicates the state of replication resource. State of the mirror itself is indicated in mirrorState.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// State details of the replication resource.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_details");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Replication transfer statistics. All statistics are updated every 5 minutes.
    /// </summary>
    [TerraformPropertyName("transfer_stats")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TransferStats => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "transfer_stats");

}
