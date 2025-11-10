using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim_policy.
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimPolicyDataSource(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_slice_id");
        SetOutput("location");
        SetOutput("rat_frequency_selection_priority_index");
        SetOutput("registration_timer_in_seconds");
        SetOutput("slice");
        SetOutput("tags");
        SetOutput("user_equipment_aggregate_maximum_bit_rate");
        SetOutput("id");
        SetOutput("mobile_network_id");
        SetOutput("name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    public TerraformExpression DefaultSliceId => this["default_slice_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformExpression RatFrequencySelectionPriorityIndex => this["rat_frequency_selection_priority_index"];

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformExpression RegistrationTimerInSeconds => this["registration_timer_in_seconds"];

    /// <summary>
    /// The slice attribute.
    /// </summary>
    public TerraformExpression Slice => this["slice"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    public TerraformExpression UserEquipmentAggregateMaximumBitRate => this["user_equipment_aggregate_maximum_bit_rate"];

}
