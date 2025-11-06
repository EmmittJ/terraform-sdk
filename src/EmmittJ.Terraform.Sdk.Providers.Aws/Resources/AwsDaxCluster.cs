using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dax_cluster resource.
/// </summary>
public class AwsDaxCluster : TerraformResource
{
    public AwsDaxCluster(string name) : base("aws_dax_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_address");
        this.DeclareOutput("configuration_endpoint");
        this.DeclareOutput("nodes");
        this.DeclareOutput("port");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<string>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones")?.Value;
        set => this.WithProperty("availability_zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cluster_endpoint_encryption_type attribute.
    /// </summary>
    public string? ClusterEndpointEncryptionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_endpoint_encryption_type")?.Value;
        set => this.WithProperty("cluster_endpoint_encryption_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public string? NotificationTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_topic_arn")?.Value;
        set => this.WithProperty("notification_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public string? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name")?.Value;
        set => this.WithProperty("parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public double? ReplicationFactor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_factor")?.Value;
        set => this.WithProperty("replication_factor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public string? SubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_group_name")?.Value;
        set => this.WithProperty("subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformExpression ClusterAddress => this["cluster_address"];

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformExpression ConfigurationEndpoint => this["configuration_endpoint"];

    /// <summary>
    /// The nodes attribute.
    /// </summary>
    public TerraformExpression Nodes => this["nodes"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

}
