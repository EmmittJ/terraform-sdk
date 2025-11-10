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
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        SetOutput("authentication_method");
        SetOutput("client_certificate_pems");
        SetOutput("default_admin_password");
        SetOutput("delegated_management_subnet_id");
        SetOutput("external_gossip_certificate_pems");
        SetOutput("external_seed_node_ip_addresses");
        SetOutput("hours_between_backups");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("repair_enabled");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("version");
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_method");
        set => SetProperty("authentication_method", value);
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    public List<TerraformProperty<string>> ClientCertificatePems
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("client_certificate_pems");
        set => SetProperty("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdminPassword is required")]
    public required TerraformProperty<string> DefaultAdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_admin_password");
        set => SetProperty("default_admin_password", value);
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
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public List<TerraformProperty<string>> ExternalGossipCertificatePems
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("external_gossip_certificate_pems");
        set => SetProperty("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>> ExternalSeedNodeIpAddresses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("external_seed_node_ip_addresses");
        set => SetProperty("external_seed_node_ip_addresses", value);
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    public TerraformProperty<double> HoursBetweenBackups
    {
        get => GetRequiredOutput<TerraformProperty<double>>("hours_between_backups");
        set => SetProperty("hours_between_backups", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The repair_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RepairEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("repair_enabled");
        set => SetProperty("repair_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermCosmosdbCassandraClusterIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbCassandraClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
