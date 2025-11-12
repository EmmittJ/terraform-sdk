using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCognitiveAccountCustomerManagedKeyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_cognitive_account_customer_managed_key resource.
/// </summary>
public partial class AzurermCognitiveAccountCustomerManagedKey : TerraformResource
{
    public AzurermCognitiveAccountCustomerManagedKey(string name) : base("azurerm_cognitive_account_customer_managed_key", name)
    {
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    [TerraformProperty("cognitive_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CognitiveAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformProperty("identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityClientId { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformProperty("key_vault_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultKeyId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCognitiveAccountCustomerManagedKeyTimeoutsBlock Timeouts { get; set; } = new();

}
