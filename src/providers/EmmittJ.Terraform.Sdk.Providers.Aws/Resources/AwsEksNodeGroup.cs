using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_template in AwsEksNodeGroup.
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for node_repair_config in AwsEksNodeGroup.
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupNodeRepairConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_repair_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for remote_access in AwsEksNodeGroup.
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupRemoteAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_access";

    /// <summary>
    /// The ec2_ssh_key attribute.
    /// </summary>
    public TerraformValue<string>? Ec2SshKey
    {
        get => GetArgument<TerraformValue<string>>("ec2_ssh_key");
        set => SetArgument("ec2_ssh_key", value);
    }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SourceSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("source_security_group_ids");
        set => SetArgument("source_security_group_ids", value);
    }

}


/// <summary>
/// Block type for scaling_config in AwsEksNodeGroup.
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_config";

    /// <summary>
    /// The desired_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredSize is required")]
    public required TerraformValue<double> DesiredSize
    {
        get => GetArgument<TerraformValue<double>>("desired_size");
        set => SetArgument("desired_size", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformValue<double> MaxSize
    {
        get => GetArgument<TerraformValue<double>>("max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformValue<double> MinSize
    {
        get => GetArgument<TerraformValue<double>>("min_size");
        set => SetArgument("min_size", value);
    }

}


/// <summary>
/// Block type for taint in AwsEksNodeGroup.
/// Nesting mode: set
/// </summary>
public class AwsEksNodeGroupTaintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "taint";

    /// <summary>
    /// The effect attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => GetArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEksNodeGroup.
/// Nesting mode: single
/// </summary>
public class AwsEksNodeGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for update_config in AwsEksNodeGroup.
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupUpdateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "update_config";

    /// <summary>
    /// The max_unavailable attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnavailable
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable");
        set => SetArgument("max_unavailable", value);
    }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnavailablePercentage
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable_percentage");
        set => SetArgument("max_unavailable_percentage", value);
    }

}


/// <summary>
/// Represents a aws_eks_node_group Terraform resource.
/// Manages a aws_eks_node_group resource.
/// </summary>
public partial class AwsEksNodeGroup(string name) : TerraformResource("aws_eks_node_group", name)
{
    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformValue<string>? AmiType
    {
        get => GetArgument<TerraformValue<string>>("ami_type");
        set => SetArgument("ami_type", value);
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformValue<string>? CapacityType
    {
        get => GetArgument<TerraformValue<string>>("capacity_type");
        set => SetArgument("capacity_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformValue<double>? DiskSize
    {
        get => GetArgument<TerraformValue<double>>("disk_size");
        set => SetArgument("disk_size", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformValue<bool>? ForceUpdateVersion
    {
        get => GetArgument<TerraformValue<bool>>("force_update_version");
        set => SetArgument("force_update_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformList<string>? InstanceTypes
    {
        get => GetArgument<TerraformList<string>>("instance_types");
        set => SetArgument("instance_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    public TerraformValue<string>? NodeGroupName
    {
        get => GetArgument<TerraformValue<string>>("node_group_name");
        set => SetArgument("node_group_name", value);
    }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NodeGroupNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("node_group_name_prefix");
        set => SetArgument("node_group_name_prefix", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    public required TerraformValue<string> NodeRoleArn
    {
        get => GetArgument<TerraformValue<string>>("node_role_arn");
        set => SetArgument("node_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseVersion
    {
        get => GetArgument<TerraformValue<string>>("release_version");
        set => SetArgument("release_version", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
        => AsReference("resources");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public TerraformList<AwsEksNodeGroupLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetArgument<TerraformList<AwsEksNodeGroupLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

    /// <summary>
    /// NodeRepairConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    public TerraformList<AwsEksNodeGroupNodeRepairConfigBlock>? NodeRepairConfig
    {
        get => GetArgument<TerraformList<AwsEksNodeGroupNodeRepairConfigBlock>>("node_repair_config");
        set => SetArgument("node_repair_config", value);
    }

    /// <summary>
    /// RemoteAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    public TerraformList<AwsEksNodeGroupRemoteAccessBlock>? RemoteAccess
    {
        get => GetArgument<TerraformList<AwsEksNodeGroupRemoteAccessBlock>>("remote_access");
        set => SetArgument("remote_access", value);
    }

    /// <summary>
    /// ScalingConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public required TerraformList<AwsEksNodeGroupScalingConfigBlock> ScalingConfig
    {
        get => GetRequiredArgument<TerraformList<AwsEksNodeGroupScalingConfigBlock>>("scaling_config");
        set => SetArgument("scaling_config", value);
    }

    /// <summary>
    /// Taint block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    public TerraformSet<AwsEksNodeGroupTaintBlock>? Taint
    {
        get => GetArgument<TerraformSet<AwsEksNodeGroupTaintBlock>>("taint");
        set => SetArgument("taint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksNodeGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksNodeGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpdateConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    public TerraformList<AwsEksNodeGroupUpdateConfigBlock>? UpdateConfig
    {
        get => GetArgument<TerraformList<AwsEksNodeGroupUpdateConfigBlock>>("update_config");
        set => SetArgument("update_config", value);
    }

}
