using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memorystore_instance.
/// </summary>
public class GoogleMemorystoreInstanceDataSource : TerraformDataSource
{
    public GoogleMemorystoreInstanceDataSource(string name) : base("google_memorystore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorization_mode");
        this.DeclareOutput("automated_backup_config");
        this.DeclareOutput("available_maintenance_versions");
        this.DeclareOutput("backup_collection");
        this.DeclareOutput("create_time");
        this.DeclareOutput("cross_instance_replication_config");
        this.DeclareOutput("deletion_protection_enabled");
        this.DeclareOutput("desired_auto_created_endpoints");
        this.DeclareOutput("desired_psc_auto_connections");
        this.DeclareOutput("discovery_endpoints");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("effective_maintenance_version");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("engine_configs");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("gcs_source");
        this.DeclareOutput("kms_key");
        this.DeclareOutput("labels");
        this.DeclareOutput("maintenance_policy");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("maintenance_version");
        this.DeclareOutput("managed_backup_source");
        this.DeclareOutput("managed_server_ca");
        this.DeclareOutput("mode");
        this.DeclareOutput("name");
        this.DeclareOutput("node_config");
        this.DeclareOutput("node_type");
        this.DeclareOutput("persistence_config");
        this.DeclareOutput("psc_attachment_details");
        this.DeclareOutput("psc_auto_connections");
        this.DeclareOutput("replica_count");
        this.DeclareOutput("shard_count");
        this.DeclareOutput("state");
        this.DeclareOutput("state_info");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("transit_encryption_mode");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("zone_distribution_config");
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    public TerraformExpression AuthorizationMode => this["authorization_mode"];

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    public TerraformExpression AutomatedBackupConfig => this["automated_backup_config"];

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
    /// Cross instance replication config
    /// </summary>
    public TerraformExpression CrossInstanceReplicationConfig => this["cross_instance_replication_config"];

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    public TerraformExpression DeletionProtectionEnabled => this["deletion_protection_enabled"];

    /// <summary>
    /// Immutable. User inputs for the auto-created endpoints connections.
    /// </summary>
    public TerraformExpression DesiredAutoCreatedEndpoints => this["desired_auto_created_endpoints"];

    /// <summary>
    /// &#39;desired_psc_auto_connections&#39; is deprecated  Use &#39;desired_auto_created_endpoints&#39; instead &#39;terraform import&#39; will only work with desired_auto_created_endpoints&#39;.
    /// </summary>
    public TerraformExpression DesiredPscAutoConnections => this["desired_psc_auto_connections"];

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
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    public TerraformExpression EngineConfigs => this["engine_configs"];

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// GCS source for the instance.
    /// </summary>
    public TerraformExpression GcsSource => this["gcs_source"];

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    public TerraformExpression KmsKey => this["kms_key"];

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    public TerraformExpression MaintenancePolicy => this["maintenance_policy"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformExpression MaintenanceVersion => this["maintenance_version"];

    /// <summary>
    /// Managed backup source for the instance.
    /// </summary>
    public TerraformExpression ManagedBackupSource => this["managed_backup_source"];

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    public TerraformExpression ManagedServerCa => this["managed_server_ca"];

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    public TerraformExpression Mode => this["mode"];

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
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// </summary>
    public TerraformExpression PersistenceConfig => this["persistence_config"];

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    public TerraformExpression PscAttachmentDetails => this["psc_attachment_details"];

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    public TerraformExpression PscAutoConnections => this["psc_auto_connections"];

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    public TerraformExpression ReplicaCount => this["replica_count"];

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    public TerraformExpression ShardCount => this["shard_count"];

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
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    public TerraformExpression TransitEncryptionMode => this["transit_encryption_mode"];

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// </summary>
    public TerraformExpression ZoneDistributionConfig => this["zone_distribution_config"];

}
