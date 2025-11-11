using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupLaunchTemplateBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for node_repair_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupNodeRepairConfigBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for remote_access in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupRemoteAccessBlock
{
    /// <summary>
    /// The ec2_ssh_key attribute.
    /// </summary>
    [TerraformPropertyName("ec2_ssh_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ec2SshKey { get; set; }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceSecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupScalingConfigBlock
{
    /// <summary>
    /// The desired_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredSize is required")]
    [TerraformPropertyName("desired_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DesiredSize { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformPropertyName("max_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformPropertyName("min_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinSize { get; set; }

}

/// <summary>
/// Block type for taint in .
/// Nesting mode: set
/// </summary>
public class AwsEksNodeGroupTaintBlock
{
    /// <summary>
    /// The effect attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    [TerraformPropertyName("effect")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Effect { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksNodeGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for update_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupUpdateConfigBlock
{
    /// <summary>
    /// The max_unavailable attribute.
    /// </summary>
    [TerraformPropertyName("max_unavailable")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxUnavailable { get; set; }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_unavailable_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxUnavailablePercentage { get; set; }

}

/// <summary>
/// Manages a aws_eks_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEksNodeGroup : TerraformResource
{
    public AwsEksNodeGroup(string name) : base("aws_eks_node_group", name)
    {
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    [TerraformPropertyName("ami_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AmiType { get; set; } = default!;

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("capacity_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CapacityType { get; set; } = default!;

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformPropertyName("disk_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSize { get; set; } = default!;

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformPropertyName("force_update_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> InstanceTypes { get; set; } = default!;

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [TerraformPropertyName("node_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeGroupName { get; set; } = default!;

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("node_group_name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeGroupNamePrefix { get; set; } = default!;

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    [TerraformPropertyName("node_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformPropertyName("release_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReleaseVersion { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for node_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    [TerraformPropertyName("node_repair_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupNodeRepairConfigBlock>>? NodeRepairConfig { get; set; }

    /// <summary>
    /// Block for remote_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    [TerraformPropertyName("remote_access")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupRemoteAccessBlock>>? RemoteAccess { get; set; }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformPropertyName("scaling_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupScalingConfigBlock>>? ScalingConfig { get; set; }

    /// <summary>
    /// Block for taint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    [TerraformPropertyName("taint")]
    public TerraformSet<TerraformBlock<AwsEksNodeGroupTaintBlock>>? Taint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEksNodeGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for update_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    [TerraformPropertyName("update_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupUpdateConfigBlock>>? UpdateConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Resources => new TerraformReference(this, "resources");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
