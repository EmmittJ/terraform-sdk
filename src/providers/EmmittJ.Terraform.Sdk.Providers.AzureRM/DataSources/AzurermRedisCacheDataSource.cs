using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_redis_cache Terraform data source.
/// Retrieves information about a azurerm_redis_cache.
/// </summary>
public partial class AzurermRedisCacheDataSource(string name) : TerraformDataSource("azurerm_redis_cache", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AccessKeysAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "access_keys_authentication_enabled");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
    }

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NonSslPortEnabled
    {
        get => new TerraformReference<bool>(this, "non_ssl_port_enabled");
    }

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PatchSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "patch_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateStaticIpAddress
    {
        get => new TerraformReference<string>(this, "private_static_ip_address");
    }

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "redis_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double> ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformValue<double> SslPort
    {
        get => new TerraformReference<double>(this, "ssl_port");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisCacheDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisCacheDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
