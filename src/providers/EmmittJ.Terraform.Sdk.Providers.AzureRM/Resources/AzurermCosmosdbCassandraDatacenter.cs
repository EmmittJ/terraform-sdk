using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbCassandraDatacenterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_datacenter resource.
/// </summary>
public partial class AzurermCosmosdbCassandraDatacenter : TerraformResource
{
    public AzurermCosmosdbCassandraDatacenter(string name) : base("azurerm_cosmosdb_cassandra_datacenter", name)
    {
    }

    /// <summary>
    /// The availability_zones_enabled attribute.
    /// </summary>
    [TerraformProperty("availability_zones_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AvailabilityZonesEnabled { get; set; }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    [TerraformProperty("backup_storage_customer_key_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    [TerraformProperty("base64_encoded_yaml_fragment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Base64EncodedYamlFragment { get; set; }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraClusterId is required")]
    [TerraformProperty("cassandra_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CassandraClusterId { get; set; }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    [TerraformProperty("delegated_management_subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DelegatedManagementSubnetId { get; set; }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    [TerraformProperty("disk_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DiskCount { get; set; }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    [TerraformProperty("disk_sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskSku { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    [TerraformProperty("managed_disk_customer_key_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NodeCount { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCosmosdbCassandraDatacenterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("seed_node_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SeedNodeIpAddresses { get; }

}
