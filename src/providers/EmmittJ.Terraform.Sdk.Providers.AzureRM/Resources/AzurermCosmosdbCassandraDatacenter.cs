using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraDatacenterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_datacenter resource.
/// </summary>
public class AzurermCosmosdbCassandraDatacenter : TerraformResource
{
    public AzurermCosmosdbCassandraDatacenter(string name) : base("azurerm_cosmosdb_cassandra_datacenter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("seed_node_ip_addresses");
        SetOutput("availability_zones_enabled");
        SetOutput("backup_storage_customer_key_uri");
        SetOutput("base64_encoded_yaml_fragment");
        SetOutput("cassandra_cluster_id");
        SetOutput("delegated_management_subnet_id");
        SetOutput("disk_count");
        SetOutput("disk_sku");
        SetOutput("id");
        SetOutput("location");
        SetOutput("managed_disk_customer_key_uri");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("sku_name");
    }

    /// <summary>
    /// The availability_zones_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AvailabilityZonesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("availability_zones_enabled");
        set => SetProperty("availability_zones_enabled", value);
    }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    public TerraformProperty<string> BackupStorageCustomerKeyUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_storage_customer_key_uri");
        set => SetProperty("backup_storage_customer_key_uri", value);
    }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    public TerraformProperty<string> Base64EncodedYamlFragment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base64_encoded_yaml_fragment");
        set => SetProperty("base64_encoded_yaml_fragment", value);
    }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraClusterId is required")]
    public required TerraformProperty<string> CassandraClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cassandra_cluster_id");
        set => SetProperty("cassandra_cluster_id", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    public required TerraformProperty<string> DelegatedManagementSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delegated_management_subnet_id");
        set => SetProperty("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    public TerraformProperty<double> DiskCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_count");
        set => SetProperty("disk_count", value);
    }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    public TerraformProperty<string> DiskSku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_sku");
        set => SetProperty("disk_sku", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    public TerraformProperty<string> ManagedDiskCustomerKeyUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_disk_customer_key_uri");
        set => SetProperty("managed_disk_customer_key_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbCassandraDatacenterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformExpression SeedNodeIpAddresses => this["seed_node_ip_addresses"];

}
