using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    [TerraformPropertyName("netapp_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetappAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappAccountEncryptionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cross_tenant_key_vault_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CrossTenantKeyVaultResourceId => new TerraformReference(this, "cross_tenant_key_vault_resource_id");

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionKey => new TerraformReference(this, "encryption_key");

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    [TerraformPropertyName("federated_client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FederatedClientId => new TerraformReference(this, "federated_client_id");

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    [TerraformPropertyName("system_assigned_identity_principal_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SystemAssignedIdentityPrincipalId => new TerraformReference(this, "system_assigned_identity_principal_id");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserAssignedIdentityId => new TerraformReference(this, "user_assigned_identity_id");

}
