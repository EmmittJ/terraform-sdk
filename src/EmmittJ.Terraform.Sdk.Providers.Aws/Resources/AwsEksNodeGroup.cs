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
    public TerraformLiteralProperty<string>? AmiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami_type");
        set => this.WithProperty("ami_type", value);
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CapacityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_type");
        set => this.WithProperty("capacity_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DiskSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size");
        set => this.WithProperty("disk_size", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceUpdateVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_update_version");
        set => this.WithProperty("force_update_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? InstanceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("instance_types");
        set => this.WithProperty("instance_types", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_group_name");
        set => this.WithProperty("node_group_name", value);
    }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeGroupNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_group_name_prefix");
        set => this.WithProperty("node_group_name_prefix", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_role_arn");
        set => this.WithProperty("node_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_version");
        set => this.WithProperty("release_version", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
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
