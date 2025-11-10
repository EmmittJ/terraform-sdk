using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_cluster.
/// </summary>
public class AwsMemorydbClusterDataSource : TerraformDataSource
{
    public AwsMemorydbClusterDataSource(string name) : base("aws_memorydb_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [TerraformPropertyName("acl_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AclName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "acl_name");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoMinorVersionUpgrade => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_minor_version_upgrade");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterEndpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_endpoint");

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    [TerraformPropertyName("data_tiering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DataTiering => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "data_tiering");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Engine => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_patch_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnginePatchVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_patch_version");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FinalSnapshotName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "final_snapshot_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    [TerraformPropertyName("num_replicas_per_shard")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumReplicasPerShard => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_replicas_per_shard");

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformPropertyName("num_shards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumShards => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_shards");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParameterGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    [TerraformPropertyName("shards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Shards => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "shards");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SnapshotRetentionLimit => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_window");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnsTopicArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sns_topic_arn");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_group_name");

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TlsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tls_enabled");

}
