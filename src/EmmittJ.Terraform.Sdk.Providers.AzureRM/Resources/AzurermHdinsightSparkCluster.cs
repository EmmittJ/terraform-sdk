using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hdinsight_spark_cluster resource.
/// </summary>
public class AzurermHdinsightSparkCluster : TerraformResource
{
    public AzurermHdinsightSparkCluster(string name) : base("azurerm_hdinsight_spark_cluster", name)
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
    public string? ClusterVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_version")?.Value;
        set => this.WithProperty("cluster_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    public bool? EncryptionInTransitEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encryption_in_transit_enabled")?.Value;
        set => this.WithProperty("encryption_in_transit_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public string? TlsMinVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tls_min_version")?.Value;
        set => this.WithProperty("tls_min_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
