using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_node_group.
/// </summary>
public class AwsEksNodeGroupDataSource : TerraformDataSource
{
    public AwsEksNodeGroupDataSource(string name) : base("aws_eks_node_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ami_type");
        this.DeclareOutput("arn");
        this.DeclareOutput("capacity_type");
        this.DeclareOutput("disk_size");
        this.DeclareOutput("instance_types");
        this.DeclareOutput("labels");
        this.DeclareOutput("launch_template");
        this.DeclareOutput("node_role_arn");
        this.DeclareOutput("release_version");
        this.DeclareOutput("remote_access");
        this.DeclareOutput("resources");
        this.DeclareOutput("scaling_config");
        this.DeclareOutput("status");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("taints");
        this.DeclareOutput("version");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ami_type attribute.
    /// </summary>
    public TerraformExpression AmiType => this["ami_type"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The capacity_type attribute.
    /// </summary>
    public TerraformExpression CapacityType => this["capacity_type"];

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    public TerraformExpression DiskSize => this["disk_size"];

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformExpression InstanceTypes => this["instance_types"];

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformExpression LaunchTemplate => this["launch_template"];

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformExpression NodeRoleArn => this["node_role_arn"];

    /// <summary>
    /// The release_version attribute.
    /// </summary>
    public TerraformExpression ReleaseVersion => this["release_version"];

    /// <summary>
    /// The remote_access attribute.
    /// </summary>
    public TerraformExpression RemoteAccess => this["remote_access"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

    /// <summary>
    /// The scaling_config attribute.
    /// </summary>
    public TerraformExpression ScalingConfig => this["scaling_config"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The taints attribute.
    /// </summary>
    public TerraformExpression Taints => this["taints"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
