using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("identity_client_id");
        set => WithProperty("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_identifier");
        set => WithProperty("key_vault_key_identifier", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationIdentityBlock : TerraformBlock
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermAppConfigurationReplicaBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppConfiguration : TerraformResource
{
    public AzurermAppConfiguration(string name) : base("azurerm_app_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("endpoint");
        this.WithOutput("primary_read_key");
        this.WithOutput("primary_write_key");
        this.WithOutput("secondary_read_key");
        this.WithOutput("secondary_write_key");
    }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DataPlaneProxyAuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("data_plane_proxy_authentication_mode");
        set => this.WithProperty("data_plane_proxy_authentication_mode", value);
    }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataPlaneProxyPrivateLinkDelegationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_plane_proxy_private_link_delegation_enabled");
        set => this.WithProperty("data_plane_proxy_private_link_delegation_enabled", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
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
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PurgeProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("purge_protection_enabled");
        set => this.WithProperty("purge_protection_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? SoftDeleteRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("soft_delete_retention_days");
        set => this.WithProperty("soft_delete_retention_days", value);
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
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermAppConfigurationEncryptionBlock>? Encryption
    {
        get => GetProperty<List<AzurermAppConfigurationEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermAppConfigurationIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermAppConfigurationIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermAppConfigurationReplicaBlock>? Replica
    {
        get => GetProperty<HashSet<AzurermAppConfigurationReplicaBlock>>("replica");
        set => this.WithProperty("replica", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    public TerraformExpression PrimaryReadKey => this["primary_read_key"];

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    public TerraformExpression PrimaryWriteKey => this["primary_write_key"];

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    public TerraformExpression SecondaryReadKey => this["secondary_read_key"];

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    public TerraformExpression SecondaryWriteKey => this["secondary_write_key"];

}
