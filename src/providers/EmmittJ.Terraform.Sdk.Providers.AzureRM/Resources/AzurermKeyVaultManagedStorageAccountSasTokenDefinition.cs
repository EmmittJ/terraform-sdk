using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_key_vault_managed_storage_account_sas_token_definition resource.
/// </summary>
public partial class AzurermKeyVaultManagedStorageAccountSasTokenDefinition : TerraformResource
{
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinition(string name) : base("azurerm_key_vault_managed_storage_account_sas_token_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedStorageAccountId is required")]
    [TerraformProperty("managed_storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedStorageAccountId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The sas_template_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasTemplateUri is required")]
    [TerraformProperty("sas_template_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SasTemplateUri { get; set; }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasType is required")]
    [TerraformProperty("sas_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SasType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The validity_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityPeriod is required")]
    [TerraformProperty("validity_period")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ValidityPeriod { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformProperty("secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretId { get; }

}
