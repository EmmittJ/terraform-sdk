using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eks_node_group resource.
/// </summary>
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
    public TerraformProperty<string>? ClusterName
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
    public TerraformProperty<List<string>>? InstanceTypes
    {
        get => GetProperty<TerraformProperty<List<string>>>("instance_types");
        set => this.WithProperty("instance_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
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
    public TerraformProperty<string>? NodeRoleArn
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
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
