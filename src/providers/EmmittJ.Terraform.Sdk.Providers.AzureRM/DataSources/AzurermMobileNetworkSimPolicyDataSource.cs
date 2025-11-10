using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformPropertyName("mobile_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [TerraformPropertyName("default_slice_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSliceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_slice_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformPropertyName("rat_frequency_selection_priority_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RatFrequencySelectionPriorityIndex => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "rat_frequency_selection_priority_index");

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("registration_timer_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RegistrationTimerInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "registration_timer_in_seconds");

    /// <summary>
    /// The slice attribute.
    /// </summary>
    [TerraformPropertyName("slice")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Slice => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "slice");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_aggregate_maximum_bit_rate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserEquipmentAggregateMaximumBitRate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_equipment_aggregate_maximum_bit_rate");

}
