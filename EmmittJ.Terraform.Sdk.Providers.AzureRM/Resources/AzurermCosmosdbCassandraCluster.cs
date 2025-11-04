using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_cluster resource.
/// </summary>
public class AzurermCosmosdbCassandraCluster : TerraformResource
{
    public AzurermCosmosdbCassandraCluster(string name) : base("azurerm_cosmosdb_cassandra_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public string? AuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_method")?.Value;
        set => this.WithProperty("authentication_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    public List<string>? ClientCertificatePems
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("client_certificate_pems")?.Value;
        set => this.WithProperty("client_certificate_pems", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    public string? DefaultAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_admin_password")?.Value;
        set => this.WithProperty("default_admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public List<string>? ExternalGossipCertificatePems
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("external_gossip_certificate_pems")?.Value;
        set => this.WithProperty("external_gossip_certificate_pems", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public List<string>? ExternalSeedNodeIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("external_seed_node_ip_addresses")?.Value;
        set => this.WithProperty("external_seed_node_ip_addresses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    public double? HoursBetweenBackups
    {
        get => GetProperty<TerraformLiteralProperty<double>>("hours_between_backups")?.Value;
        set => this.WithProperty("hours_between_backups", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repair_enabled attribute.
    /// </summary>
    public bool? RepairEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("repair_enabled")?.Value;
        set => this.WithProperty("repair_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
