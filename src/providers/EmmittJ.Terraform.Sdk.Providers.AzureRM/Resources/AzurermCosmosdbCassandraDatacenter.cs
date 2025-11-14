using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraDatacenterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("availability_zones_enabled")]
    public TerraformValue<bool>? AvailabilityZonesEnabled
    {
        get => new TerraformReference<bool>(this, "availability_zones_enabled");
        set => SetArgument("availability_zones_enabled", value);
    }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    [TerraformArgument("backup_storage_customer_key_uri")]
    public TerraformValue<string>? BackupStorageCustomerKeyUri
    {
        get => new TerraformReference<string>(this, "backup_storage_customer_key_uri");
        set => SetArgument("backup_storage_customer_key_uri", value);
    }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    [TerraformArgument("base64_encoded_yaml_fragment")]
    public TerraformValue<string>? Base64EncodedYamlFragment
    {
        get => new TerraformReference<string>(this, "base64_encoded_yaml_fragment");
        set => SetArgument("base64_encoded_yaml_fragment", value);
    }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraClusterId is required")]
    [TerraformArgument("cassandra_cluster_id")]
    public required TerraformValue<string> CassandraClusterId
    {
        get => new TerraformReference<string>(this, "cassandra_cluster_id");
        set => SetArgument("cassandra_cluster_id", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    [TerraformArgument("delegated_management_subnet_id")]
    public required TerraformValue<string> DelegatedManagementSubnetId
    {
        get => new TerraformReference<string>(this, "delegated_management_subnet_id");
        set => SetArgument("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    [TerraformArgument("disk_count")]
    public TerraformValue<double>? DiskCount
    {
        get => new TerraformReference<double>(this, "disk_count");
        set => SetArgument("disk_count", value);
    }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    [TerraformArgument("disk_sku")]
    public TerraformValue<string>? DiskSku
    {
        get => new TerraformReference<string>(this, "disk_sku");
        set => SetArgument("disk_sku", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    [TerraformArgument("managed_disk_customer_key_uri")]
    public TerraformValue<string>? ManagedDiskCustomerKeyUri
    {
        get => new TerraformReference<string>(this, "managed_disk_customer_key_uri");
        set => SetArgument("managed_disk_customer_key_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformArgument("node_count")]
    public TerraformValue<double>? NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbCassandraDatacenterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("seed_node_ip_addresses")]
    public TerraformList<string> SeedNodeIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "seed_node_ip_addresses").ResolveNodes(ctx));
    }

}
