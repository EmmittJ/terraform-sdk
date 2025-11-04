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
    public string? AmiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami_type")?.Value;
        set => this.WithProperty("ami_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public string? CapacityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_type")?.Value;
        set => this.WithProperty("capacity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public double? DiskSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size")?.Value;
        set => this.WithProperty("disk_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public bool? ForceUpdateVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_update_version")?.Value;
        set => this.WithProperty("force_update_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public List<string>? InstanceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("instance_types")?.Value;
        set => this.WithProperty("instance_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    public string? NodeGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_group_name")?.Value;
        set => this.WithProperty("node_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_group_name_prefix attribute.
    /// </summary>
    public string? NodeGroupNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_group_name_prefix")?.Value;
        set => this.WithProperty("node_group_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public string? NodeRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_role_arn")?.Value;
        set => this.WithProperty("node_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public string? ReleaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_version")?.Value;
        set => this.WithProperty("release_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
