using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memorystore_instance.
/// </summary>
public partial class GoogleMemorystoreInstanceDataSource : TerraformDataSource
{
    public GoogleMemorystoreInstanceDataSource(string name) : base("google_memorystore_instance", name)
    {
    }

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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [TerraformProperty("authorization_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AuthorizationMode { get; }

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    [TerraformProperty("automated_backup_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutomatedBackupConfig { get; }

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
    /// Cross instance replication config
    /// </summary>
    [TerraformProperty("cross_instance_replication_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CrossInstanceReplicationConfig { get; }

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtectionEnabled { get; }

    /// <summary>
    /// Immutable. User inputs for the auto-created endpoints connections.
    /// </summary>
    [TerraformProperty("desired_auto_created_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DesiredAutoCreatedEndpoints { get; }

    /// <summary>
    /// &#39;desired_psc_auto_connections&#39; is deprecated  Use &#39;desired_auto_created_endpoints&#39; instead &#39;terraform import&#39; will only work with desired_auto_created_endpoints&#39;.
    /// </summary>
    [TerraformProperty("desired_psc_auto_connections")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DesiredPscAutoConnections { get; }

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
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    [TerraformProperty("engine_configs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EngineConfigs { get; }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// GCS source for the instance.
    /// </summary>
    [TerraformProperty("gcs_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GcsSource { get; }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    [TerraformProperty("kms_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKey { get; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    [TerraformProperty("maintenance_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenancePolicy { get; }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformProperty("maintenance_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceSchedule { get; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MaintenanceVersion { get; }

    /// <summary>
    /// Managed backup source for the instance.
    /// </summary>
    [TerraformProperty("managed_backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedBackupSource { get; }

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("managed_server_ca")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedServerCa { get; }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Mode { get; }

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
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeType { get; }

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// </summary>
    [TerraformProperty("persistence_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PersistenceConfig { get; }

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
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ReplicaCount { get; }

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ShardCount { get; }

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
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransitEncryptionMode { get; }

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

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// </summary>
    [TerraformProperty("zone_distribution_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ZoneDistributionConfig { get; }

}
