using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightClusterDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_hdinsight_cluster.
/// </summary>
public class AzurermHdinsightClusterDataSource : TerraformDataSource
{
    public AzurermHdinsightClusterDataSource(string name) : base("azurerm_hdinsight_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHdinsightClusterDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_id");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_version");

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    [TerraformPropertyName("component_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ComponentVersions => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "component_versions");

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("edge_ssh_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeSshEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_ssh_endpoint");

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    [TerraformPropertyName("gateway")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Gateway => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "gateway");

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("https_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpsEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "https_endpoint");

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("kafka_rest_proxy_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KafkaRestProxyEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kafka_rest_proxy_endpoint");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("ssh_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SshEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssh_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformPropertyName("tls_min_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TlsMinVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tls_min_version");

}
