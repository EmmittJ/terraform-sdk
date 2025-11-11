using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraDatacenterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_datacenter resource.
/// </summary>
public class AzurermCosmosdbCassandraDatacenter : TerraformResource
{
    public AzurermCosmosdbCassandraDatacenter(string name) : base("azurerm_cosmosdb_cassandra_datacenter", name)
    {
    }

    /// <summary>
    /// The availability_zones_enabled attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AvailabilityZonesEnabled { get; set; }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    [TerraformPropertyName("backup_storage_customer_key_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    [TerraformPropertyName("base64_encoded_yaml_fragment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Base64EncodedYamlFragment { get; set; }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraClusterId is required")]
    [TerraformPropertyName("cassandra_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CassandraClusterId { get; set; }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    [TerraformPropertyName("delegated_management_subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DelegatedManagementSubnetId { get; set; }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    [TerraformPropertyName("disk_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DiskCount { get; set; }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    [TerraformPropertyName("disk_sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskSku { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_customer_key_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NodeCount { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbCassandraDatacenterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("seed_node_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SeedNodeIpAddresses => new TerraformReference(this, "seed_node_ip_addresses");

}
