using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_cache resource.
/// </summary>
public class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base("azurerm_redis_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hostname");
        this.DeclareOutput("port");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("ssl_port");
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public bool? AccessKeysAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("access_keys_authentication_enabled")?.Value;
        set => this.WithProperty("access_keys_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public double? Capacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("capacity")?.Value;
        set => this.WithProperty("capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public string? Family
    {
        get => GetProperty<TerraformLiteralProperty<string>>("family")?.Value;
        set => this.WithProperty("family", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public string? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version")?.Value;
        set => this.WithProperty("minimum_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public bool? NonSslPortEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("non_ssl_port_enabled")?.Value;
        set => this.WithProperty("non_ssl_port_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public string? PrivateStaticIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_static_ip_address")?.Value;
        set => this.WithProperty("private_static_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The redis_version attribute.
    /// </summary>
    public string? RedisVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_version")?.Value;
        set => this.WithProperty("redis_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public double? ReplicasPerMaster
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replicas_per_master")?.Value;
        set => this.WithProperty("replicas_per_master", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public double? ReplicasPerPrimary
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replicas_per_primary")?.Value;
        set => this.WithProperty("replicas_per_primary", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The shard_count attribute.
    /// </summary>
    public double? ShardCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("shard_count")?.Value;
        set => this.WithProperty("shard_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tenant_settings attribute.
    /// </summary>
    public Dictionary<string, string>? TenantSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tenant_settings")?.Value;
        set => this.WithProperty("tenant_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformExpression SslPort => this["ssl_port"];

}
