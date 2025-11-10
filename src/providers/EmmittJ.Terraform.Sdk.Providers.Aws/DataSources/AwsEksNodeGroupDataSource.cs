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
        SetOutput("ami_type");
        SetOutput("arn");
        SetOutput("capacity_type");
        SetOutput("disk_size");
        SetOutput("instance_types");
        SetOutput("labels");
        SetOutput("launch_template");
        SetOutput("node_role_arn");
        SetOutput("release_version");
        SetOutput("remote_access");
        SetOutput("resources");
        SetOutput("scaling_config");
        SetOutput("status");
        SetOutput("subnet_ids");
        SetOutput("taints");
        SetOutput("version");
        SetOutput("cluster_name");
        SetOutput("id");
        SetOutput("node_group_name");
        SetOutput("region");
        SetOutput("tags");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The node_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroupName is required")]
    public required TerraformProperty<string> NodeGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_group_name");
        set => SetProperty("node_group_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
