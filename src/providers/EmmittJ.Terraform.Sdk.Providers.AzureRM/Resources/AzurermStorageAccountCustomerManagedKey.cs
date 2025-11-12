using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountCustomerManagedKeyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_account_customer_managed_key resource.
/// </summary>
public partial class AzurermStorageAccountCustomerManagedKey : TerraformResource
{
    public AzurermStorageAccountCustomerManagedKey(string name) : base("azurerm_storage_account_customer_managed_key", name)
    {
    }

    /// <summary>
    /// The federated_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("federated_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FederatedIdentityClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    [TerraformProperty("key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultId { get; set; }

    /// <summary>
    /// The key_vault_uri attribute.
    /// </summary>
    [TerraformProperty("key_vault_uri")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultUri { get; set; }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    [TerraformProperty("key_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVersion { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageAccountCustomerManagedKeyTimeoutsBlock Timeouts { get; set; } = new();

}
