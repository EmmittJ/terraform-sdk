using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public List<TerraformProperty<string>>? ClientCertificatePems
    {
        get => GetProperty<List<TerraformProperty<string>>>("client_certificate_pems");
        set => this.WithProperty("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdminPassword is required")]
    public required TerraformProperty<string> DefaultAdminPassword
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_admin_password");
        set => this.WithProperty("default_admin_password", value);
    }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    public required TerraformProperty<string> DelegatedManagementSubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("delegated_management_subnet_id");
        set => this.WithProperty("delegated_management_subnet_id", value);
    }

    /// <summary>
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExternalGossipCertificatePems
    {
        get => GetProperty<List<TerraformProperty<string>>>("external_gossip_certificate_pems");
        set => this.WithProperty("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExternalSeedNodeIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("external_seed_node_ip_addresses");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermCosmosdbCassandraClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermCosmosdbCassandraClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbCassandraClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbCassandraClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
