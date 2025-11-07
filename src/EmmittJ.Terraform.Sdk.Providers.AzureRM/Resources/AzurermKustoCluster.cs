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
    public TerraformLiteralProperty<List<string>>? AllowedFqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_fqdns");
        set => this.WithProperty("allowed_fqdns", value);
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AllowedIpRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_ip_ranges");
        set => this.WithProperty("allowed_ip_ranges", value);
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoStopEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_stop_enabled");
        set => this.WithProperty("auto_stop_enabled", value);
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DiskEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disk_encryption_enabled");
        set => this.WithProperty("disk_encryption_enabled", value);
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DoubleEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("double_encryption_enabled");
        set => this.WithProperty("double_encryption_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("outbound_network_access_restricted");
        set => this.WithProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicIpType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_type");
        set => this.WithProperty("public_ip_type", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PurgeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("purge_enabled");
        set => this.WithProperty("purge_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StreamingIngestionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("streaming_ingestion_enabled");
        set => this.WithProperty("streaming_ingestion_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trusted_external_tenants attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? TrustedExternalTenants
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("trusted_external_tenants");
        set => this.WithProperty("trusted_external_tenants", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
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
