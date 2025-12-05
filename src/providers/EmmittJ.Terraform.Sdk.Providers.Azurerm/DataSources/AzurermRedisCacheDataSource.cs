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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        => CreateReference("access_keys_authentication_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => CreateReference("capacity");

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string> Family
        => CreateReference("family");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => CreateReference("hostname");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
        => CreateReference("minimum_tls_version");

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformValue<bool> NonSslPortEnabled
        => CreateReference("non_ssl_port_enabled");

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PatchSchedule
        => CreateReference("patch_schedule");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => CreateReference("primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => CreateReference("primary_connection_string");

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateStaticIpAddress
        => CreateReference("private_static_ip_address");

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisConfiguration
        => CreateReference("redis_configuration");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => CreateReference("secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => CreateReference("secondary_connection_string");

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double> ShardCount
        => CreateReference("shard_count");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformValue<double> SslPort
        => CreateReference("ssl_port");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisCacheDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisCacheDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
