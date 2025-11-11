using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public partial class AzurermSecurityCenterSubscriptionPricingExtensionBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_extension_properties attribute.
    /// </summary>
    [TerraformProperty("additional_extension_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalExtensionProperties { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSecurityCenterSubscriptionPricingTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_security_center_subscription_pricing resource.
/// </summary>
public partial class AzurermSecurityCenterSubscriptionPricing : TerraformResource
{
    public AzurermSecurityCenterSubscriptionPricing(string name) : base("azurerm_security_center_subscription_pricing", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The subplan attribute.
    /// </summary>
    [TerraformProperty("subplan")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subplan { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("extension")]
    public partial TerraformSet<TerraformBlock<AzurermSecurityCenterSubscriptionPricingExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSecurityCenterSubscriptionPricingTimeoutsBlock>? Timeouts { get; set; }

}
