using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHdinsightClusterDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_hdinsight_cluster.
/// </summary>
public partial class AzurermHdinsightClusterDataSource : TerraformDataSource
{
    public AzurermHdinsightClusterDataSource(string name) : base("azurerm_hdinsight_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHdinsightClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterId { get; }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformProperty("cluster_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterVersion { get; }

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    [TerraformProperty("component_versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> ComponentVersions { get; }

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    [TerraformProperty("edge_ssh_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EdgeSshEndpoint { get; }

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    [TerraformProperty("gateway")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Gateway { get; }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformProperty("https_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HttpsEndpoint { get; }

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    [TerraformProperty("kafka_rest_proxy_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KafkaRestProxyEndpoint { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformProperty("ssh_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SshEndpoint { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tier { get; }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformProperty("tls_min_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TlsMinVersion { get; }

}
