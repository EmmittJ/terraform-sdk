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
    public TerraformProperty<bool>? AccessKeysAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("access_keys_authentication_enabled");
        set => this.WithProperty("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformProperty<string>? Family
    {
        get => GetProperty<TerraformProperty<string>>("family");
        set => this.WithProperty("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NonSslPortEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("non_ssl_port_enabled");
        set => this.WithProperty("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateStaticIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_static_ip_address");
        set => this.WithProperty("private_static_ip_address", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    public TerraformProperty<string>? RedisVersion
    {
        get => GetProperty<TerraformProperty<string>>("redis_version");
        set => this.WithProperty("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicasPerMaster
    {
        get => GetProperty<TerraformProperty<double>>("replicas_per_master");
        set => this.WithProperty("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicasPerPrimary
    {
        get => GetProperty<TerraformProperty<double>>("replicas_per_primary");
        set => this.WithProperty("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double>? ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tenant_settings attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TenantSettings
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tenant_settings");
        set => this.WithProperty("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
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
