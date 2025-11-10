using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for node_repair_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupNodeRepairConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for remote_access in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupRemoteAccessBlock : TerraformBlock
{
    /// <summary>
    /// The ec2_ssh_key attribute.
    /// </summary>
    public TerraformProperty<string>? Ec2SshKey
    {
        get => GetProperty<TerraformProperty<string>>("ec2_ssh_key");
        set => WithProperty("ec2_ssh_key", value);
    }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SourceSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_security_group_ids");
        set => WithProperty("source_security_group_ids", value);
    }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The desired_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredSize is required")]
    public required TerraformProperty<double> DesiredSize
    {
        get => GetProperty<TerraformProperty<double>>("desired_size");
        set => WithProperty("desired_size", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformProperty<double> MaxSize
    {
        get => GetProperty<TerraformProperty<double>>("max_size");
        set => WithProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformProperty<double> MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => WithProperty("min_size", value);
    }

}

/// <summary>
/// Block type for taint in .
/// Nesting mode: set
/// </summary>
public class AwsEksNodeGroupTaintBlock : TerraformBlock
{
    /// <summary>
    /// The effect attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformProperty<string> Effect
    {
        get => GetProperty<TerraformProperty<string>>("effect");
        set => WithProperty("effect", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksNodeGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for update_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksNodeGroupUpdateConfigBlock : TerraformBlock
{
    /// <summary>
    /// The max_unavailable attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailable
    {
        get => GetProperty<TerraformProperty<double>>("max_unavailable");
        set => WithProperty("max_unavailable", value);
    }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailablePercentage
    {
        get => GetProperty<TerraformProperty<double>>("max_unavailable_percentage");
        set => WithProperty("max_unavailable_percentage", value);
    }

}

/// <summary>
/// Manages a aws_eks_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEksNodeGroup : TerraformResource
{
    public AwsEksNodeGroup(string name) : base("aws_eks_node_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("resources");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformProperty<string>? AmiType
    {
        get => GetProperty<TerraformProperty<string>>("ami_type");
        set => this.WithProperty("ami_type", value);
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityType
    {
        get => GetProperty<TerraformProperty<string>>("capacity_type");
        set => this.WithProperty("capacity_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSize
    {
        get => GetProperty<TerraformProperty<double>>("disk_size");
        set => this.WithProperty("disk_size", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceUpdateVersion
    {
        get => GetProperty<TerraformProperty<bool>>("force_update_version");
        set => this.WithProperty("force_update_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InstanceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("instance_types");
        set => this.WithProperty("instance_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NodeGroupName
    {
        get => GetProperty<TerraformProperty<string>>("node_group_name");
        set => this.WithProperty("node_group_name", value);
    }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NodeGroupNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("node_group_name_prefix");
        set => this.WithProperty("node_group_name_prefix", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    public required TerraformProperty<string> NodeRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("node_role_arn");
        set => this.WithProperty("node_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseVersion
    {
        get => GetProperty<TerraformProperty<string>>("release_version");
        set => this.WithProperty("release_version", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsEksNodeGroupLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetProperty<List<AwsEksNodeGroupLaunchTemplateBlock>>("launch_template");
        set => this.WithProperty("launch_template", value);
    }

    /// <summary>
    /// Block for node_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    public List<AwsEksNodeGroupNodeRepairConfigBlock>? NodeRepairConfig
    {
        get => GetProperty<List<AwsEksNodeGroupNodeRepairConfigBlock>>("node_repair_config");
        set => this.WithProperty("node_repair_config", value);
    }

    /// <summary>
    /// Block for remote_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    public List<AwsEksNodeGroupRemoteAccessBlock>? RemoteAccess
    {
        get => GetProperty<List<AwsEksNodeGroupRemoteAccessBlock>>("remote_access");
        set => this.WithProperty("remote_access", value);
    }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public List<AwsEksNodeGroupScalingConfigBlock>? ScalingConfig
    {
        get => GetProperty<List<AwsEksNodeGroupScalingConfigBlock>>("scaling_config");
        set => this.WithProperty("scaling_config", value);
    }

    /// <summary>
    /// Block for taint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    public HashSet<AwsEksNodeGroupTaintBlock>? Taint
    {
        get => GetProperty<HashSet<AwsEksNodeGroupTaintBlock>>("taint");
        set => this.WithProperty("taint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksNodeGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEksNodeGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for update_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    public List<AwsEksNodeGroupUpdateConfigBlock>? UpdateConfig
    {
        get => GetProperty<List<AwsEksNodeGroupUpdateConfigBlock>>("update_config");
        set => this.WithProperty("update_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
