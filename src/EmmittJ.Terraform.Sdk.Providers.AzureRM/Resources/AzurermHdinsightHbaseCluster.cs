using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hdinsight_hbase_cluster resource.
/// </summary>
public class AzurermHdinsightHbaseCluster : TerraformResource
{
    public AzurermHdinsightHbaseCluster(string name) : base("azurerm_hdinsight_hbase_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("https_endpoint");
        this.DeclareOutput("ssh_endpoint");
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_version");
        set => this.WithProperty("cluster_version", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsMinVersion
    {
        get => GetProperty<TerraformProperty<string>>("tls_min_version");
        set => this.WithProperty("tls_min_version", value);
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformExpression HttpsEndpoint => this["https_endpoint"];

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformExpression SshEndpoint => this["ssh_endpoint"];

}
