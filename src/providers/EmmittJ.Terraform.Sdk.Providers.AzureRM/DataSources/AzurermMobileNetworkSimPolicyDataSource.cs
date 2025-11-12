using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim_policy.
/// </summary>
public partial class AzurermMobileNetworkSimPolicyDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimPolicyDataSource(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [TerraformProperty("default_slice_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSliceId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformProperty("rat_frequency_selection_priority_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RatFrequencySelectionPriorityIndex { get; }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformProperty("registration_timer_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RegistrationTimerInSeconds { get; }

    /// <summary>
    /// The slice attribute.
    /// </summary>
    [TerraformProperty("slice")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Slice { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    [TerraformProperty("user_equipment_aggregate_maximum_bit_rate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserEquipmentAggregateMaximumBitRate { get; }

}
