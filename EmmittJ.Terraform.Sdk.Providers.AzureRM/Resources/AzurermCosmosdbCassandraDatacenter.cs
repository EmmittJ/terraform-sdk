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
    public bool? AvailabilityZonesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("availability_zones_enabled")?.Value;
        set => this.WithProperty("availability_zones_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The backup_storage_customer_key_uri attribute.
    /// </summary>
    public string? BackupStorageCustomerKeyUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_storage_customer_key_uri")?.Value;
        set => this.WithProperty("backup_storage_customer_key_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The base64_encoded_yaml_fragment attribute.
    /// </summary>
    public string? Base64EncodedYamlFragment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base64_encoded_yaml_fragment")?.Value;
        set => this.WithProperty("base64_encoded_yaml_fragment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cassandra_cluster_id attribute.
    /// </summary>
    public string? CassandraClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cassandra_cluster_id")?.Value;
        set => this.WithProperty("cassandra_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    public string? DelegatedManagementSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delegated_management_subnet_id")?.Value;
        set => this.WithProperty("delegated_management_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_count attribute.
    /// </summary>
    public double? DiskCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_count")?.Value;
        set => this.WithProperty("disk_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The disk_sku attribute.
    /// </summary>
    public string? DiskSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_sku")?.Value;
        set => this.WithProperty("disk_sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_disk_customer_key_uri attribute.
    /// </summary>
    public string? ManagedDiskCustomerKeyUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_customer_key_uri")?.Value;
        set => this.WithProperty("managed_disk_customer_key_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformExpression SeedNodeIpAddresses => this["seed_node_ip_addresses"];

}
