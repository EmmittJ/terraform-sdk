using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for slice in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkSimPolicySliceBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultDataNetworkId is required")]
    [TerraformProperty("default_data_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultDataNetworkId { get; set; }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    [TerraformProperty("slice_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SliceId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkSimPolicyTimeoutsBlock : TerraformBlockBase
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
/// Block type for user_equipment_aggregate_maximum_bit_rate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock : TerraformBlockBase
{
    /// <summary>
    /// The downlink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Downlink is required")]
    [TerraformProperty("downlink")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Downlink { get; set; }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    [TerraformProperty("uplink")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uplink { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_sim_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMobileNetworkSimPolicy : TerraformResource
{
    public AzurermMobileNetworkSimPolicy(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSliceId is required")]
    [TerraformProperty("default_slice_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultSliceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformProperty("mobile_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformProperty("rat_frequency_selection_priority_index")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RatFrequencySelectionPriorityIndex { get; set; }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformProperty("registration_timer_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RegistrationTimerInSeconds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for slice.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Slice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Slice block(s) required")]
    [TerraformProperty("slice")]
    public partial TerraformList<TerraformBlock<AzurermMobileNetworkSimPolicySliceBlock>>? Slice { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMobileNetworkSimPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_equipment_aggregate_maximum_bit_rate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEquipmentAggregateMaximumBitRate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserEquipmentAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserEquipmentAggregateMaximumBitRate block(s) allowed")]
    [TerraformProperty("user_equipment_aggregate_maximum_bit_rate")]
    public partial TerraformList<TerraformBlock<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock>>? UserEquipmentAggregateMaximumBitRate { get; set; }

}
