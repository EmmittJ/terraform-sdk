using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_netapp_account_encryption resource.
/// </summary>
public class AzurermNetappAccountEncryption : TerraformResource
{
    public AzurermNetappAccountEncryption(string name) : base("azurerm_netapp_account_encryption", name)
    {
    }

    /// <summary>
    /// The full resource ID of the cross-tenant key vault. Required when using federated_client_id for cross-tenant scenarios.
    /// </summary>
    [TerraformPropertyName("cross_tenant_key_vault_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CrossTenantKeyVaultResourceId { get; set; }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    [TerraformPropertyName("encryption_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EncryptionKey { get; set; }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    [TerraformPropertyName("federated_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FederatedClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    [TerraformPropertyName("netapp_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetappAccountId { get; set; }

    /// <summary>
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    [TerraformPropertyName("system_assigned_identity_principal_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemAssignedIdentityPrincipalId { get; set; }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappAccountEncryptionTimeoutsBlock>? Timeouts { get; set; } = new();

}
