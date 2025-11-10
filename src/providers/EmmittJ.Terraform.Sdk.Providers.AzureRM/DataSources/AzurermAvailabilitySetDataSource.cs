using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAvailabilitySetDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAvailabilitySetDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [TerraformPropertyName("managed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Managed => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "managed");

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PlatformFaultDomainCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "platform_fault_domain_count");

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_update_domain_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PlatformUpdateDomainCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "platform_update_domain_count");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
