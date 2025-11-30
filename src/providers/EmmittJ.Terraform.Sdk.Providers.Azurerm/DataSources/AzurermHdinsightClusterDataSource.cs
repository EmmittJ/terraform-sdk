using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHdinsightClusterDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_hdinsight_cluster Terraform data source.
/// Retrieves information about a azurerm_hdinsight_cluster.
/// </summary>
public partial class AzurermHdinsightClusterDataSource(string name) : TerraformDataSource("azurerm_hdinsight_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
    }

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    public TerraformMap<string> ComponentVersions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "component_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> EdgeSshEndpoint
    {
        get => new TerraformReference<string>(this, "edge_ssh_endpoint");
    }

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Gateway
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gateway").ResolveNodes(ctx));
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HttpsEndpoint
    {
        get => new TerraformReference<string>(this, "https_endpoint");
    }

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    public TerraformValue<string> KafkaRestProxyEndpoint
    {
        get => new TerraformReference<string>(this, "kafka_rest_proxy_endpoint");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SshEndpoint
    {
        get => new TerraformReference<string>(this, "ssh_endpoint");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformValue<string> TlsMinVersion
    {
        get => new TerraformReference<string>(this, "tls_min_version");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHdinsightClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHdinsightClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
