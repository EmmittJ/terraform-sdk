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
        set => SetProperty("default_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    public required TerraformProperty<string> SliceId
    {
        set => SetProperty("slice_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("downlink", value);
    }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    public required TerraformProperty<string> Uplink
    {
        set => SetProperty("uplink", value);
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
        SetOutput("default_slice_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("mobile_network_id");
        SetOutput("name");
        SetOutput("rat_frequency_selection_priority_index");
        SetOutput("registration_timer_in_seconds");
        SetOutput("tags");
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSliceId is required")]
    public required TerraformProperty<string> DefaultSliceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_slice_id");
        set => SetProperty("default_slice_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_id");
        set => SetProperty("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformProperty<double> RatFrequencySelectionPriorityIndex
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rat_frequency_selection_priority_index");
        set => SetProperty("rat_frequency_selection_priority_index", value);
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> RegistrationTimerInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("registration_timer_in_seconds");
        set => SetProperty("registration_timer_in_seconds", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for slice.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Slice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Slice block(s) required")]
    public List<AzurermMobileNetworkSimPolicySliceBlock>? Slice
    {
        set => SetProperty("slice", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_equipment_aggregate_maximum_bit_rate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEquipmentAggregateMaximumBitRate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserEquipmentAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserEquipmentAggregateMaximumBitRate block(s) allowed")]
    public List<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock>? UserEquipmentAggregateMaximumBitRate
    {
        set => SetProperty("user_equipment_aggregate_maximum_bit_rate", value);
    }

}
