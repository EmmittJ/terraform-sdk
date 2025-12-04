using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in GoogleManagedKafkaCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterCapacityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_config";

    /// <summary>
    /// The memory to provision for the cluster in bytes. The value must be between 1 GiB and 8 GiB per vCPU. Ex. 1024Mi, 4Gi.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    public required TerraformValue<string> MemoryBytes
    {
        get => GetArgument<TerraformValue<string>>("memory_bytes");
        set => SetArgument("memory_bytes", value);
    }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    public required TerraformValue<string> VcpuCount
    {
        get => GetArgument<TerraformValue<string>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}


/// <summary>
/// Block type for gcp_config in GoogleManagedKafkaCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterGcpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcp_config";

    /// <summary>
    /// The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY&#39;.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public required TerraformList<GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlock> AccessConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

}

/// <summary>
/// Block type for access_config in GoogleManagedKafkaClusterGcpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlock : TerraformBlock
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
    public required TerraformList<GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock> NetworkConfigs
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock>>("network_configs");
        set => SetArgument("network_configs", value);
    }

}

/// <summary>
/// Block type for network_configs in GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterGcpConfigBlockAccessConfigBlockNetworkConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configs";

    /// <summary>
    /// Name of the VPC subnet from which the cluster is accessible. Both broker and bootstrap server IP addresses and DNS entries are automatically created in the subnet. There can only be one subnet per network, and the subnet must be located in the same region as the cluster. The project may differ. The name of the subnet must be in the format &#39;projects/PROJECT_ID/regions/REGION/subnetworks/SUBNET&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    public required TerraformValue<string> Subnet
    {
        get => GetArgument<TerraformValue<string>>("subnet");
        set => SetArgument("subnet", value);
    }

}


/// <summary>
/// Block type for rebalance_config in GoogleManagedKafkaCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterRebalanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rebalance_config";

    /// <summary>
    /// The rebalance behavior for the cluster. When not specified, defaults to &#39;NO_REBALANCE&#39;. Possible values: &#39;MODE_UNSPECIFIED&#39;, &#39;NO_REBALANCE&#39;, &#39;AUTO_REBALANCE_ON_SCALE_UP&#39;.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleManagedKafkaCluster.
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaClusterTimeoutsBlock : TerraformBlock
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
/// Block type for tls_config in GoogleManagedKafkaCluster.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_config";

    /// <summary>
    /// The rules for mapping mTLS certificate Distinguished Names (DNs) to shortened principal names for Kafka ACLs. This field corresponds exactly to the ssl.principal.mapping.rules broker config and matches the format and syntax defined in the Apache Kafka documentation. Setting or modifying this field will trigger a rolling restart of the Kafka brokers to apply the change. An empty string means that the default Kafka behavior is used. Example: &#39;RULE:^CN=(.?),OU=ServiceUsers.$/$1@example.com/,DEFAULT&#39;
    /// </summary>
    public TerraformValue<string>? SslPrincipalMappingRules
    {
        get => GetArgument<TerraformValue<string>>("ssl_principal_mapping_rules");
        set => SetArgument("ssl_principal_mapping_rules", value);
    }

    /// <summary>
    /// TrustConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrustConfig block(s) allowed")]
    public TerraformList<GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlock>? TrustConfig
    {
        get => GetArgument<TerraformList<GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlock>>("trust_config");
        set => SetArgument("trust_config", value);
    }

}

/// <summary>
/// Block type for trust_config in GoogleManagedKafkaClusterTlsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust_config";

    /// <summary>
    /// CasConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlockCasConfigsBlock>? CasConfigs
    {
        get => GetArgument<TerraformList<GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlockCasConfigsBlock>>("cas_configs");
        set => SetArgument("cas_configs", value);
    }

}

/// <summary>
/// Block type for cas_configs in GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterTlsConfigBlockTrustConfigBlockCasConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cas_configs";

    /// <summary>
    /// The name of the CA pool to pull CA certificates from. The CA pool does not need to be in the same project or location as the Kafka cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/caPools/CA_POOL_ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    public required TerraformValue<string> CaPool
    {
        get => GetArgument<TerraformValue<string>>("ca_pool");
        set => SetArgument("ca_pool", value);
    }

}


/// <summary>
/// Represents a google_managed_kafka_cluster Terraform resource.
/// Manages a google_managed_kafka_cluster resource.
/// </summary>
public partial class GoogleManagedKafkaCluster(string name) : TerraformResource("google_managed_kafka_cluster", name)
{
    /// <summary>
    /// The ID to use for the cluster, which will become the final component of the cluster&#39;s name. The ID must be 1-63 characters long, and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; to comply with RFC 1035. This value is structured like: &#39;my-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
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
    /// The name of the cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
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
    public required TerraformList<GoogleManagedKafkaClusterCapacityConfigBlock> CapacityConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaClusterCapacityConfigBlock>>("capacity_config");
        set => SetArgument("capacity_config", value);
    }

    /// <summary>
    /// GcpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    public required TerraformList<GoogleManagedKafkaClusterGcpConfigBlock> GcpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleManagedKafkaClusterGcpConfigBlock>>("gcp_config");
        set => SetArgument("gcp_config", value);
    }

    /// <summary>
    /// RebalanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RebalanceConfig block(s) allowed")]
    public TerraformList<GoogleManagedKafkaClusterRebalanceConfigBlock>? RebalanceConfig
    {
        get => GetArgument<TerraformList<GoogleManagedKafkaClusterRebalanceConfigBlock>>("rebalance_config");
        set => SetArgument("rebalance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleManagedKafkaClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleManagedKafkaClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<GoogleManagedKafkaClusterTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<GoogleManagedKafkaClusterTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}
