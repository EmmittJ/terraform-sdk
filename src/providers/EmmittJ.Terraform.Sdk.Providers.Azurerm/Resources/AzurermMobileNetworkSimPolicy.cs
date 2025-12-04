using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for slice in AzurermMobileNetworkSimPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicySliceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slice";

    /// <summary>
    /// The default_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultDataNetworkId is required")]
    public required TerraformValue<string> DefaultDataNetworkId
    {
        get => GetArgument<TerraformValue<string>>("default_data_network_id");
        set => SetArgument("default_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    public required TerraformValue<string> SliceId
    {
        get => GetArgument<TerraformValue<string>>("slice_id");
        set => SetArgument("slice_id", value);
    }

    /// <summary>
    /// DataNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataNetwork block(s) required")]
    public required TerraformList<AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlock> DataNetwork
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlock>>("data_network");
        set => SetArgument("data_network", value);
    }

}

/// <summary>
/// Block type for data_network in AzurermMobileNetworkSimPolicySliceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_network";

    /// <summary>
    /// The additional_allowed_session_types attribute.
    /// </summary>
    public TerraformList<string>? AdditionalAllowedSessionTypes
    {
        get => GetArgument<TerraformList<string>>("additional_allowed_session_types");
        set => SetArgument("additional_allowed_session_types", value);
    }

    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    public TerraformValue<double>? AllocationAndRetentionPriorityLevel
    {
        get => GetArgument<TerraformValue<double>>("allocation_and_retention_priority_level");
        set => SetArgument("allocation_and_retention_priority_level", value);
    }

    /// <summary>
    /// The allowed_services_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedServicesIds is required")]
    public TerraformList<string>? AllowedServicesIds
    {
        get => GetArgument<TerraformList<string>>("allowed_services_ids");
        set => SetArgument("allowed_services_ids", value);
    }

    /// <summary>
    /// The data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataNetworkId is required")]
    public required TerraformValue<string> DataNetworkId
    {
        get => GetArgument<TerraformValue<string>>("data_network_id");
        set => SetArgument("data_network_id", value);
    }

    /// <summary>
    /// The default_session_type attribute.
    /// </summary>
    public TerraformValue<string>? DefaultSessionType
    {
        get => GetArgument<TerraformValue<string>>("default_session_type");
        set => SetArgument("default_session_type", value);
    }

    /// <summary>
    /// The max_buffered_packets attribute.
    /// </summary>
    public TerraformValue<double>? MaxBufferedPackets
    {
        get => GetArgument<TerraformValue<double>>("max_buffered_packets");
        set => SetArgument("max_buffered_packets", value);
    }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    public TerraformValue<string>? PreemptionCapability
    {
        get => GetArgument<TerraformValue<string>>("preemption_capability");
        set => SetArgument("preemption_capability", value);
    }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    public TerraformValue<string>? PreemptionVulnerability
    {
        get => GetArgument<TerraformValue<string>>("preemption_vulnerability");
        set => SetArgument("preemption_vulnerability", value);
    }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QosIndicator is required")]
    public required TerraformValue<double> QosIndicator
    {
        get => GetArgument<TerraformValue<double>>("qos_indicator");
        set => SetArgument("qos_indicator", value);
    }

    /// <summary>
    /// SessionAggregateMaximumBitRate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionAggregateMaximumBitRate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SessionAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionAggregateMaximumBitRate block(s) allowed")]
    public required TerraformList<AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlockSessionAggregateMaximumBitRateBlock> SessionAggregateMaximumBitRate
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlockSessionAggregateMaximumBitRateBlock>>("session_aggregate_maximum_bit_rate");
        set => SetArgument("session_aggregate_maximum_bit_rate", value);
    }

}

/// <summary>
/// Block type for session_aggregate_maximum_bit_rate in AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicySliceBlockDataNetworkBlockSessionAggregateMaximumBitRateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "session_aggregate_maximum_bit_rate";

    /// <summary>
    /// The downlink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Downlink is required")]
    public required TerraformValue<string> Downlink
    {
        get => GetArgument<TerraformValue<string>>("downlink");
        set => SetArgument("downlink", value);
    }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    public required TerraformValue<string> Uplink
    {
        get => GetArgument<TerraformValue<string>>("uplink");
        set => SetArgument("uplink", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMobileNetworkSimPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_equipment_aggregate_maximum_bit_rate in AzurermMobileNetworkSimPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_equipment_aggregate_maximum_bit_rate";

    /// <summary>
    /// The downlink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Downlink is required")]
    public required TerraformValue<string> Downlink
    {
        get => GetArgument<TerraformValue<string>>("downlink");
        set => SetArgument("downlink", value);
    }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    public required TerraformValue<string> Uplink
    {
        get => GetArgument<TerraformValue<string>>("uplink");
        set => SetArgument("uplink", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_sim_policy Terraform resource.
/// Manages a azurerm_mobile_network_sim_policy resource.
/// </summary>
public partial class AzurermMobileNetworkSimPolicy(string name) : TerraformResource("azurerm_mobile_network_sim_policy", name)
{
    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSliceId is required")]
    public required TerraformValue<string> DefaultSliceId
    {
        get => GetArgument<TerraformValue<string>>("default_slice_id");
        set => SetArgument("default_slice_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => GetArgument<TerraformValue<string>>("mobile_network_id");
        set => SetArgument("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformValue<double>? RatFrequencySelectionPriorityIndex
    {
        get => GetArgument<TerraformValue<double>>("rat_frequency_selection_priority_index");
        set => SetArgument("rat_frequency_selection_priority_index", value);
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RegistrationTimerInSeconds
    {
        get => GetArgument<TerraformValue<double>>("registration_timer_in_seconds");
        set => SetArgument("registration_timer_in_seconds", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Slice block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Slice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Slice block(s) required")]
    public required TerraformList<AzurermMobileNetworkSimPolicySliceBlock> Slice
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkSimPolicySliceBlock>>("slice");
        set => SetArgument("slice", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkSimPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkSimPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserEquipmentAggregateMaximumBitRate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEquipmentAggregateMaximumBitRate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserEquipmentAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserEquipmentAggregateMaximumBitRate block(s) allowed")]
    public required TerraformList<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock> UserEquipmentAggregateMaximumBitRate
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock>>("user_equipment_aggregate_maximum_bit_rate");
        set => SetArgument("user_equipment_aggregate_maximum_bit_rate", value);
    }

}
