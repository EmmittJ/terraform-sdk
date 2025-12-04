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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
        => AsReference("cluster_id");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
        => AsReference("cluster_version");

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    public TerraformMap<string> ComponentVersions
        => AsReference("component_versions");

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> EdgeSshEndpoint
        => AsReference("edge_ssh_endpoint");

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Gateway
        => AsReference("gateway");

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HttpsEndpoint
        => AsReference("https_endpoint");

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    public TerraformValue<string> KafkaRestProxyEndpoint
        => AsReference("kafka_rest_proxy_endpoint");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SshEndpoint
        => AsReference("ssh_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
        => AsReference("tier");

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformValue<string> TlsMinVersion
        => AsReference("tls_min_version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHdinsightClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHdinsightClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
