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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraClusterTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cosmosdb_cassandra_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbCassandraCluster : TerraformResource
{
    public AzurermCosmosdbCassandraCluster(string name) : base("azurerm_cosmosdb_cassandra_cluster", name)
    {
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformArgument("authentication_method")]
    public TerraformValue<string>? AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    [TerraformArgument("client_certificate_pems")]
    public TerraformList<string>? ClientCertificatePems
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "client_certificate_pems").ResolveNodes(ctx));
        set => SetArgument("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdminPassword is required")]
    [TerraformArgument("default_admin_password")]
    public required TerraformValue<string> DefaultAdminPassword
    {
        get => new TerraformReference<string>(this, "default_admin_password");
        set => SetArgument("default_admin_password", value);
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
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    [TerraformArgument("external_gossip_certificate_pems")]
    public TerraformList<string>? ExternalGossipCertificatePems
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_gossip_certificate_pems").ResolveNodes(ctx));
        set => SetArgument("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("external_seed_node_ip_addresses")]
    public TerraformList<string>? ExternalSeedNodeIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_seed_node_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("external_seed_node_ip_addresses", value);
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    [TerraformArgument("hours_between_backups")]
    public TerraformValue<double>? HoursBetweenBackups
    {
        get => new TerraformReference<double>(this, "hours_between_backups");
        set => SetArgument("hours_between_backups", value);
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
    /// The repair_enabled attribute.
    /// </summary>
    [TerraformArgument("repair_enabled")]
    public TerraformValue<bool>? RepairEnabled
    {
        get => new TerraformReference<bool>(this, "repair_enabled");
        set => SetArgument("repair_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermCosmosdbCassandraClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbCassandraClusterTimeoutsBlock Timeouts { get; set; } = new();

}
