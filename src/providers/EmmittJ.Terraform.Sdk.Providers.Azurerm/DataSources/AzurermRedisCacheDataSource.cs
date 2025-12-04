using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRedisCacheDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AccessKeysAuthenticationEnabled
        => AsReference("access_keys_authentication_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => AsReference("capacity");

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string> Family
        => AsReference("family");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
        => AsReference("minimum_tls_version");

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NonSslPortEnabled
        => AsReference("non_ssl_port_enabled");

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PatchSchedule
        => AsReference("patch_schedule");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateStaticIpAddress
        => AsReference("private_static_ip_address");

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisConfiguration
        => AsReference("redis_configuration");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double> ShardCount
        => AsReference("shard_count");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformValue<double> SslPort
        => AsReference("ssl_port");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisCacheDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisCacheDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
