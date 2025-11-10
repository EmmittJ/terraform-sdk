using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceAutomatedBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. The default_value is &amp;quot;3024000s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformProperty<string> Retention
    {
        get => GetProperty<TerraformProperty<string>>("retention");
        set => WithProperty("retention", value);
    }

}

/// <summary>
/// Block type for cross_instance_replication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The instance role supports the following values:
    /// 1. &#39;INSTANCE_ROLE_UNSPECIFIED&#39;: This is an independent instance that has never participated in cross instance replication. It allows both reads and writes.
    /// 2. &#39;NONE&#39;: This is an independent instance that previously participated in cross instance replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 3. &#39;PRIMARY&#39;: This instance serves as the replication source for secondary instance that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 4. &#39;SECONDARY&#39;: This instance replicates data from the primary instance. It allows only reads. Possible values: [&amp;quot;INSTANCE_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? InstanceRole
    {
        get => GetProperty<TerraformProperty<string>>("instance_role");
        set => WithProperty("instance_role", value);
    }

    /// <summary>
    /// An output only view of all the member instance participating in cross instance replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// </summary>
    public List<TerraformProperty<object>>? Membership
    {
        get => GetProperty<List<TerraformProperty<object>>>("membership");
        set => WithProperty("membership", value);
    }

    /// <summary>
    /// The last time cross instance replication config was updated.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        get => GetProperty<TerraformProperty<string>>("update_time");
        set => WithProperty("update_time", value);
    }

}

/// <summary>
/// Block type for desired_auto_created_endpoints in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformProperty<string> ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

}

/// <summary>
/// Block type for desired_psc_auto_connections in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformProperty<string> ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceGcsSourceBlock : TerraformBlock
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public HashSet<TerraformProperty<string>>? Uris
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("uris");
        set => WithProperty("uris", value);
    }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformProperty<string>? CreateTime
    {
        get => GetProperty<TerraformProperty<string>>("create_time");
        set => WithProperty("create_time", value);
    }

    /// <summary>
    /// The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        get => GetProperty<TerraformProperty<string>>("update_time");
        set => WithProperty("update_time", value);
    }

}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceManagedBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    public required TerraformProperty<string> Backup
    {
        get => GetProperty<TerraformProperty<string>>("backup");
        set => WithProperty("backup", value);
    }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstancePersistenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Current persistence mode. 
    ///  Possible values:
    /// DISABLED
    /// RDB
    /// AOF Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMemorystoreInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceZoneDistributionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE. 
    ///  Possible values:
    ///  MULTI_ZONE
    /// SINGLE_ZONE Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => WithProperty("zone", value);
    }

}

/// <summary>
/// Manages a google_memorystore_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMemorystoreInstance : TerraformResource
{
    public GoogleMemorystoreInstance(string name) : base("google_memorystore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_maintenance_versions");
        this.DeclareOutput("backup_collection");
        this.DeclareOutput("create_time");
        this.DeclareOutput("discovery_endpoints");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("effective_maintenance_version");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("managed_server_ca");
        this.DeclareOutput("name");
        this.DeclareOutput("node_config");
        this.DeclareOutput("psc_attachment_details");
        this.DeclareOutput("psc_auto_connections");
        this.DeclareOutput("state");
        this.DeclareOutput("state_info");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    public TerraformProperty<string>? AuthorizationMode
    {
        get => GetProperty<TerraformProperty<string>>("authorization_mode");
        set => this.WithProperty("authorization_mode", value);
    }

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EngineConfigs
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("engine_configs");
        set => this.WithProperty("engine_configs", value);
    }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

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
    public required TerraformProperty<string> InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformProperty<string>? MaintenanceVersion
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_version");
        set => this.WithProperty("maintenance_version", value);
    }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    public TerraformProperty<double>? ReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_count");
        set => this.WithProperty("replica_count", value);
    }

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    public required TerraformProperty<double> ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    public TerraformProperty<string>? TransitEncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("transit_encryption_mode");
        set => this.WithProperty("transit_encryption_mode", value);
    }

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    public List<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>? AutomatedBackupConfig
    {
        get => GetProperty<List<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>>("automated_backup_config");
        set => this.WithProperty("automated_backup_config", value);
    }

    /// <summary>
    /// Block for cross_instance_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossInstanceReplicationConfig block(s) allowed")]
    public List<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>? CrossInstanceReplicationConfig
    {
        get => GetProperty<List<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>>("cross_instance_replication_config");
        set => this.WithProperty("cross_instance_replication_config", value);
    }

    /// <summary>
    /// Block for desired_auto_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>? DesiredAutoCreatedEndpoints
    {
        get => GetProperty<List<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>>("desired_auto_created_endpoints");
        set => this.WithProperty("desired_auto_created_endpoints", value);
    }

    /// <summary>
    /// Block for desired_psc_auto_connections.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>? DesiredPscAutoConnections
    {
        get => GetProperty<List<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>>("desired_psc_auto_connections");
        set => this.WithProperty("desired_psc_auto_connections", value);
    }

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    public List<GoogleMemorystoreInstanceGcsSourceBlock>? GcsSource
    {
        get => GetProperty<List<GoogleMemorystoreInstanceGcsSourceBlock>>("gcs_source");
        set => this.WithProperty("gcs_source", value);
    }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public List<GoogleMemorystoreInstanceMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetProperty<List<GoogleMemorystoreInstanceMaintenancePolicyBlock>>("maintenance_policy");
        set => this.WithProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    public List<GoogleMemorystoreInstanceManagedBackupSourceBlock>? ManagedBackupSource
    {
        get => GetProperty<List<GoogleMemorystoreInstanceManagedBackupSourceBlock>>("managed_backup_source");
        set => this.WithProperty("managed_backup_source", value);
    }

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    public List<GoogleMemorystoreInstancePersistenceConfigBlock>? PersistenceConfig
    {
        get => GetProperty<List<GoogleMemorystoreInstancePersistenceConfigBlock>>("persistence_config");
        set => this.WithProperty("persistence_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMemorystoreInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMemorystoreInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    public List<GoogleMemorystoreInstanceZoneDistributionConfigBlock>? ZoneDistributionConfig
    {
        get => GetProperty<List<GoogleMemorystoreInstanceZoneDistributionConfigBlock>>("zone_distribution_config");
        set => this.WithProperty("zone_distribution_config", value);
    }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformExpression AvailableMaintenanceVersions => this["available_maintenance_versions"];

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformExpression BackupCollection => this["backup_collection"];

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    public TerraformExpression DiscoveryEndpoints => this["discovery_endpoints"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformExpression EffectiveMaintenanceVersion => this["effective_maintenance_version"];

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    public TerraformExpression ManagedServerCa => this["managed_server_ca"];

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    public TerraformExpression NodeConfig => this["node_config"];

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    public TerraformExpression PscAttachmentDetails => this["psc_attachment_details"];

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    public TerraformExpression PscAutoConnections => this["psc_auto_connections"];

    /// <summary>
    /// Output only. Current state of the instance. 
    ///  Possible values:
    ///  CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    public TerraformExpression StateInfo => this["state_info"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
