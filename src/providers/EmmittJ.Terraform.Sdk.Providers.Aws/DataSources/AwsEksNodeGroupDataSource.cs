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
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    [TerraformPropertyName("node_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeGroupName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    [TerraformPropertyName("ami_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AmiType => new TerraformReference(this, "ami_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("capacity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CapacityType => new TerraformReference(this, "capacity_type");

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformPropertyName("disk_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskSize => new TerraformReference(this, "disk_size");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InstanceTypes => new TerraformReference(this, "instance_types");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformPropertyName("launch_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LaunchTemplate => new TerraformReference(this, "launch_template");

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("node_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeRoleArn => new TerraformReference(this, "node_role_arn");

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformPropertyName("release_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReleaseVersion => new TerraformReference(this, "release_version");

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    [TerraformPropertyName("remote_access")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RemoteAccess => new TerraformReference(this, "remote_access");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Resources => new TerraformReference(this, "resources");

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    [TerraformPropertyName("scaling_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ScalingConfig => new TerraformReference(this, "scaling_config");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The taints attribute.
    /// </summary>
    [TerraformPropertyName("taints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Taints => new TerraformReference(this, "taints");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
