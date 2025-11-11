using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_node_group.
/// </summary>
public partial class AwsEksNodeGroupDataSource : TerraformDataSource
{
    public AwsEksNodeGroupDataSource(string name) : base("aws_eks_node_group", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    [TerraformProperty("node_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeGroupName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    [TerraformProperty("ami_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AmiType { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformProperty("capacity_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CapacityType { get; }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformProperty("disk_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DiskSize { get; }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformProperty("instance_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> InstanceTypes { get; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformProperty("launch_template")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LaunchTemplate { get; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformProperty("node_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeRoleArn { get; }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformProperty("release_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReleaseVersion { get; }

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    [TerraformProperty("remote_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RemoteAccess { get; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Resources { get; }

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    [TerraformProperty("scaling_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ScalingConfig { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The taints attribute.
    /// </summary>
    [TerraformProperty("taints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Taints { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
