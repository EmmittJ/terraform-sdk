using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for customer_managed_key in AzurermManagedRedis.
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformValue<string> UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for default_database in AzurermManagedRedis.
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisDefaultDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_database";

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AccessKeysAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("access_keys_authentication_enabled");
        set => SetArgument("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ClientProtocol
    {
        get => GetArgument<TerraformValue<string>>("client_protocol");
        set => SetArgument("client_protocol", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformValue<string>? ClusteringPolicy
    {
        get => GetArgument<TerraformValue<string>>("clustering_policy");
        set => SetArgument("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => GetArgument<TerraformValue<string>>("eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The geo_replication_group_name attribute.
    /// </summary>
    public TerraformValue<string>? GeoReplicationGroupName
    {
        get => GetArgument<TerraformValue<string>>("geo_replication_group_name");
        set => SetArgument("geo_replication_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// Module block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    public TerraformList<AzurermManagedRedisDefaultDatabaseBlockModuleBlock>? Module
    {
        get => GetArgument<TerraformList<AzurermManagedRedisDefaultDatabaseBlockModuleBlock>>("module");
        set => SetArgument("module", value);
    }

}

/// <summary>
/// Block type for module in AzurermManagedRedisDefaultDatabaseBlock.
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisDefaultDatabaseBlockModuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "module";

    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformValue<string>? Args
    {
        get => GetArgument<TerraformValue<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}


/// <summary>
/// Block type for identity in AzurermManagedRedis.
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermManagedRedis.
/// Nesting mode: single
/// </summary>
public class AzurermManagedRedisTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_managed_redis Terraform resource.
/// Manages a azurerm_managed_redis resource.
/// </summary>
public partial class AzurermManagedRedis(string name) : TerraformResource("azurerm_managed_redis", name)
{
    /// <summary>
    /// The high_availability_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HighAvailabilityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("high_availability_enabled");
        set => SetArgument("high_availability_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermManagedRedisCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermManagedRedisCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// DefaultDatabase block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultDatabase block(s) allowed")]
    public TerraformList<AzurermManagedRedisDefaultDatabaseBlock>? DefaultDatabase
    {
        get => GetArgument<TerraformList<AzurermManagedRedisDefaultDatabaseBlock>>("default_database");
        set => SetArgument("default_database", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermManagedRedisIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermManagedRedisIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedRedisTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedRedisTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
