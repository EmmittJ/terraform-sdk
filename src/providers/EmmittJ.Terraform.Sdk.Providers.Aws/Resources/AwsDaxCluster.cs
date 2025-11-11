using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsDaxClusterServerSideEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDaxClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_dax_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDaxCluster : TerraformResource
{
    public AwsDaxCluster(string name) : base("aws_dax_cluster", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// The cluster_endpoint_encryption_type attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint_encryption_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClusterEndpointEncryptionType { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformProperty("iam_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaintenanceWindow { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformProperty("notification_topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ParameterGroupName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    [TerraformProperty("replication_factor")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ReplicationFactor { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubnetGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformProperty("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDaxClusterServerSideEncryptionBlock>>? ServerSideEncryption { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDaxClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformProperty("cluster_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterAddress { get; }

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformProperty("configuration_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigurationEndpoint { get; }

    /// <summary>
    /// The nodes attribute.
    /// </summary>
    [TerraformProperty("nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Nodes { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

}
