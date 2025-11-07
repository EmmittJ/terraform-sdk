using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("cluster_id");
        this.DeclareOutput("cluster_version");
        this.DeclareOutput("component_versions");
        this.DeclareOutput("edge_ssh_endpoint");
        this.DeclareOutput("gateway");
        this.DeclareOutput("https_endpoint");
        this.DeclareOutput("kafka_rest_proxy_endpoint");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("ssh_endpoint");
        this.DeclareOutput("tags");
        this.DeclareOutput("tier");
        this.DeclareOutput("tls_min_version");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
