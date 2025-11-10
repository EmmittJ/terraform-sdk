using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for broker_node_group_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlock : TerraformBlock
{
    /// <summary>
    /// The az_distribution attribute.
    /// </summary>
    public TerraformProperty<string>? AzDistribution
    {
        get => GetProperty<TerraformProperty<string>>("az_distribution");
        set => WithProperty("az_distribution", value);
    }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnets is required")]
    public HashSet<TerraformProperty<string>>? ClientSubnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("client_subnets");
        set => WithProperty("client_subnets", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

}

/// <summary>
/// Block type for client_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The unauthenticated attribute.
    /// </summary>
    public TerraformProperty<bool>? Unauthenticated
    {
        get => GetProperty<TerraformProperty<bool>>("unauthenticated");
        set => WithProperty("unauthenticated", value);
    }

}

/// <summary>
/// Block type for configuration_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterConfigurationInfoBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<double> Revision
    {
        get => GetRequiredProperty<TerraformProperty<double>>("revision");
        set => WithProperty("revision", value);
    }

}

/// <summary>
/// Block type for encryption_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterEncryptionInfoBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_at_rest_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionAtRestKmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("encryption_at_rest_kms_key_arn");
        set => WithProperty("encryption_at_rest_kms_key_arn", value);
    }

}

/// <summary>
/// Block type for logging_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlock : TerraformBlock
{
}

/// <summary>
/// Block type for open_monitoring in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_msk_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskCluster : TerraformResource
{
    public AwsMskCluster(string name) : base("aws_msk_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("bootstrap_brokers");
        this.WithOutput("bootstrap_brokers_public_sasl_iam");
        this.WithOutput("bootstrap_brokers_public_sasl_scram");
        this.WithOutput("bootstrap_brokers_public_tls");
        this.WithOutput("bootstrap_brokers_sasl_iam");
        this.WithOutput("bootstrap_brokers_sasl_scram");
        this.WithOutput("bootstrap_brokers_tls");
        this.WithOutput("bootstrap_brokers_vpc_connectivity_sasl_iam");
        this.WithOutput("bootstrap_brokers_vpc_connectivity_sasl_scram");
        this.WithOutput("bootstrap_brokers_vpc_connectivity_tls");
        this.WithOutput("cluster_uuid");
        this.WithOutput("current_version");
        this.WithOutput("zookeeper_connect_string");
        this.WithOutput("zookeeper_connect_string_tls");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The enhanced_monitoring attribute.
    /// </summary>
    public TerraformProperty<string>? EnhancedMonitoring
    {
        get => GetProperty<TerraformProperty<string>>("enhanced_monitoring");
        set => this.WithProperty("enhanced_monitoring", value);
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
    /// The kafka_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaVersion is required")]
    public required TerraformProperty<string> KafkaVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kafka_version");
        set => this.WithProperty("kafka_version", value);
    }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfBrokerNodes is required")]
    public required TerraformProperty<double> NumberOfBrokerNodes
    {
        get => GetRequiredProperty<TerraformProperty<double>>("number_of_broker_nodes");
        set => this.WithProperty("number_of_broker_nodes", value);
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
    /// The storage_mode attribute.
    /// </summary>
    public TerraformProperty<string>? StorageMode
    {
        get => GetProperty<TerraformProperty<string>>("storage_mode");
        set => this.WithProperty("storage_mode", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for broker_node_group_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerNodeGroupInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerNodeGroupInfo block(s) allowed")]
    public List<AwsMskClusterBrokerNodeGroupInfoBlock>? BrokerNodeGroupInfo
    {
        get => GetProperty<List<AwsMskClusterBrokerNodeGroupInfoBlock>>("broker_node_group_info");
        set => this.WithProperty("broker_node_group_info", value);
    }

    /// <summary>
    /// Block for client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    public List<AwsMskClusterClientAuthenticationBlock>? ClientAuthentication
    {
        get => GetProperty<List<AwsMskClusterClientAuthenticationBlock>>("client_authentication");
        set => this.WithProperty("client_authentication", value);
    }

    /// <summary>
    /// Block for configuration_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationInfo block(s) allowed")]
    public List<AwsMskClusterConfigurationInfoBlock>? ConfigurationInfo
    {
        get => GetProperty<List<AwsMskClusterConfigurationInfoBlock>>("configuration_info");
        set => this.WithProperty("configuration_info", value);
    }

    /// <summary>
    /// Block for encryption_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInfo block(s) allowed")]
    public List<AwsMskClusterEncryptionInfoBlock>? EncryptionInfo
    {
        get => GetProperty<List<AwsMskClusterEncryptionInfoBlock>>("encryption_info");
        set => this.WithProperty("encryption_info", value);
    }

    /// <summary>
    /// Block for logging_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingInfo block(s) allowed")]
    public List<AwsMskClusterLoggingInfoBlock>? LoggingInfo
    {
        get => GetProperty<List<AwsMskClusterLoggingInfoBlock>>("logging_info");
        set => this.WithProperty("logging_info", value);
    }

    /// <summary>
    /// Block for open_monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenMonitoring block(s) allowed")]
    public List<AwsMskClusterOpenMonitoringBlock>? OpenMonitoring
    {
        get => GetProperty<List<AwsMskClusterOpenMonitoringBlock>>("open_monitoring");
        set => this.WithProperty("open_monitoring", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMskClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMskClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokers => this["bootstrap_brokers"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslIam => this["bootstrap_brokers_public_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslScram => this["bootstrap_brokers_public_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicTls => this["bootstrap_brokers_public_tls"];

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslIam => this["bootstrap_brokers_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslScram => this["bootstrap_brokers_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersTls => this["bootstrap_brokers_tls"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslIam => this["bootstrap_brokers_vpc_connectivity_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslScram => this["bootstrap_brokers_vpc_connectivity_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivityTls => this["bootstrap_brokers_vpc_connectivity_tls"];

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformExpression ClusterUuid => this["cluster_uuid"];

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectString => this["zookeeper_connect_string"];

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectStringTls => this["zookeeper_connect_string_tls"];

}
