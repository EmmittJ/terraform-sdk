using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppConfigurationKeyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_app_configuration_key resource.
/// </summary>
public partial class AzurermAppConfigurationKey : TerraformResource
{
    public AzurermAppConfigurationKey(string name) : base("azurerm_app_configuration_key", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformProperty("configuration_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationStoreId { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformProperty("locked")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Locked { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    [TerraformProperty("vault_key_reference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VaultKeyReference { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppConfigurationKeyTimeoutsBlock Timeouts { get; set; } = new();

}
