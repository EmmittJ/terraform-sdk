using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityClientId { get; set; }

    /// <summary>
    /// The key_vault_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultKeyIdentifier { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermAppConfigurationReplicaBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>("", "endpoint");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_app_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppConfiguration : TerraformResource
{
    public AzurermAppConfiguration(string name) : base("azurerm_app_configuration", name)
    {
    }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_authentication_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataPlaneProxyAuthenticationMode { get; set; }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_private_link_delegation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataPlaneProxyPrivateLinkDelegationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("purge_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PurgeProtectionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("soft_delete_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SoftDeleteRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationEncryptionBlock>>? Encryption { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("replica")]
    public TerraformSet<TerraformBlock<AzurermAppConfigurationReplicaBlock>>? Replica { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrimaryReadKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary_read_key");

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrimaryWriteKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary_write_key");

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecondaryReadKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secondary_read_key");

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecondaryWriteKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secondary_write_key");

}
