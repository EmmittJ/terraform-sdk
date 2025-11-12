using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisCacheDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_redis_cache.
/// </summary>
public partial class AzurermRedisCacheDataSource : TerraformDataSource
{
    public AzurermRedisCacheDataSource(string name) : base("azurerm_redis_cache", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermRedisCacheDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("access_keys_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AccessKeysAuthenticationEnabled { get; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Capacity { get; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformProperty("family")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Family { get; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MinimumTlsVersion { get; }

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformProperty("non_ssl_port_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> NonSslPortEnabled { get; }

    /// <summary>
    /// The patch_schedule attribute.
    /// </summary>
    [TerraformProperty("patch_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PatchSchedule { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_static_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateStaticIpAddress { get; }

    /// <summary>
    /// The redis_configuration attribute.
    /// </summary>
    [TerraformProperty("redis_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RedisConfiguration { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ShardCount { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformProperty("ssl_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SslPort { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
