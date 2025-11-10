using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightClusterDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_hdinsight_cluster.
/// </summary>
public class AzurermHdinsightClusterDataSource : TerraformDataSource
{
    public AzurermHdinsightClusterDataSource(string name) : base("azurerm_hdinsight_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_id");
        SetOutput("cluster_version");
        SetOutput("component_versions");
        SetOutput("edge_ssh_endpoint");
        SetOutput("gateway");
        SetOutput("https_endpoint");
        SetOutput("kafka_rest_proxy_endpoint");
        SetOutput("kind");
        SetOutput("location");
        SetOutput("ssh_endpoint");
        SetOutput("tags");
        SetOutput("tier");
        SetOutput("tls_min_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHdinsightClusterDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformExpression ClusterId => this["cluster_id"];

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformExpression ClusterVersion => this["cluster_version"];

    /// <summary>
    /// The component_versions attribute.
    /// </summary>
    public TerraformExpression ComponentVersions => this["component_versions"];

    /// <summary>
    /// The edge_ssh_endpoint attribute.
    /// </summary>
    public TerraformExpression EdgeSshEndpoint => this["edge_ssh_endpoint"];

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    public TerraformExpression Gateway => this["gateway"];

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformExpression HttpsEndpoint => this["https_endpoint"];

    /// <summary>
    /// The kafka_rest_proxy_endpoint attribute.
    /// </summary>
    public TerraformExpression KafkaRestProxyEndpoint => this["kafka_rest_proxy_endpoint"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformExpression SshEndpoint => this["ssh_endpoint"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformExpression Tier => this["tier"];

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformExpression TlsMinVersion => this["tls_min_version"];

}
