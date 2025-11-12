using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for diagnostic_storage_account in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubDeviceUpdateInstanceDiagnosticStorageAccountBlock() : TerraformBlock("diagnostic_storage_account")
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformProperty("connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionString { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubDeviceUpdateInstanceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_iothub_device_update_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermIothubDeviceUpdateInstance : TerraformResource
{
    public AzurermIothubDeviceUpdateInstance(string name) : base("azurerm_iothub_device_update_instance", name)
    {
    }

    /// <summary>
    /// The device_update_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceUpdateAccountId is required")]
    [TerraformProperty("device_update_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceUpdateAccountId { get; set; }

    /// <summary>
    /// The diagnostic_enabled attribute.
    /// </summary>
    [TerraformProperty("diagnostic_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DiagnosticEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformProperty("iothub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IothubId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for diagnostic_storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticStorageAccount block(s) allowed")]
    [TerraformProperty("diagnostic_storage_account")]
    public TerraformList<AzurermIothubDeviceUpdateInstanceDiagnosticStorageAccountBlock> DiagnosticStorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermIothubDeviceUpdateInstanceTimeoutsBlock Timeouts { get; set; } = new();

}
