using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkSimPolicyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_sim_policy Terraform data source.
/// Retrieves information about a azurerm_mobile_network_sim_policy.
/// </summary>
public partial class AzurermMobileNetworkSimPolicyDataSource(string name) : TerraformDataSource("azurerm_mobile_network_sim_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mobile_network_id");
        set => SetArgument("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultSliceId
        => AsReference("default_slice_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformValue<double> RatFrequencySelectionPriorityIndex
        => AsReference("rat_frequency_selection_priority_index");

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> RegistrationTimerInSeconds
        => AsReference("registration_timer_in_seconds");

    /// <summary>
    /// The slice attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Slice
        => AsReference("slice");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserEquipmentAggregateMaximumBitRate
        => AsReference("user_equipment_aggregate_maximum_bit_rate");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
