using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermChaosStudioCapabilityTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_chaos_studio_capability resource.
/// </summary>
public partial class AzurermChaosStudioCapability : TerraformResource
{
    public AzurermChaosStudioCapability(string name) : base("azurerm_chaos_studio_capability", name)
    {
    }

    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityType is required")]
    [TerraformProperty("capability_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapabilityType { get; set; }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    [TerraformProperty("chaos_studio_target_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ChaosStudioTargetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermChaosStudioCapabilityTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The urn attribute.
    /// </summary>
    [TerraformProperty("urn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Urn { get; }

}
