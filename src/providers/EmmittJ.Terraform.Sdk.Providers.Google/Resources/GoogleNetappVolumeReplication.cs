using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_volume_parameters in GoogleNetappVolumeReplication.
/// Nesting mode: list
/// </summary>
public class GoogleNetappVolumeReplicationDestinationVolumeParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_volume_parameters";

    /// <summary>
    /// Description for the destination volume.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Share name for destination volume. If not specified, name of source volume&#39;s share name will be used.
    /// </summary>
    public TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// Name of an existing storage pool for the destination volume with format: &#39;projects/{{project}}/locations/{{location}}/storagePools/{{poolId}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePool is required")]
    public required TerraformValue<string> StoragePool
    {
        get => new TerraformReference<string>(this, "storage_pool");
        set => SetArgument("storage_pool", value);
    }

    /// <summary>
    /// Name for the destination volume to be created. If not specified, the name of the source volume will be used.
    /// </summary>
    public TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// TieringPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public TerraformList<GoogleNetappVolumeReplicationDestinationVolumeParametersBlockTieringPolicyBlock>? TieringPolicy
    {
        get => GetArgument<TerraformList<GoogleNetappVolumeReplicationDestinationVolumeParametersBlockTieringPolicyBlock>>("tiering_policy");
        set => SetArgument("tiering_policy", value);
    }

}

/// <summary>
/// Block type for tiering_policy in GoogleNetappVolumeReplicationDestinationVolumeParametersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetappVolumeReplicationDestinationVolumeParametersBlockTieringPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tiering_policy";

    /// <summary>
    /// Optional. Time in days to mark the volume&#39;s data block as cold and make it eligible for tiering, can be range from 2-183.
    /// Default is 31.
    /// </summary>
    public TerraformValue<double>? CoolingThresholdDays
    {
        get => new TerraformReference<double>(this, "cooling_threshold_days");
        set => SetArgument("cooling_threshold_days", value);
    }

    /// <summary>
    /// Optional. Flag indicating if the volume has tiering policy enable/pause. Default is PAUSED. Default value: &amp;quot;PAUSED&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TierAction
    {
        get => new TerraformReference<string>(this, "tier_action");
        set => SetArgument("tier_action", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetappVolumeReplication.
/// Nesting mode: single
/// </summary>
public class GoogleNetappVolumeReplicationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_netapp_volume_replication Terraform resource.
/// Manages a google_netapp_volume_replication resource.
/// </summary>
public partial class GoogleNetappVolumeReplication(string name) : TerraformResource("google_netapp_volume_replication", name)
{
    /// <summary>
    /// A destination volume is created as part of replication creation. The destination volume will not became
    /// under Terraform management unless you import it manually. If you delete the replication, this volume
    /// will remain.
    /// Setting this parameter to true will delete the *current* destination volume when destroying the
    /// replication. If you reversed the replication direction, this will be your former source volume!
    /// For production use, it is recommended to keep this parameter false to avoid accidental volume
    /// deletion. Handle with care. Default is false.
    /// </summary>
    public TerraformValue<bool>? DeleteDestinationVolume
    {
        get => new TerraformReference<bool>(this, "delete_destination_volume");
        set => SetArgument("delete_destination_volume", value);
    }

    /// <summary>
    /// An description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Only replications with mirror_state=MIRRORED can be stopped. A replication in mirror_state=TRANSFERRING
    /// currently receives an update and stopping the update might be undesirable. Set this parameter to true
    /// to stop anyway. All data transferred to the destination will be discarded and content of destination
    /// volume will remain at the state of the last successful update. Default is false.
    /// </summary>
    public TerraformValue<bool>? ForceStopping
    {
        get => new TerraformReference<bool>(this, "force_stopping");
        set => SetArgument("force_stopping", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of region for this resource. The resource needs to be created in the region of the destination volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the replication. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Set to false to stop/break the mirror. Stopping the mirror makes the destination volume read-write
    /// and act independently from the source volume.
    /// Set to true to enable/resume the mirror. WARNING: Resuming a mirror overwrites any changes
    /// done to the destination volume with the content of the source volume.
    /// </summary>
    public TerraformValue<bool>? ReplicationEnabled
    {
        get => new TerraformReference<bool>(this, "replication_enabled");
        set => SetArgument("replication_enabled", value);
    }

    /// <summary>
    /// Specifies the replication interval. Possible values: [&amp;quot;EVERY_10_MINUTES&amp;quot;, &amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSchedule is required")]
    public required TerraformValue<string> ReplicationSchedule
    {
        get => new TerraformReference<string>(this, "replication_schedule");
        set => SetArgument("replication_schedule", value);
    }

    /// <summary>
    /// The name of the existing source volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => new TerraformReference<string>(this, "volume_name");
        set => SetArgument("volume_name", value);
    }

    /// <summary>
    /// Replication resource state is independent of mirror_state. With enough data, it can take many hours
    /// for mirror_state to reach MIRRORED. If you want Terraform to wait for the mirror to finish on
    /// create/stop/resume operations, set this parameter to true. Default is false.
    /// </summary>
    public TerraformValue<bool>? WaitForMirror
    {
        get => new TerraformReference<bool>(this, "wait_for_mirror");
        set => SetArgument("wait_for_mirror", value);
    }

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Full resource name of destination volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    public TerraformValue<string> DestinationVolume
    {
        get => new TerraformReference<string>(this, "destination_volume");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Condition of the relationship. Can be one of the following:
    ///   - true: The replication relationship is healthy. It has not missed the most recent scheduled transfer.
    ///   - false: The replication relationship is not healthy. It has missed the most recent scheduled transfer.
    /// </summary>
    public TerraformValue<bool> Healthy
    {
        get => new TerraformReference<bool>(this, "healthy");
    }

    /// <summary>
    /// HybridPeeringDetails contains details about the hybrid peering.
    /// </summary>
    public TerraformList<TerraformMap<object>> HybridPeeringDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hybrid_peering_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// Hybrid replication type.
    /// </summary>
    public TerraformValue<string> HybridReplicationType
    {
        get => new TerraformReference<string>(this, "hybrid_replication_type");
    }

    /// <summary>
    /// Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
    /// </summary>
    public TerraformList<TerraformMap<object>> HybridReplicationUserCommands
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hybrid_replication_user_commands").ResolveNodes(ctx));
    }

    /// <summary>
    /// Indicates the state of the mirror between source and destination volumes. Depending on the amount of data
    /// in your source volume, PREPARING phase can take hours or days. mirrorState = MIRRORED indicates your baseline
    /// transfer ended and destination volume became accessible read-only. TRANSFERRING means a MIRRORED volume
    /// currently receives an update. Updated every 5 minutes.
    /// </summary>
    public TerraformValue<string> MirrorState
    {
        get => new TerraformReference<string>(this, "mirror_state");
    }

    /// <summary>
    /// Reverting a replication can swap source and destination volume roles. This field indicates if the &#39;location&#39; hosts
    /// the source or destination volume. For resume and revert and resume operations it is critical to understand
    /// which volume is the source volume, since it will overwrite changes done to the destination volume.
    /// </summary>
    public TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
    }

    /// <summary>
    /// Full resource name of source volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    public TerraformValue<string> SourceVolume
    {
        get => new TerraformReference<string>(this, "source_volume");
    }

    /// <summary>
    /// Indicates the state of replication resource. State of the mirror itself is indicated in mirrorState.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// State details of the replication resource.
    /// </summary>
    public TerraformValue<string> StateDetails
    {
        get => new TerraformReference<string>(this, "state_details");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Replication transfer statistics. All statistics are updated every 5 minutes.
    /// </summary>
    public TerraformList<TerraformMap<object>> TransferStats
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "transfer_stats").ResolveNodes(ctx));
    }

    /// <summary>
    /// DestinationVolumeParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationVolumeParameters block(s) allowed")]
    public TerraformList<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock>? DestinationVolumeParameters
    {
        get => GetArgument<TerraformList<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock>>("destination_volume_parameters");
        set => SetArgument("destination_volume_parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappVolumeReplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappVolumeReplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
