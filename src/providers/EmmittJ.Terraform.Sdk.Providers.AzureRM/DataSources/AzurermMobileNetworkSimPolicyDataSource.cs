using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim_policy.
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimPolicyDataSource(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [TerraformPropertyName("default_slice_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSliceId => new TerraformReference(this, "default_slice_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformPropertyName("rat_frequency_selection_priority_index")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RatFrequencySelectionPriorityIndex => new TerraformReference(this, "rat_frequency_selection_priority_index");

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("registration_timer_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RegistrationTimerInSeconds => new TerraformReference(this, "registration_timer_in_seconds");

    /// <summary>
    /// The slice attribute.
    /// </summary>
    [TerraformPropertyName("slice")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Slice => new TerraformReference(this, "slice");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_aggregate_maximum_bit_rate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserEquipmentAggregateMaximumBitRate => new TerraformReference(this, "user_equipment_aggregate_maximum_bit_rate");

}
