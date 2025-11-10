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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    public required TerraformProperty<string> NodeGroupName
    {
        get => GetProperty<TerraformProperty<string>>("node_group_name");
        set => this.WithProperty("node_group_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
