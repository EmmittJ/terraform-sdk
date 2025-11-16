using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
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
/// Represents a azurerm_cosmosdb_cassandra_cluster Terraform resource.
/// Manages a azurerm_cosmosdb_cassandra_cluster resource.
/// </summary>
public partial class AzurermCosmosdbCassandraCluster(string name) : TerraformResource("azurerm_cosmosdb_cassandra_cluster", name)
{
    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    public TerraformList<string>? ClientCertificatePems
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "client_certificate_pems").ResolveNodes(ctx));
        set => SetArgument("client_certificate_pems", value);
    }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdminPassword is required")]
    public required TerraformValue<string> DefaultAdminPassword
    {
        get => new TerraformReference<string>(this, "default_admin_password");
        set => SetArgument("default_admin_password", value);
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
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    public TerraformList<string>? ExternalGossipCertificatePems
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_gossip_certificate_pems").ResolveNodes(ctx));
        set => SetArgument("external_gossip_certificate_pems", value);
    }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    public TerraformList<string>? ExternalSeedNodeIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_seed_node_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("external_seed_node_ip_addresses", value);
    }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    public TerraformValue<double>? HoursBetweenBackups
    {
        get => new TerraformReference<double>(this, "hours_between_backups");
        set => SetArgument("hours_between_backups", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The repair_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RepairEnabled
    {
        get => new TerraformReference<bool>(this, "repair_enabled");
        set => SetArgument("repair_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermCosmosdbCassandraClusterIdentityBlock? Identity
    {
        get => GetArgument<AzurermCosmosdbCassandraClusterIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbCassandraClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbCassandraClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
