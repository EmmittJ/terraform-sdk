using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlServerTransparentDataEncryptionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_mssql_server_transparent_data_encryption resource.
/// </summary>
public partial class AzurermMssqlServerTransparentDataEncryption : TerraformResource
{
    public AzurermMssqlServerTransparentDataEncryption(string name) : base("azurerm_mssql_server_transparent_data_encryption", name)
    {
    }

    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_rotation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoRotationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlServerTransparentDataEncryptionTimeoutsBlock Timeouts { get; set; } = new();

}
