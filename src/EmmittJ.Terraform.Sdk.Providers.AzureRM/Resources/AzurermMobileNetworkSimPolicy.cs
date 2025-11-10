using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for slice in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicySliceBlock : TerraformBlock
{
    /// <summary>
    /// The default_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultDataNetworkId is required")]
    public required TerraformProperty<string> DefaultDataNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("default_data_network_id");
        set => WithProperty("default_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    public required TerraformProperty<string> SliceId
    {
        get => GetProperty<TerraformProperty<string>>("slice_id");
        set => WithProperty("slice_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for user_equipment_aggregate_maximum_bit_rate in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock : TerraformBlock
{
    /// <summary>
    /// The downlink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Downlink is required")]
    public required TerraformProperty<string> Downlink
    {
        get => GetProperty<TerraformProperty<string>>("downlink");
        set => WithProperty("downlink", value);
    }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    public required TerraformProperty<string> Uplink
    {
        get => GetProperty<TerraformProperty<string>>("uplink");
        set => WithProperty("uplink", value);
    }

}

/// <summary>
/// Manages a azurerm_mobile_network_sim_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkSimPolicy : TerraformResource
{
    public AzurermMobileNetworkSimPolicy(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSliceId is required")]
    public required TerraformProperty<string> DefaultSliceId
    {
        get => GetProperty<TerraformProperty<string>>("default_slice_id");
        set => this.WithProperty("default_slice_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformProperty<double>? RatFrequencySelectionPriorityIndex
    {
        get => GetProperty<TerraformProperty<double>>("rat_frequency_selection_priority_index");
        set => this.WithProperty("rat_frequency_selection_priority_index", value);
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RegistrationTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("registration_timer_in_seconds");
        set => this.WithProperty("registration_timer_in_seconds", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for slice.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Slice block(s) required")]
    public List<AzurermMobileNetworkSimPolicySliceBlock>? Slice
    {
        get => GetProperty<List<AzurermMobileNetworkSimPolicySliceBlock>>("slice");
        set => this.WithProperty("slice", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkSimPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_equipment_aggregate_maximum_bit_rate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserEquipmentAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserEquipmentAggregateMaximumBitRate block(s) allowed")]
    public List<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock>? UserEquipmentAggregateMaximumBitRate
    {
        get => GetProperty<List<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock>>("user_equipment_aggregate_maximum_bit_rate");
        set => this.WithProperty("user_equipment_aggregate_maximum_bit_rate", value);
    }

}
