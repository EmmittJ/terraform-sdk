using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightClusterDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHdinsightClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterId => new TerraformReference(this, "cluster_id");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterVersion => new TerraformReference(this, "cluster_version");

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    [TerraformPropertyName("component_versions")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ComponentVersions => new TerraformReference(this, "component_versions");

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("edge_ssh_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EdgeSshEndpoint => new TerraformReference(this, "edge_ssh_endpoint");

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    [TerraformPropertyName("gateway")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Gateway => new TerraformReference(this, "gateway");

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("https_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HttpsEndpoint => new TerraformReference(this, "https_endpoint");

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("kafka_rest_proxy_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KafkaRestProxyEndpoint => new TerraformReference(this, "kafka_rest_proxy_endpoint");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("ssh_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SshEndpoint => new TerraformReference(this, "ssh_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tier => new TerraformReference(this, "tier");

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformPropertyName("tls_min_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TlsMinVersion => new TerraformReference(this, "tls_min_version");

}
