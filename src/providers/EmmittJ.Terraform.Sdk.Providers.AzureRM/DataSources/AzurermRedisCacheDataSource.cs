using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_redis_cache.
/// </summary>
public class AzurermRedisCacheDataSource : TerraformDataSource
{
    public AzurermRedisCacheDataSource(string name) : base("azurerm_redis_cache", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedisCacheDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("access_keys_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AccessKeysAuthenticationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "access_keys_authentication_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Capacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "capacity");

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformPropertyName("family")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Family => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "family");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinimumTlsVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minimum_tls_version");

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformPropertyName("non_ssl_port_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> NonSslPortEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "non_ssl_port_enabled");

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    [TerraformPropertyName("patch_schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PatchSchedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "patch_schedule");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_static_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateStaticIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_static_ip_address");

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    [TerraformPropertyName("redis_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RedisConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "redis_configuration");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ShardCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "shard_count");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformPropertyName("ssl_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SslPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ssl_port");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
