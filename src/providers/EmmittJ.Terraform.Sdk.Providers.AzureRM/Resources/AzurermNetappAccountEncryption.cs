using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappAccountEncryptionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_netapp_account_encryption resource.
/// </summary>
public partial class AzurermNetappAccountEncryption : TerraformResource
{
    public AzurermNetappAccountEncryption(string name) : base("azurerm_netapp_account_encryption", name)
    {
    }

    /// <summary>
    /// The full resource ID of the cross-tenant key vault. Required when using federated_client_id for cross-tenant scenarios.
    /// </summary>
    [TerraformProperty("cross_tenant_key_vault_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CrossTenantKeyVaultResourceId { get; set; }

    /// <summary>
    /// The versionless encryption key url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    [TerraformProperty("encryption_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EncryptionKey { get; set; }

    /// <summary>
    /// The Client ID of the multi-tenant Entra ID application used to access cross-tenant key vaults.
    /// </summary>
    [TerraformProperty("federated_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FederatedClientId { get; set; }

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
    /// The Principal ID of the System Assigned Identity to use for encryption.
    /// </summary>
    [TerraformProperty("system_assigned_identity_principal_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SystemAssignedIdentityPrincipalId { get; set; }

    /// <summary>
    /// The resource ID of the User Assigned Identity to use for encryption.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetappAccountEncryptionTimeoutsBlock Timeouts { get; set; } = new();

}
