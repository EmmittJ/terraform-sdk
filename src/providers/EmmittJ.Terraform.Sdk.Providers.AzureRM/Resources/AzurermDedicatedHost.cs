using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDedicatedHostTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_dedicated_host resource.
/// </summary>
public partial class AzurermDedicatedHost : TerraformResource
{
    public AzurermDedicatedHost(string name) : base("azurerm_dedicated_host", name)
    {
    }

    /// <summary>
    /// The auto_replace_on_failure attribute.
    /// </summary>
    [TerraformProperty("auto_replace_on_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoReplaceOnFailure { get; set; }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostGroupId is required")]
    [TerraformProperty("dedicated_host_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DedicatedHostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomain is required")]
    [TerraformProperty("platform_fault_domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> PlatformFaultDomain { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDedicatedHostTimeoutsBlock Timeouts { get; set; } = new();

}
