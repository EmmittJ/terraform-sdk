using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for single_network_slice_selection_assistance_information in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock
{
    /// <summary>
    /// The slice_differentiator attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("slice_differentiator")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SliceDifferentiator { get; set; }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceServiceType is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("slice_service_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> SliceServiceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSliceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_slice resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkSlice : TerraformResource
{
    public AzurermMobileNetworkSlice(string name) : base("azurerm_mobile_network_slice", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformPropertyName("mobile_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The slice_differentiator attribute.
    /// </summary>
    [TerraformPropertyName("slice_differentiator")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SliceDifferentiator { get; set; } = default!;

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [TerraformPropertyName("slice_service_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SliceServiceType { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for single_network_slice_selection_assistance_information.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleNetworkSliceSelectionAssistanceInformation block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("single_network_slice_selection_assistance_information")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock>>? SingleNetworkSliceSelectionAssistanceInformation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSliceTimeoutsBlock>? Timeouts { get; set; }

}
