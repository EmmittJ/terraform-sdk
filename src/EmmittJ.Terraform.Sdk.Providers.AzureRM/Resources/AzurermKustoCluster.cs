using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_cluster resource.
/// </summary>
public class AzurermKustoCluster : TerraformResource
{
    public AzurermKustoCluster(string name) : base("azurerm_kusto_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("data_ingestion_uri");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    public List<string>? AllowedFqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_fqdns")?.Value;
        set => this.WithProperty("allowed_fqdns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    public List<string>? AllowedIpRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_ip_ranges")?.Value;
        set => this.WithProperty("allowed_ip_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    public bool? AutoStopEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_stop_enabled")?.Value;
        set => this.WithProperty("auto_stop_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    public bool? DiskEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disk_encryption_enabled")?.Value;
        set => this.WithProperty("disk_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    public bool? DoubleEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("double_encryption_enabled")?.Value;
        set => this.WithProperty("double_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public bool? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("outbound_network_access_restricted")?.Value;
        set => this.WithProperty("outbound_network_access_restricted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    public string? PublicIpType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_type")?.Value;
        set => this.WithProperty("public_ip_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The purge_enabled attribute.
    /// </summary>
    public bool? PurgeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("purge_enabled")?.Value;
        set => this.WithProperty("purge_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    public bool? StreamingIngestionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("streaming_ingestion_enabled")?.Value;
        set => this.WithProperty("streaming_ingestion_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The trusted_external_tenants attribute.
    /// </summary>
    public List<string>? TrustedExternalTenants
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("trusted_external_tenants")?.Value;
        set => this.WithProperty("trusted_external_tenants", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The data_ingestion_uri attribute.
    /// </summary>
    public TerraformExpression DataIngestionUri => this["data_ingestion_uri"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
