using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupLaunchTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for node_repair_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupNodeRepairConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for remote_access in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupRemoteAccessBlock : ITerraformBlock
{
    /// <summary>
    /// The ec2_ssh_key attribute.
    /// </summary>
    [TerraformPropertyName("ec2_ssh_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ec2SshKey { get; set; }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SourceSecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupScalingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The desired_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredSize is required")]
    [TerraformPropertyName("desired_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DesiredSize { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformPropertyName("max_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformPropertyName("min_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinSize { get; set; }

}

/// <summary>
/// Block type for taint in .
/// Nesting mode: set
/// </summary>
public class AwsEksNodeGroupTaintBlock : ITerraformBlock
{
    /// <summary>
    /// The effect attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    [TerraformPropertyName("effect")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Effect { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksNodeGroupTimeoutsBlock : ITerraformBlock
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
/// Block type for update_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupUpdateConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The max_unavailable attribute.
    /// </summary>
    [TerraformPropertyName("max_unavailable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnavailable { get; set; }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_unavailable_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnavailablePercentage { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AmiType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ami_type");

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("capacity_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CapacityType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "capacity_type");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformPropertyName("disk_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_size");

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformPropertyName("force_update_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> InstanceTypes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "instance_types");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [TerraformPropertyName("node_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_group_name");

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("node_group_name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NodeGroupNamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_group_name_prefix");

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    [TerraformPropertyName("node_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    [TerraformPropertyName("release_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReleaseVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_version");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

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
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; } = new();

    /// <summary>
    /// Block for node_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    [TerraformPropertyName("node_repair_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupNodeRepairConfigBlock>>? NodeRepairConfig { get; set; } = new();

    /// <summary>
    /// Block for remote_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    [TerraformPropertyName("remote_access")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupRemoteAccessBlock>>? RemoteAccess { get; set; } = new();

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformPropertyName("scaling_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupScalingConfigBlock>>? ScalingConfig { get; set; } = new();

    /// <summary>
    /// Block for taint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    [TerraformPropertyName("taint")]
    public TerraformSet<TerraformBlock<AwsEksNodeGroupTaintBlock>>? Taint { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEksNodeGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for update_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    [TerraformPropertyName("update_config")]
    public TerraformList<TerraformBlock<AwsEksNodeGroupUpdateConfigBlock>>? UpdateConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Resources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resources");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
