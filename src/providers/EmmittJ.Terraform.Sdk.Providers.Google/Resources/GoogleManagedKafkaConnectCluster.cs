using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterCapacityConfigBlock : TerraformBlock
{
    /// <summary>
    /// The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    public required TerraformProperty<string> MemoryBytes
    {
        get => GetRequiredProperty<TerraformProperty<string>>("memory_bytes");
        set => WithProperty("memory_bytes", value);
    }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    public required TerraformProperty<string> VcpuCount
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vcpu_count");
        set => WithProperty("vcpu_count", value);
    }

}

/// <summary>
/// Block type for gcp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectClusterGcpConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaConnectClusterTimeoutsBlock : TerraformBlock
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
/// Manages a google_managed_kafka_connect_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleManagedKafkaConnectCluster : TerraformResource
{
    public GoogleManagedKafkaConnectCluster(string name) : base("google_managed_kafka_connect_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("name");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The ID to use for the Connect Cluster, which will become the final component of the connect cluster&#39;s name. This value is structured like: &#39;my-connect-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectClusterId is required")]
    public required TerraformProperty<string> ConnectClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connect_cluster_id");
        set => this.WithProperty("connect_cluster_id", value);
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
    /// The name of the Kafka cluster this Kafka Connect cluster is attached to. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    public required TerraformProperty<string> KafkaCluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kafka_cluster");
        set => this.WithProperty("kafka_cluster", value);
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
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    public List<GoogleManagedKafkaConnectClusterCapacityConfigBlock>? CapacityConfig
    {
        get => GetProperty<List<GoogleManagedKafkaConnectClusterCapacityConfigBlock>>("capacity_config");
        set => this.WithProperty("capacity_config", value);
    }

    /// <summary>
    /// Block for gcp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    public List<GoogleManagedKafkaConnectClusterGcpConfigBlock>? GcpConfig
    {
        get => GetProperty<List<GoogleManagedKafkaConnectClusterGcpConfigBlock>>("gcp_config");
        set => this.WithProperty("gcp_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleManagedKafkaConnectClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleManagedKafkaConnectClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The name of the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the connect cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
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
