using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_cosmosdb_cassandra_datacenter Terraform resource.
/// Manages a azurerm_cosmosdb_cassandra_datacenter resource.
/// </summary>
public partial class AzurermCosmosdbCassandraDatacenter(string name) : TerraformResource("azurerm_cosmosdb_cassandra_datacenter", name)
{
    /// <summary>
    /// The availability_zones_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AvailabilityZonesEnabled
    {
        get => new TerraformReference<bool>(this, "availability_zones_enabled");
        set => SetArgument("availability_zones_enabled", value);
    }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    public TerraformValue<string>? BackupStorageCustomerKeyUri
    {
        get => new TerraformReference<string>(this, "backup_storage_customer_key_uri");
        set => SetArgument("backup_storage_customer_key_uri", value);
    }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    public TerraformValue<string>? Base64EncodedYamlFragment
    {
        get => new TerraformReference<string>(this, "base64_encoded_yaml_fragment");
        set => SetArgument("base64_encoded_yaml_fragment", value);
    }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraClusterId is required")]
    public required TerraformValue<string> CassandraClusterId
    {
        get => new TerraformReference<string>(this, "cassandra_cluster_id");
        set => SetArgument("cassandra_cluster_id", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    public required TerraformValue<string> DelegatedManagementSubnetId
    {
        get => new TerraformReference<string>(this, "delegated_management_subnet_id");
        set => SetArgument("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    public TerraformValue<double>? DiskCount
    {
        get => new TerraformReference<double>(this, "disk_count");
        set => SetArgument("disk_count", value);
    }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    public TerraformValue<string>? DiskSku
    {
        get => new TerraformReference<string>(this, "disk_sku");
        set => SetArgument("disk_sku", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskCustomerKeyUri
    {
        get => new TerraformReference<string>(this, "managed_disk_customer_key_uri");
        set => SetArgument("managed_disk_customer_key_uri", value);
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
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double>? NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> SeedNodeIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "seed_node_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbCassandraDatacenterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbCassandraDatacenterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
