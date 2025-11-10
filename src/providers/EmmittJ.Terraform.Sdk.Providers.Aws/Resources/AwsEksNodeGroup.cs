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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("enabled", value);
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
        set => SetProperty("ec2_ssh_key", value);
    }

    /// <summary>
    /// The source_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SourceSecurityGroupIds
    {
        set => SetProperty("source_security_group_ids", value);
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
        set => SetProperty("desired_size", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformProperty<double> MaxSize
    {
        set => SetProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformProperty<double> MinSize
    {
        set => SetProperty("min_size", value);
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
        set => SetProperty("effect", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("max_unavailable", value);
    }

    /// <summary>
    /// The max_unavailable_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailablePercentage
    {
        set => SetProperty("max_unavailable_percentage", value);
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
        SetOutput("arn");
        SetOutput("resources");
        SetOutput("status");
        SetOutput("ami_type");
        SetOutput("capacity_type");
        SetOutput("cluster_name");
        SetOutput("disk_size");
        SetOutput("force_update_version");
        SetOutput("id");
        SetOutput("instance_types");
        SetOutput("labels");
        SetOutput("node_group_name");
        SetOutput("node_group_name_prefix");
        SetOutput("node_role_arn");
        SetOutput("region");
        SetOutput("release_version");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version");
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformProperty<string> AmiType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ami_type");
        set => SetProperty("ami_type", value);
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformProperty<string> CapacityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_type");
        set => SetProperty("capacity_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformProperty<double> DiskSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size");
        set => SetProperty("disk_size", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformProperty<bool> ForceUpdateVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_update_version");
        set => SetProperty("force_update_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> InstanceTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("instance_types");
        set => SetProperty("instance_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NodeGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_group_name");
        set => SetProperty("node_group_name", value);
    }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NodeGroupNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_group_name_prefix");
        set => SetProperty("node_group_name_prefix", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeRoleArn is required")]
    public required TerraformProperty<string> NodeRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_role_arn");
        set => SetProperty("node_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_version");
        set => SetProperty("release_version", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsEksNodeGroupLaunchTemplateBlock>? LaunchTemplate
    {
        set => SetProperty("launch_template", value);
    }

    /// <summary>
    /// Block for node_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeRepairConfig block(s) allowed")]
    public List<AwsEksNodeGroupNodeRepairConfigBlock>? NodeRepairConfig
    {
        set => SetProperty("node_repair_config", value);
    }

    /// <summary>
    /// Block for remote_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteAccess block(s) allowed")]
    public List<AwsEksNodeGroupRemoteAccessBlock>? RemoteAccess
    {
        set => SetProperty("remote_access", value);
    }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public List<AwsEksNodeGroupScalingConfigBlock>? ScalingConfig
    {
        set => SetProperty("scaling_config", value);
    }

    /// <summary>
    /// Block for taint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Taint block(s) allowed")]
    public HashSet<AwsEksNodeGroupTaintBlock>? Taint
    {
        set => SetProperty("taint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksNodeGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for update_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateConfig block(s) allowed")]
    public List<AwsEksNodeGroupUpdateConfigBlock>? UpdateConfig
    {
        set => SetProperty("update_config", value);
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
