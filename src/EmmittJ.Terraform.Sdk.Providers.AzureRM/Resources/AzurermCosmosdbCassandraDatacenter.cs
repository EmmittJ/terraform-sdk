using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("seed_node_ip_addresses");
    }

    /// <summary>
    /// The availability_zones_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AvailabilityZonesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("availability_zones_enabled");
        set => this.WithProperty("availability_zones_enabled", value);
    }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    public TerraformProperty<string>? BackupStorageCustomerKeyUri
    {
        get => GetProperty<TerraformProperty<string>>("backup_storage_customer_key_uri");
        set => this.WithProperty("backup_storage_customer_key_uri", value);
    }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    public TerraformProperty<string>? Base64EncodedYamlFragment
    {
        get => GetProperty<TerraformProperty<string>>("base64_encoded_yaml_fragment");
        set => this.WithProperty("base64_encoded_yaml_fragment", value);
    }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? CassandraClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cassandra_cluster_id");
        set => this.WithProperty("cassandra_cluster_id", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedManagementSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("delegated_management_subnet_id");
        set => this.WithProperty("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    public TerraformProperty<double>? DiskCount
    {
        get => GetProperty<TerraformProperty<double>>("disk_count");
        set => this.WithProperty("disk_count", value);
    }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    public TerraformProperty<string>? DiskSku
    {
        get => GetProperty<TerraformProperty<string>>("disk_sku");
        set => this.WithProperty("disk_sku", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskCustomerKeyUri
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_customer_key_uri");
        set => this.WithProperty("managed_disk_customer_key_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformExpression SeedNodeIpAddresses => this["seed_node_ip_addresses"];

}
