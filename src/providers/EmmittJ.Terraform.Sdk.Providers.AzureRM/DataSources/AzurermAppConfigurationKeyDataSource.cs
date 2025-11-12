using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppConfigurationKeyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration_key.
/// </summary>
public partial class AzurermAppConfigurationKeyDataSource : TerraformDataSource
{
    public AzurermAppConfigurationKeyDataSource(string name) : base("azurerm_app_configuration_key", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppConfigurationKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContentType { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformProperty("locked")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Locked { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Value { get; }

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    [TerraformProperty("vault_key_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VaultKeyReference { get; }

}
