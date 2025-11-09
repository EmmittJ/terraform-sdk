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
    public TerraformProperty<string>? AuthenticationMethod
    {
        get => GetProperty<TerraformProperty<string>>("authentication_method");
        set => this.WithProperty("authentication_method", value);
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ClientCertificatePems
    {
        get => GetProperty<TerraformProperty<List<string>>>("client_certificate_pems");
        set => this.WithProperty("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("default_admin_password");
        set => this.WithProperty("default_admin_password", value);
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
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ExternalGossipCertificatePems
    {
        get => GetProperty<TerraformProperty<List<string>>>("external_gossip_certificate_pems");
        set => this.WithProperty("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ExternalSeedNodeIpAddresses
    {
        get => GetProperty<TerraformProperty<List<string>>>("external_seed_node_ip_addresses");
        set => this.WithProperty("external_seed_node_ip_addresses", value);
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    public TerraformProperty<double>? HoursBetweenBackups
    {
        get => GetProperty<TerraformProperty<double>>("hours_between_backups");
        set => this.WithProperty("hours_between_backups", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The repair_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RepairEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("repair_enabled");
        set => this.WithProperty("repair_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

}
