using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSecurityCenterContactTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_security_center_contact resource.
/// </summary>
public partial class AzurermSecurityCenterContact : TerraformResource
{
    public AzurermSecurityCenterContact(string name) : base("azurerm_security_center_contact", name)
    {
    }

    /// <summary>
    /// The alert_notifications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertNotifications is required")]
    [TerraformProperty("alert_notifications")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AlertNotifications { get; set; }

    /// <summary>
    /// The alerts_to_admins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertsToAdmins is required")]
    [TerraformProperty("alerts_to_admins")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AlertsToAdmins { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    [TerraformProperty("phone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Phone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSecurityCenterContactTimeoutsBlock Timeouts { get; set; } = new();

}
