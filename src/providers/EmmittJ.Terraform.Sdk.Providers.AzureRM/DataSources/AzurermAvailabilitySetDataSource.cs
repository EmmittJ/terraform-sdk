using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAvailabilitySetDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_availability_set.
/// </summary>
public partial class AzurermAvailabilitySetDataSource : TerraformDataSource
{
    public AzurermAvailabilitySetDataSource(string name) : base("azurerm_availability_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAvailabilitySetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [TerraformProperty("managed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Managed { get; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformProperty("platform_fault_domain_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PlatformFaultDomainCount { get; }

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    [TerraformProperty("platform_update_domain_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PlatformUpdateDomainCount { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
