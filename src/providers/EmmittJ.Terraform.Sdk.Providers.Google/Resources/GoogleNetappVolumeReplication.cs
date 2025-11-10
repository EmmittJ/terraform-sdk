using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_volume_parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleNetappVolumeReplicationDestinationVolumeParametersBlock : TerraformBlock
{
    /// <summary>
    /// Description for the destination volume.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Share name for destination volume. If not specified, name of source volume&#39;s share name will be used.
    /// </summary>
    public TerraformProperty<string>? ShareName
    {
        set => SetProperty("share_name", value);
    }

    /// <summary>
    /// Name of an existing storage pool for the destination volume with format: &#39;projects/{{project}}/locations/{{location}}/storagePools/{{poolId}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePool is required")]
    public required TerraformProperty<string> StoragePool
    {
        set => SetProperty("storage_pool", value);
    }

    /// <summary>
    /// Name for the destination volume to be created. If not specified, the name of the source volume will be used.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        set => SetProperty("volume_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappVolumeReplicationTimeoutsBlock : TerraformBlock
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
/// Manages a google_netapp_volume_replication resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetappVolumeReplication : TerraformResource
{
    public GoogleNetappVolumeReplication(string name) : base("google_netapp_volume_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("destination_volume");
        SetOutput("effective_labels");
        SetOutput("healthy");
        SetOutput("hybrid_peering_details");
        SetOutput("hybrid_replication_type");
        SetOutput("hybrid_replication_user_commands");
        SetOutput("mirror_state");
        SetOutput("role");
        SetOutput("source_volume");
        SetOutput("state");
        SetOutput("state_details");
        SetOutput("terraform_labels");
        SetOutput("transfer_stats");
        SetOutput("delete_destination_volume");
        SetOutput("description");
        SetOutput("force_stopping");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("replication_enabled");
        SetOutput("replication_schedule");
        SetOutput("volume_name");
        SetOutput("wait_for_mirror");
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
    public TerraformProperty<bool> DeleteDestinationVolume
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_destination_volume");
        set => SetProperty("delete_destination_volume", value);
    }

    /// <summary>
    /// An description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Only replications with mirror_state=MIRRORED can be stopped. A replication in mirror_state=TRANSFERRING
    /// currently receives an update and stopping the update might be undesirable. Set this parameter to true
    /// to stop anyway. All data transferred to the destination will be discarded and content of destination
    /// volume will remain at the state of the last successful update. Default is false.
    /// </summary>
    public TerraformProperty<bool> ForceStopping
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_stopping");
        set => SetProperty("force_stopping", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Name of region for this resource. The resource needs to be created in the region of the destination volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the replication. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Set to false to stop/break the mirror. Stopping the mirror makes the destination volume read-write
    /// and act independently from the source volume.
    /// Set to true to enable/resume the mirror. WARNING: Resuming a mirror overwrites any changes
    /// done to the destination volume with the content of the source volume.
    /// </summary>
    public TerraformProperty<bool> ReplicationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("replication_enabled");
        set => SetProperty("replication_enabled", value);
    }

    /// <summary>
    /// Specifies the replication interval. Possible values: [&amp;quot;EVERY_10_MINUTES&amp;quot;, &amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSchedule is required")]
    public required TerraformProperty<string> ReplicationSchedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_schedule");
        set => SetProperty("replication_schedule", value);
    }

    /// <summary>
    /// The name of the existing source volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformProperty<string> VolumeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_name");
        set => SetProperty("volume_name", value);
    }

    /// <summary>
    /// Replication resource state is independent of mirror_state. With enough data, it can take many hours
    /// for mirror_state to reach MIRRORED. If you want Terraform to wait for the mirror to finish on
    /// create/stop/resume operations, set this parameter to true. Default is false.
    /// </summary>
    public TerraformProperty<bool> WaitForMirror
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_mirror");
        set => SetProperty("wait_for_mirror", value);
    }

    /// <summary>
    /// Block for destination_volume_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationVolumeParameters block(s) allowed")]
    public List<GoogleNetappVolumeReplicationDestinationVolumeParametersBlock>? DestinationVolumeParameters
    {
        set => SetProperty("destination_volume_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappVolumeReplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Full resource name of destination volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    public TerraformExpression DestinationVolume => this["destination_volume"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Condition of the relationship. Can be one of the following:
    ///   - true: The replication relationship is healthy. It has not missed the most recent scheduled transfer.
    ///   - false: The replication relationship is not healthy. It has missed the most recent scheduled transfer.
    /// </summary>
    public TerraformExpression Healthy => this["healthy"];

    /// <summary>
    /// HybridPeeringDetails contains details about the hybrid peering.
    /// </summary>
    public TerraformExpression HybridPeeringDetails => this["hybrid_peering_details"];

    /// <summary>
    /// Hybrid replication type.
    /// </summary>
    public TerraformExpression HybridReplicationType => this["hybrid_replication_type"];

    /// <summary>
    /// Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
    /// </summary>
    public TerraformExpression HybridReplicationUserCommands => this["hybrid_replication_user_commands"];

    /// <summary>
    /// Indicates the state of the mirror between source and destination volumes. Depending on the amount of data
    /// in your source volume, PREPARING phase can take hours or days. mirrorState = MIRRORED indicates your baseline
    /// transfer ended and destination volume became accessible read-only. TRANSFERRING means a MIRRORED volume
    /// currently receives an update. Updated every 5 minutes.
    /// </summary>
    public TerraformExpression MirrorState => this["mirror_state"];

    /// <summary>
    /// Reverting a replication can swap source and destination volume roles. This field indicates if the &#39;location&#39; hosts
    /// the source or destination volume. For resume and revert and resume operations it is critical to understand
    /// which volume is the source volume, since it will overwrite changes done to the destination volume.
    /// </summary>
    public TerraformExpression Role => this["role"];

    /// <summary>
    /// Full resource name of source volume with format: &#39;projects/{{project}}/locations/{{location}}/volumes/{{volumeId}}&#39;
    /// </summary>
    public TerraformExpression SourceVolume => this["source_volume"];

    /// <summary>
    /// Indicates the state of replication resource. State of the mirror itself is indicated in mirrorState.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// State details of the replication resource.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Replication transfer statistics. All statistics are updated every 5 minutes.
    /// </summary>
    public TerraformExpression TransferStats => this["transfer_stats"];

}
