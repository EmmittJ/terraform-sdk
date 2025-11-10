using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDaxClusterServerSideEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDaxClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_dax_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDaxCluster : TerraformResource
{
    public AwsDaxCluster(string name) : base("aws_dax_cluster", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AvailabilityZones { get; set; }

    /// <summary>
    /// The cluster_endpoint_encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint_encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterEndpointEncryptionType { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformPropertyName("iam_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeType { get; set; }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationTopicArn { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    [TerraformPropertyName("replication_factor")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ReplicationFactor { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_group_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDaxClusterServerSideEncryptionBlock>>? ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDaxClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    [TerraformPropertyName("cluster_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("configuration_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_endpoint");

    /// <summary>
    /// The nodes attribute.
    /// </summary>
    [TerraformPropertyName("nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Nodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

}
