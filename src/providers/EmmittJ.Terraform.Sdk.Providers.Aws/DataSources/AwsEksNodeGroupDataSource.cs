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
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    public required TerraformValue<string> NodeGroupName
    {
        get => new TerraformReference<string>(this, "node_group_name");
        set => SetArgument("node_group_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformValue<string> AmiType
    {
        get => new TerraformReference<string>(this, "ami_type");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformValue<string> CapacityType
    {
        get => new TerraformReference<string>(this, "capacity_type");
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformValue<double> DiskSize
    {
        get => new TerraformReference<double>(this, "disk_size");
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformList<string> InstanceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "instance_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LaunchTemplate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "launch_template").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformValue<string> NodeRoleArn
    {
        get => new TerraformReference<string>(this, "node_role_arn");
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformValue<string> ReleaseVersion
    {
        get => new TerraformReference<string>(this, "release_version");
    }

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteAccess
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "remote_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScalingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scaling_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The taints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Taints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "taints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
