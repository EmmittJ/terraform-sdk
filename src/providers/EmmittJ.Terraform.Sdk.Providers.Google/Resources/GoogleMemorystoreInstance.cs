using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceAutomatedBackupConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. The default_value is &amp;quot;3024000s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    [TerraformProperty("retention")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Retention { get; set; }

}

/// <summary>
/// Block type for cross_instance_replication_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance role supports the following values:
    /// 1. &#39;INSTANCE_ROLE_UNSPECIFIED&#39;: This is an independent instance that has never participated in cross instance replication. It allows both reads and writes.
    /// 2. &#39;NONE&#39;: This is an independent instance that previously participated in cross instance replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 3. &#39;PRIMARY&#39;: This instance serves as the replication source for secondary instance that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 4. &#39;SECONDARY&#39;: This instance replicates data from the primary instance. It allows only reads. Possible values: [&amp;quot;INSTANCE_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformProperty("instance_role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceRole { get; set; }



}

/// <summary>
/// Block type for desired_auto_created_endpoints in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectId { get; set; }

}

/// <summary>
/// Block type for desired_psc_auto_connections in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectId { get; set; }

}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceGcsSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformProperty("uris")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Uris { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceMaintenancePolicyBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceManagedBackupSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [TerraformProperty("backup")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Backup { get; set; }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstancePersistenceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Current persistence mode. 
    ///  Possible values:
    /// DISABLED
    /// RDB
    /// AOF Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMemorystoreInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceZoneDistributionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE. 
    ///  Possible values:
    ///  MULTI_ZONE
    /// SINGLE_ZONE Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

}

/// <summary>
/// Manages a google_memorystore_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleMemorystoreInstance : TerraformResource
{
    public GoogleMemorystoreInstance(string name) : base("google_memorystore_instance", name)
    {
    }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [TerraformProperty("authorization_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AuthorizationMode { get; set; }

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    [TerraformProperty("engine_configs")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EngineConfigs { get; set; }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Required. The ID to use for the instance, which will become the final component of
    /// the instance&#39;s resource name.
    /// 
    /// This value is subject to the following restrictions:
    /// 
    /// * Must be 4-63 characters in length
    /// * Must begin with a letter or digit
    /// * Must contain only lowercase letters, digits, and hyphens
    /// * Must not end with a hyphen
    /// * Must be unique within a location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaintenanceVersion { get; set; }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ReplicaCount { get; set; }

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    [TerraformProperty("shard_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ShardCount { get; set; }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TransitEncryptionMode { get; set; }

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    [TerraformProperty("automated_backup_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>>? AutomatedBackupConfig { get; set; }

    /// <summary>
    /// Block for cross_instance_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossInstanceReplicationConfig block(s) allowed")]
    [TerraformProperty("cross_instance_replication_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>>? CrossInstanceReplicationConfig { get; set; }

    /// <summary>
    /// Block for desired_auto_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("desired_auto_created_endpoints")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>>? DesiredAutoCreatedEndpoints { get; set; }

    /// <summary>
    /// Block for desired_psc_auto_connections.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("desired_psc_auto_connections")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>>? DesiredPscAutoConnections { get; set; }

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    [TerraformProperty("gcs_source")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceGcsSourceBlock>>? GcsSource { get; set; }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformProperty("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceMaintenancePolicyBlock>>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    [TerraformProperty("managed_backup_source")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceManagedBackupSourceBlock>>? ManagedBackupSource { get; set; }

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    [TerraformProperty("persistence_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstancePersistenceConfigBlock>>? PersistenceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleMemorystoreInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    [TerraformProperty("zone_distribution_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceZoneDistributionConfigBlock>>? ZoneDistributionConfig { get; set; }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    [TerraformProperty("available_maintenance_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailableMaintenanceVersions { get; }

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [TerraformProperty("backup_collection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BackupCollection { get; }

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    [TerraformProperty("discovery_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DiscoveryEndpoints { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    [TerraformProperty("effective_maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EffectiveMaintenanceVersion { get; }

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Endpoints { get; }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformProperty("maintenance_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceSchedule { get; }

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("managed_server_ca")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedServerCa { get; }

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    [TerraformProperty("node_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodeConfig { get; }

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    [TerraformProperty("psc_attachment_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PscAttachmentDetails { get; }

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    [TerraformProperty("psc_auto_connections")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PscAutoConnections { get; }

    /// <summary>
    /// Output only. Current state of the instance. 
    ///  Possible values:
    ///  CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    [TerraformProperty("state_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StateInfo { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
