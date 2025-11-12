using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksNodeGroupLaunchTemplateBlock() : TerraformBlock("launch_template")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for node_repair_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksNodeGroupNodeRepairConfigBlock() : TerraformBlock("node_repair_config")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for remote_access in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksNodeGroupRemoteAccessBlock() : TerraformBlock("remote_access")
{
    /// <summary>
    /// The ec2_ssh_key attribute.
    /// </summary>
    [TerraformProperty("ec2_ssh_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ec2SshKey { get; set; }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("source_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SourceSecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksNodeGroupScalingConfigBlock() : TerraformBlock("scaling_config")
{
    /// <summary>
    /// The desired_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredSize is required")]
    [TerraformProperty("desired_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DesiredSize { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformProperty("max_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformProperty("min_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinSize { get; set; }

}

/// <summary>
/// Block type for taint in .
/// Nesting mode: set
/// </summary>
public partial class AwsEksNodeGroupTaintBlock() : TerraformBlock("taint")
{
    /// <summary>
    /// The effect attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    [TerraformProperty("effect")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Effect { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksNodeGroupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for update_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksNodeGroupUpdateConfigBlock() : TerraformBlock("update_config")
{
    /// <summary>
    /// The max_unavailable attribute.
    /// </summary>
    [TerraformProperty("max_unavailable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxUnavailable { get; set; }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    [TerraformProperty("max_unavailable_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxUnavailablePercentage { get; set; }

}

/// <summary>
/// Manages a aws_eks_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEksNodeGroup : TerraformResource
{
    public AwsEksNodeGroup(string name) : base("aws_eks_node_group", name)
    {
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    [TerraformProperty("ami_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AmiType { get; set; }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformProperty("capacity_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CapacityType { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformProperty("disk_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSize { get; set; }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformProperty("force_update_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformProperty("instance_types")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> InstanceTypes { get; set; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [TerraformProperty("node_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeGroupName { get; set; }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    [TerraformProperty("node_group_name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeGroupNamePrefix { get; set; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    [TerraformProperty("node_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformProperty("release_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReleaseVersion { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformProperty("launch_template")]
    public TerraformList<AwsEksNodeGroupLaunchTemplateBlock> LaunchTemplate { get; set; } = new();

    /// <summary>
    /// Block for node_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    [TerraformProperty("node_repair_config")]
    public TerraformList<AwsEksNodeGroupNodeRepairConfigBlock> NodeRepairConfig { get; set; } = new();

    /// <summary>
    /// Block for remote_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    [TerraformProperty("remote_access")]
    public TerraformList<AwsEksNodeGroupRemoteAccessBlock> RemoteAccess { get; set; } = new();

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformProperty("scaling_config")]
    public required TerraformList<AwsEksNodeGroupScalingConfigBlock> ScalingConfig { get; set; } = new();

    /// <summary>
    /// Block for taint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    [TerraformProperty("taint")]
    public TerraformSet<AwsEksNodeGroupTaintBlock> Taint { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEksNodeGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for update_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    [TerraformProperty("update_config")]
    public TerraformList<AwsEksNodeGroupUpdateConfigBlock> UpdateConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Resources { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
