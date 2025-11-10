using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDaxClusterServerSideEncryptionBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDaxClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_dax_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDaxCluster : TerraformResource
{
    public AwsDaxCluster(string name) : base("aws_dax_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cluster_address");
        SetOutput("configuration_endpoint");
        SetOutput("nodes");
        SetOutput("port");
        SetOutput("availability_zones");
        SetOutput("cluster_endpoint_encryption_type");
        SetOutput("cluster_name");
        SetOutput("description");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("maintenance_window");
        SetOutput("node_type");
        SetOutput("notification_topic_arn");
        SetOutput("parameter_group_name");
        SetOutput("region");
        SetOutput("replication_factor");
        SetOutput("security_group_ids");
        SetOutput("subnet_group_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AvailabilityZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("availability_zones");
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The cluster_endpoint_encryption_type attribute.
    /// </summary>
    public TerraformProperty<string> ClusterEndpointEncryptionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_endpoint_encryption_type");
        set => SetProperty("cluster_endpoint_encryption_type", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
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
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_window");
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> NotificationTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_topic_arn");
        set => SetProperty("notification_topic_arn", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_name");
        set => SetProperty("parameter_group_name", value);
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
    /// The replication_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    public required TerraformProperty<double> ReplicationFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replication_factor");
        set => SetProperty("replication_factor", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> SubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_group_name");
        set => SetProperty("subnet_group_name", value);
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
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsDaxClusterServerSideEncryptionBlock>? ServerSideEncryption
    {
        set => SetProperty("server_side_encryption", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDaxClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
