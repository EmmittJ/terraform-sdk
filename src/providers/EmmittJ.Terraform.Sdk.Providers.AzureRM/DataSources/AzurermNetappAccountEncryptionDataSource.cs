using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappAccountEncryptionDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_account_encryption.
/// </summary>
public partial class AzurermNetappAccountEncryptionDataSource : TerraformDataSource
{
    public AzurermNetappAccountEncryptionDataSource(string name) : base("azurerm_netapp_account_encryption", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the NetApp Account where encryption will be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappAccountId is required")]
    [TerraformProperty("netapp_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetappAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetappAccountEncryptionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cross_tenant_key_vault_resource_id attribute.
    /// </summary>
    [TerraformProperty("cross_tenant_key_vault_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CrossTenantKeyVaultResourceId { get; }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformProperty("encryption_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionKey { get; }

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    [TerraformProperty("federated_client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FederatedClientId { get; }

    /// <summary>
    /// The system_assigned_identity_principal_id attribute.
    /// </summary>
    [TerraformProperty("system_assigned_identity_principal_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SystemAssignedIdentityPrincipalId { get; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserAssignedIdentityId { get; }

}
