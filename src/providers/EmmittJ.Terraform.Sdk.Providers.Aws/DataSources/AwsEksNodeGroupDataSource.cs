using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eks_node_group Terraform data source.
/// Retrieves information about a aws_eks_node_group.
/// </summary>
public partial class AwsEksNodeGroupDataSource(string name) : TerraformDataSource("aws_eks_node_group", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    public required TerraformValue<string> NodeGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_group_name");
        set => SetArgument("node_group_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformValue<string> AmiType
        => CreateReference("ami_type");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformValue<string> CapacityType
        => CreateReference("capacity_type");

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformValue<double> DiskSize
        => CreateReference("disk_size");

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformList<string> InstanceTypes
        => CreateReference("instance_types");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string> Labels
        => CreateReference("labels");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LaunchTemplate
        => CreateReference("launch_template");

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformValue<string> NodeRoleArn
        => CreateReference("node_role_arn");

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformValue<string> ReleaseVersion
        => CreateReference("release_version");

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteAccess
        => CreateReference("remote_access");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
        => CreateReference("resources");

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScalingConfig
        => CreateReference("scaling_config");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => CreateReference("subnet_ids");

    /// <summary>
    /// The taints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Taints
        => CreateReference("taints");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

}
