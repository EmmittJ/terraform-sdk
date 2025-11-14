using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightClusterDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHdinsightClusterDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformArgument("cluster_id")]
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformArgument("cluster_version")]
    public TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
    }

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    [TerraformArgument("component_versions")]
    public TerraformMap<string> ComponentVersions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "component_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    [TerraformArgument("edge_ssh_endpoint")]
    public TerraformValue<string> EdgeSshEndpoint
    {
        get => new TerraformReference<string>(this, "edge_ssh_endpoint");
    }

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    [TerraformArgument("gateway")]
    public TerraformList<object> Gateway
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "gateway").ResolveNodes(ctx));
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformArgument("https_endpoint")]
    public TerraformValue<string> HttpsEndpoint
    {
        get => new TerraformReference<string>(this, "https_endpoint");
    }

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    [TerraformArgument("kafka_rest_proxy_endpoint")]
    public TerraformValue<string> KafkaRestProxyEndpoint
    {
        get => new TerraformReference<string>(this, "kafka_rest_proxy_endpoint");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformArgument("ssh_endpoint")]
    public TerraformValue<string> SshEndpoint
    {
        get => new TerraformReference<string>(this, "ssh_endpoint");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformArgument("tier")]
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformArgument("tls_min_version")]
    public TerraformValue<string> TlsMinVersion
    {
        get => new TerraformReference<string>(this, "tls_min_version");
    }

}
