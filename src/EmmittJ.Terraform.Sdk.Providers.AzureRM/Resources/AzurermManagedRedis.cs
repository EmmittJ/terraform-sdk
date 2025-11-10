using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformProperty<string> UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for default_database in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisDefaultDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AccessKeysAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("access_keys_authentication_enabled");
        set => WithProperty("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ClientProtocol
    {
        get => GetProperty<TerraformProperty<string>>("client_protocol");
        set => WithProperty("client_protocol", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ClusteringPolicy
    {
        get => GetProperty<TerraformProperty<string>>("clustering_policy");
        set => WithProperty("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The geo_replication_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GeoReplicationGroupName
    {
        get => GetProperty<TerraformProperty<string>>("geo_replication_group_name");
        set => WithProperty("geo_replication_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("primary_access_key");
        set => WithProperty("primary_access_key", value);
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("secondary_access_key");
        set => WithProperty("secondary_access_key", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedRedisIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

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
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedRedisTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_managed_redis resource.
/// </summary>
public class AzurermManagedRedis : TerraformResource
{
    public AzurermManagedRedis(string name) : base("azurerm_managed_redis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hostname");
    }

    /// <summary>
    /// The high_availability_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HighAvailabilityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("high_availability_enabled");
        set => this.WithProperty("high_availability_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
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
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermManagedRedisCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetProperty<List<AzurermManagedRedisCustomerManagedKeyBlock>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for default_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultDatabase block(s) allowed")]
    public List<AzurermManagedRedisDefaultDatabaseBlock>? DefaultDatabase
    {
        get => GetProperty<List<AzurermManagedRedisDefaultDatabaseBlock>>("default_database");
        set => this.WithProperty("default_database", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermManagedRedisIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermManagedRedisIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedRedisTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedRedisTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

}
