using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in GoogleManagedKafkaConnectCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterCapacityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_config";

    /// <summary>
    /// The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    public required TerraformValue<string> MemoryBytes
    {
        get => GetRequiredArgument<TerraformValue<string>>("memory_bytes");
        set => SetArgument("memory_bytes", value);
    }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    public required TerraformValue<string> VcpuCount
    {
        get => GetRequiredArgument<TerraformValue<string>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}


/// <summary>
/// Block type for gcp_config in GoogleManagedKafkaConnectCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterGcpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_config";

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public required TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlock> AccessConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

}

/// <summary>
/// Block type for access_config in GoogleManagedKafkaConnectClusterGcpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// NetworkConfigs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfigs block(s) required")]
    public required TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock> NetworkConfigs
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock>>("network_configs");
        set => SetArgument("network_configs", value);
    }

}

/// <summary>
/// Block type for network_configs in GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configs";

    /// <summary>
    /// Additional subnets may be specified. They may be in another region, but must be in the same VPC network. The Connect workers can communicate with network endpoints in either the primary or additional subnets.
    /// </summary>
    public TerraformList<string>? AdditionalSubnets
    {
        get => GetArgument<TerraformList<string>>("additional_subnets");
        set => SetArgument("additional_subnets", value);
    }

    /// <summary>
    /// Additional DNS domain names from the subnet&#39;s network to be made visible to the Connect Cluster. When using MirrorMaker2, it&#39;s necessary to add the bootstrap address&#39;s dns domain name of the target cluster to make it visible to the connector. For example: my-kafka-cluster.us-central1.managedkafka.my-project.cloud.goog
    /// </summary>
    public TerraformList<string>? DnsDomainNames
    {
        get => GetArgument<TerraformList<string>>("dns_domain_names");
        set => SetArgument("dns_domain_names", value);
    }

    /// <summary>
    /// VPC subnet to make available to the Kafka Connect cluster. Structured like: projects/{project}/regions/{region}/subnetworks/{subnet_id}. It is used to create a Private Service Connect (PSC) interface for the Kafka Connect workers. It must be located in the same region as the Kafka Connect cluster. The CIDR range of the subnet must be within the IPv4 address ranges for private networks, as specified in RFC 1918. The primary subnet CIDR range must have a minimum size of /22 (1024 addresses).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimarySubnet is required")]
    public required TerraformValue<string> PrimarySubnet
    {
        get => GetRequiredArgument<TerraformValue<string>>("primary_subnet");
        set => SetArgument("primary_subnet", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleManagedKafkaConnectCluster.
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaConnectClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_managed_kafka_connect_cluster Terraform resource.
/// Manages a google_managed_kafka_connect_cluster resource.
/// </summary>
public partial class GoogleManagedKafkaConnectCluster(string name) : TerraformResource("google_managed_kafka_connect_cluster", name)
{
    /// <summary>
    /// The ID to use for the Connect Cluster, which will become the final component of the connect cluster&#39;s name. This value is structured like: &#39;my-connect-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectClusterId is required")]
    public required TerraformValue<string> ConnectClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("connect_cluster_id");
        set => SetArgument("connect_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Kafka cluster this Kafka Connect cluster is attached to. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    public required TerraformValue<string> KafkaCluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("kafka_cluster");
        set => SetArgument("kafka_cluster", value);
    }

    /// <summary>
    /// List of label KEY=VALUE pairs to add. Keys must start with a lowercase character and contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers. Values must contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The name of the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER_ID&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the connect cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The time when the cluster was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// CapacityConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CapacityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfig block(s) allowed")]
    public required TerraformList<GoogleManagedKafkaConnectClusterCapacityConfigBlock> CapacityConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaConnectClusterCapacityConfigBlock>>("capacity_config");
        set => SetArgument("capacity_config", value);
    }

    /// <summary>
    /// GcpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    public required TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlock> GcpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaConnectClusterGcpConfigBlock>>("gcp_config");
        set => SetArgument("gcp_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleManagedKafkaConnectClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleManagedKafkaConnectClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
