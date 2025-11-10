using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_test_virtual_network.
/// </summary>
public class AzurermDevTestVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermDevTestVirtualNetworkDataSource(string name) : base("azurerm_dev_test_virtual_network", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    [TerraformPropertyName("lab_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LabName { get; set; }

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
    public TerraformBlock<AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allowed_subnets attribute.
    /// </summary>
    [TerraformPropertyName("allowed_subnets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AllowedSubnets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "allowed_subnets");

    /// <summary>
    /// The subnet_overrides attribute.
    /// </summary>
    [TerraformPropertyName("subnet_overrides")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SubnetOverrides => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "subnet_overrides");

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformPropertyName("unique_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_identifier");

}
