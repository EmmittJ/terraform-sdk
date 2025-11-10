using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterCapacityConfigBlock : TerraformBlock
{
    /// <summary>
    /// The memory to provision for the cluster in bytes. The value must be between 1 GiB and 8 GiB per vCPU. Ex. 1024Mi, 4Gi.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    public required TerraformProperty<string> MemoryBytes
    {
        get => GetProperty<TerraformProperty<string>>("memory_bytes");
        set => WithProperty("memory_bytes", value);
    }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    public required TerraformProperty<string> VcpuCount
    {
        get => GetProperty<TerraformProperty<string>>("vcpu_count");
        set => WithProperty("vcpu_count", value);
    }

}

/// <summary>
/// Block type for gcp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterGcpConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY&#39;.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for rebalance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterRebalanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The rebalance behavior for the cluster. When not specified, defaults to &#39;NO_REBALANCE&#39;. Possible values: &#39;MODE_UNSPECIFIED&#39;, &#39;NO_REBALANCE&#39;, &#39;AUTO_REBALANCE_ON_SCALE_UP&#39;.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaClusterTimeoutsBlock : TerraformBlock
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
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaClusterTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The rules for mapping mTLS certificate Distinguished Names (DNs) to shortened principal names for Kafka ACLs. This field corresponds exactly to the ssl.principal.mapping.rules broker config and matches the format and syntax defined in the Apache Kafka documentation. Setting or modifying this field will trigger a rolling restart of the Kafka brokers to apply the change. An empty string means that the default Kafka behavior is used. Example: &#39;RULE:^CN=(.?),OU=ServiceUsers.$/$1@example.com/,DEFAULT&#39;
    /// </summary>
    public TerraformProperty<string>? SslPrincipalMappingRules
    {
        get => GetProperty<TerraformProperty<string>>("ssl_principal_mapping_rules");
        set => WithProperty("ssl_principal_mapping_rules", value);
    }

}

/// <summary>
/// Manages a google_managed_kafka_cluster resource.
/// </summary>
public class GoogleManagedKafkaCluster : TerraformResource
{
    public GoogleManagedKafkaCluster(string name) : base("google_managed_kafka_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID to use for the cluster, which will become the final component of the cluster&#39;s name. The ID must be 1-63 characters long, and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; to comply with RFC 1035. This value is structured like: &#39;my-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// List of label KEY=VALUE pairs to add. Keys must start with a lowercase character and contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers. Values must contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for capacity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CapacityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfig block(s) allowed")]
    public List<GoogleManagedKafkaClusterCapacityConfigBlock>? CapacityConfig
    {
        get => GetProperty<List<GoogleManagedKafkaClusterCapacityConfigBlock>>("capacity_config");
        set => this.WithProperty("capacity_config", value);
    }

    /// <summary>
    /// Block for gcp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    public List<GoogleManagedKafkaClusterGcpConfigBlock>? GcpConfig
    {
        get => GetProperty<List<GoogleManagedKafkaClusterGcpConfigBlock>>("gcp_config");
        set => this.WithProperty("gcp_config", value);
    }

    /// <summary>
    /// Block for rebalance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RebalanceConfig block(s) allowed")]
    public List<GoogleManagedKafkaClusterRebalanceConfigBlock>? RebalanceConfig
    {
        get => GetProperty<List<GoogleManagedKafkaClusterRebalanceConfigBlock>>("rebalance_config");
        set => this.WithProperty("rebalance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleManagedKafkaClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleManagedKafkaClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<GoogleManagedKafkaClusterTlsConfigBlock>? TlsConfig
    {
        get => GetProperty<List<GoogleManagedKafkaClusterTlsConfigBlock>>("tls_config");
        set => this.WithProperty("tls_config", value);
    }

    /// <summary>
    /// The time when the cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The name of the cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the cluster was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
