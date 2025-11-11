using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAvailabilitySetDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_availability_set.
/// </summary>
public class AzurermAvailabilitySetDataSource : TerraformDataSource
{
    public AzurermAvailabilitySetDataSource(string name) : base("azurerm_availability_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAvailabilitySetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [TerraformPropertyName("managed")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Managed => new TerraformReference(this, "managed");

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PlatformFaultDomainCount => new TerraformReference(this, "platform_fault_domain_count");

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_update_domain_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PlatformUpdateDomainCount => new TerraformReference(this, "platform_update_domain_count");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
