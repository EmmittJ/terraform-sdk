using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_app_service_slot_custom_hostname_binding resource.
/// </summary>
public partial class AzurermAppServiceSlotCustomHostnameBinding : TerraformResource
{
    public AzurermAppServiceSlotCustomHostnameBinding(string name) : base("azurerm_app_service_slot_custom_hostname_binding", name)
    {
    }

    /// <summary>
    /// The app_service_slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceSlotId is required")]
    [TerraformProperty("app_service_slot_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppServiceSlotId { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    [TerraformProperty("ssl_state")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SslState { get; set; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Thumbprint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    [TerraformProperty("virtual_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualIp { get; }

}
