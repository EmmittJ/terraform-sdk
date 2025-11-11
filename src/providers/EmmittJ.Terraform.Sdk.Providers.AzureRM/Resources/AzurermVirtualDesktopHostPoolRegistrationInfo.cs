using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_host_pool_registration_info resource.
/// </summary>
public partial class AzurermVirtualDesktopHostPoolRegistrationInfo : TerraformResource
{
    public AzurermVirtualDesktopHostPoolRegistrationInfo(string name) : base("azurerm_virtual_desktop_host_pool_registration_info", name)
    {
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationDate is required")]
    [TerraformProperty("expiration_date")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExpirationDate { get; set; }

    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    [TerraformProperty("hostpool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostpoolId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformProperty("token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Token { get; }

}
