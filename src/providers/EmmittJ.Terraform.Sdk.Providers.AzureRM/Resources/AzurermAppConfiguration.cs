using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppConfigurationEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformProperty("identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityClientId { get; set; }

    /// <summary>
    /// The key_vault_key_identifier attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultKeyIdentifier { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppConfigurationIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public partial class AzurermAppConfigurationReplicaBlock : TerraformBlockBase
{


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_app_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAppConfiguration : TerraformResource
{
    public AzurermAppConfiguration(string name) : base("azurerm_app_configuration", name)
    {
    }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformProperty("data_plane_proxy_authentication_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataPlaneProxyAuthenticationMode { get; set; }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformProperty("data_plane_proxy_private_link_delegation_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DataPlaneProxyPrivateLinkDelegationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("purge_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PurgeProtectionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformProperty("soft_delete_retention_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SoftDeleteRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationEncryptionBlock>>? Encryption { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("replica")]
    public TerraformSet<TerraformBlock<AzurermAppConfigurationReplicaBlock>>? Replica { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformProperty("primary_read_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrimaryReadKey { get; }

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformProperty("primary_write_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrimaryWriteKey { get; }

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformProperty("secondary_read_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecondaryReadKey { get; }

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformProperty("secondary_write_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecondaryWriteKey { get; }

}
