using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_redis_cache.
/// </summary>
public class AzurermRedisCacheDataSource : TerraformDataSource
{
    public AzurermRedisCacheDataSource(string name) : base("azurerm_redis_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_keys_authentication_enabled");
        this.DeclareOutput("capacity");
        this.DeclareOutput("family");
        this.DeclareOutput("hostname");
        this.DeclareOutput("location");
        this.DeclareOutput("minimum_tls_version");
        this.DeclareOutput("non_ssl_port_enabled");
        this.DeclareOutput("patch_schedule");
        this.DeclareOutput("port");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("private_static_ip_address");
        this.DeclareOutput("redis_configuration");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("shard_count");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("ssl_port");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("zones");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisCacheDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRedisCacheDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression AccessKeysAuthenticationEnabled => this["access_keys_authentication_enabled"];

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformExpression Capacity => this["capacity"];

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformExpression Family => this["family"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformExpression MinimumTlsVersion => this["minimum_tls_version"];

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformExpression NonSslPortEnabled => this["non_ssl_port_enabled"];

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    public TerraformExpression PatchSchedule => this["patch_schedule"];

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
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateStaticIpAddress => this["private_static_ip_address"];

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    public TerraformExpression RedisConfiguration => this["redis_configuration"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformExpression ShardCount => this["shard_count"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformExpression SslPort => this["ssl_port"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
