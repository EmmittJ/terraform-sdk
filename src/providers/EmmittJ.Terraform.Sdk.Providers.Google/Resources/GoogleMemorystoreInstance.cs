using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceAutomatedBackupConfigBlock : ITerraformBlock
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. The default_value is &amp;quot;3024000s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    [TerraformPropertyName("retention")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Retention { get; set; }

}

/// <summary>
/// Block type for cross_instance_replication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The instance role supports the following values:
    /// 1. &#39;INSTANCE_ROLE_UNSPECIFIED&#39;: This is an independent instance that has never participated in cross instance replication. It allows both reads and writes.
    /// 2. &#39;NONE&#39;: This is an independent instance that previously participated in cross instance replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 3. &#39;PRIMARY&#39;: This instance serves as the replication source for secondary instance that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 4. &#39;SECONDARY&#39;: This instance replicates data from the primary instance. It allows only reads. Possible values: [&amp;quot;INSTANCE_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("instance_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceRole { get; set; }

    /// <summary>
    /// An output only view of all the member instance participating in cross instance replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// </summary>
    [TerraformPropertyName("membership")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Membership => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "membership");

    /// <summary>
    /// The last time cross instance replication config was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "update_time");

}

/// <summary>
/// Block type for desired_auto_created_endpoints in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformPropertyName("project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectId { get; set; }

}

/// <summary>
/// Block type for desired_psc_auto_connections in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformPropertyName("project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectId { get; set; }

}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceGcsSourceBlock : ITerraformBlock
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformPropertyName("uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Uris { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceMaintenancePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "create_time");

    /// <summary>
    /// The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "update_time");

}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceManagedBackupSourceBlock : ITerraformBlock
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [TerraformPropertyName("backup")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Backup { get; set; }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstancePersistenceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Current persistence mode. 
    ///  Possible values:
    /// DISABLED
    /// RDB
    /// AOF Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMemorystoreInstanceTimeoutsBlock : ITerraformBlock
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
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceZoneDistributionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE. 
    ///  Possible values:
    ///  MULTI_ZONE
    /// SINGLE_ZONE Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

}

/// <summary>
/// Manages a google_memorystore_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMemorystoreInstance : TerraformResource
{
    public GoogleMemorystoreInstance(string name) : base("google_memorystore_instance", name)
    {
    }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [TerraformPropertyName("authorization_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthorizationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorization_mode");

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    [TerraformPropertyName("engine_configs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EngineConfigs { get; set; }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaintenanceVersion { get; set; }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mode");

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReplicaCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replica_count");

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    [TerraformPropertyName("shard_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ShardCount { get; set; }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransitEncryptionMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_encryption_mode");

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    [TerraformPropertyName("automated_backup_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>>? AutomatedBackupConfig { get; set; } = new();

    /// <summary>
    /// Block for cross_instance_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossInstanceReplicationConfig block(s) allowed")]
    [TerraformPropertyName("cross_instance_replication_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>>? CrossInstanceReplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for desired_auto_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("desired_auto_created_endpoints")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>>? DesiredAutoCreatedEndpoints { get; set; } = new();

    /// <summary>
    /// Block for desired_psc_auto_connections.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("desired_psc_auto_connections")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>>? DesiredPscAutoConnections { get; set; } = new();

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    [TerraformPropertyName("gcs_source")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceGcsSourceBlock>>? GcsSource { get; set; } = new();

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceMaintenancePolicyBlock>>? MaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    [TerraformPropertyName("managed_backup_source")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceManagedBackupSourceBlock>>? ManagedBackupSource { get; set; } = new();

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    [TerraformPropertyName("persistence_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstancePersistenceConfigBlock>>? PersistenceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMemorystoreInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    [TerraformPropertyName("zone_distribution_config")]
    public TerraformList<TerraformBlock<GoogleMemorystoreInstanceZoneDistributionConfigBlock>>? ZoneDistributionConfig { get; set; } = new();

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    [TerraformPropertyName("available_maintenance_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailableMaintenanceVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "available_maintenance_versions");

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [TerraformPropertyName("backup_collection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupCollection => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_collection");

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    [TerraformPropertyName("discovery_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DiscoveryEndpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "discovery_endpoints");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    [TerraformPropertyName("effective_maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveMaintenanceVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "effective_maintenance_version");

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Endpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoints");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceSchedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_schedule");

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("managed_server_ca")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedServerCa => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_server_ca");

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    [TerraformPropertyName("node_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_config");

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    [TerraformPropertyName("psc_attachment_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PscAttachmentDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "psc_attachment_details");

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    [TerraformPropertyName("psc_auto_connections")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PscAutoConnections => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "psc_auto_connections");

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
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    [TerraformPropertyName("state_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StateInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "state_info");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
