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
    public TerraformLiteralProperty<string>? AuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_method");
        set => this.WithProperty("authentication_method", value);
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ClientCertificatePems
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("client_certificate_pems");
        set => this.WithProperty("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_admin_password");
        set => this.WithProperty("default_admin_password", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DelegatedManagementSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delegated_management_subnet_id");
        set => this.WithProperty("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ExternalGossipCertificatePems
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("external_gossip_certificate_pems");
        set => this.WithProperty("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ExternalSeedNodeIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("external_seed_node_ip_addresses");
        set => this.WithProperty("external_seed_node_ip_addresses", value);
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HoursBetweenBackups
    {
        get => GetProperty<TerraformLiteralProperty<double>>("hours_between_backups");
        set => this.WithProperty("hours_between_backups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The repair_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RepairEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("repair_enabled");
        set => this.WithProperty("repair_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

}
