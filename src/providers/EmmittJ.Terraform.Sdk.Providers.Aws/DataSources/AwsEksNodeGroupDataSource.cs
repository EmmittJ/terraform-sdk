using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_node_group.
/// </summary>
public class AwsEksNodeGroupDataSource : TerraformDataSource
{
    public AwsEksNodeGroupDataSource(string name) : base("aws_eks_node_group", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    [TerraformPropertyName("node_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeGroupName { get; set; }

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
    /// The ami_type attribute.
    /// </summary>
    [TerraformPropertyName("ami_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AmiType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ami_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("capacity_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CapacityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "capacity_type");

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformPropertyName("disk_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_size");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InstanceTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "instance_types");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformPropertyName("launch_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LaunchTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "launch_template");

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("node_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_role_arn");

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformPropertyName("release_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReleaseVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_version");

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    [TerraformPropertyName("remote_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RemoteAccess => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "remote_access");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Resources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resources");

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    [TerraformPropertyName("scaling_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScalingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scaling_config");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The taints attribute.
    /// </summary>
    [TerraformPropertyName("taints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Taints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "taints");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
