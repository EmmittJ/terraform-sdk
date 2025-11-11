using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memorystore_instance.
/// </summary>
public class GoogleMemorystoreInstanceDataSource : TerraformDataSource
{
    public GoogleMemorystoreInstanceDataSource(string name) : base("google_memorystore_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [TerraformPropertyName("authorization_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizationMode => new TerraformReference(this, "authorization_mode");

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    [TerraformPropertyName("automated_backup_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutomatedBackupConfig => new TerraformReference(this, "automated_backup_config");

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    [TerraformPropertyName("available_maintenance_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailableMaintenanceVersions => new TerraformReference(this, "available_maintenance_versions");

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [TerraformPropertyName("backup_collection")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupCollection => new TerraformReference(this, "backup_collection");

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Cross instance replication config
    /// </summary>
    [TerraformPropertyName("cross_instance_replication_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CrossInstanceReplicationConfig => new TerraformReference(this, "cross_instance_replication_config");

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtectionEnabled => new TerraformReference(this, "deletion_protection_enabled");

    /// <summary>
    /// Immutable. User inputs for the auto-created endpoints connections.
    /// </summary>
    [TerraformPropertyName("desired_auto_created_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DesiredAutoCreatedEndpoints => new TerraformReference(this, "desired_auto_created_endpoints");

    /// <summary>
    /// &#39;desired_psc_auto_connections&#39; is deprecated  Use &#39;desired_auto_created_endpoints&#39; instead &#39;terraform import&#39; will only work with desired_auto_created_endpoints&#39;.
    /// </summary>
    [TerraformPropertyName("desired_psc_auto_connections")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DesiredPscAutoConnections => new TerraformReference(this, "desired_psc_auto_connections");

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    [TerraformPropertyName("discovery_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DiscoveryEndpoints => new TerraformReference(this, "discovery_endpoints");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    [TerraformPropertyName("effective_maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveMaintenanceVersion => new TerraformReference(this, "effective_maintenance_version");

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Endpoints => new TerraformReference(this, "endpoints");

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    [TerraformPropertyName("engine_configs")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EngineConfigs => new TerraformReference(this, "engine_configs");

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// GCS source for the instance.
    /// </summary>
    [TerraformPropertyName("gcs_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GcsSource => new TerraformReference(this, "gcs_source");

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKey => new TerraformReference(this, "kms_key");

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenancePolicy => new TerraformReference(this, "maintenance_policy");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceSchedule => new TerraformReference(this, "maintenance_schedule");

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceVersion => new TerraformReference(this, "maintenance_version");

    /// <summary>
    /// Managed backup source for the instance.
    /// </summary>
    [TerraformPropertyName("managed_backup_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedBackupSource => new TerraformReference(this, "managed_backup_source");

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("managed_server_ca")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedServerCa => new TerraformReference(this, "managed_server_ca");

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mode => new TerraformReference(this, "mode");

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    [TerraformPropertyName("node_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NodeConfig => new TerraformReference(this, "node_config");

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// </summary>
    [TerraformPropertyName("persistence_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PersistenceConfig => new TerraformReference(this, "persistence_config");

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    [TerraformPropertyName("psc_attachment_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscAttachmentDetails => new TerraformReference(this, "psc_attachment_details");

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    [TerraformPropertyName("psc_auto_connections")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscAutoConnections => new TerraformReference(this, "psc_auto_connections");

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReplicaCount => new TerraformReference(this, "replica_count");

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ShardCount => new TerraformReference(this, "shard_count");

    /// <summary>
    /// Output only. Current state of the instance. 
    ///  Possible values:
    ///  CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    [TerraformPropertyName("state_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StateInfo => new TerraformReference(this, "state_info");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitEncryptionMode => new TerraformReference(this, "transit_encryption_mode");

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// </summary>
    [TerraformPropertyName("zone_distribution_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ZoneDistributionConfig => new TerraformReference(this, "zone_distribution_config");

}
