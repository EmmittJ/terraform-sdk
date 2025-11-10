using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_account_encryption.
/// </summary>
public class AzurermNetappAccountEncryptionDataSource : TerraformDataSource
{
    public AzurermNetappAccountEncryptionDataSource(string name) : base("azurerm_netapp_account_encryption", name)
    {
    }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappAccountEncryptionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cross_tenant_key_vault_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CrossTenantKeyVaultResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cross_tenant_key_vault_resource_id");

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_key");

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    [TerraformPropertyName("federated_client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FederatedClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "federated_client_id");

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    [TerraformPropertyName("system_assigned_identity_principal_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SystemAssignedIdentityPrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "system_assigned_identity_principal_id");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserAssignedIdentityId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_assigned_identity_id");

}
