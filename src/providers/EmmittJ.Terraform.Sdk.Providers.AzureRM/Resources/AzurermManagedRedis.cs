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
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformProperty<string> UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ClientProtocol
    {
        set => SetProperty("client_protocol", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ClusteringPolicy
    {
        set => SetProperty("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        set => SetProperty("eviction_policy", value);
    }

    /// <summary>
    /// The geo_replication_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GeoReplicationGroupName
    {
        set => SetProperty("geo_replication_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryAccessKey
    {
        set => SetProperty("primary_access_key", value);
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryAccessKey
    {
        set => SetProperty("secondary_access_key", value);
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
        set => SetProperty("identity_ids", value);
    }

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
public class AzurermManagedRedisTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_managed_redis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermManagedRedis : TerraformResource
{
    public AzurermManagedRedis(string name) : base("azurerm_managed_redis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("hostname");
        SetOutput("high_availability_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The high_availability_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HighAvailabilityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("high_availability_enabled");
        set => SetProperty("high_availability_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
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
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermManagedRedisCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for default_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultDatabase block(s) allowed")]
    public List<AzurermManagedRedisDefaultDatabaseBlock>? DefaultDatabase
    {
        set => SetProperty("default_database", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermManagedRedisIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedRedisTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

}
