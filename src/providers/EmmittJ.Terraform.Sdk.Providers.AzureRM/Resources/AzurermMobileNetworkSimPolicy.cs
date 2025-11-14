using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for slice in .
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
    [TerraformArgument("default_data_network_id")]
    public required TerraformValue<string> DefaultDataNetworkId
    {
        get => new TerraformReference<string>(this, "default_data_network_id");
        set => SetArgument("default_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    [TerraformArgument("slice_id")]
    public required TerraformValue<string> SliceId
    {
        get => new TerraformReference<string>(this, "slice_id");
        set => SetArgument("slice_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for user_equipment_aggregate_maximum_bit_rate in .
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
    [TerraformArgument("downlink")]
    public required TerraformValue<string> Downlink
    {
        get => new TerraformReference<string>(this, "downlink");
        set => SetArgument("downlink", value);
    }

    /// <summary>
    /// The uplink attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uplink is required")]
    [TerraformArgument("uplink")]
    public required TerraformValue<string> Uplink
    {
        get => new TerraformReference<string>(this, "uplink");
        set => SetArgument("uplink", value);
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
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSliceId is required")]
    [TerraformArgument("default_slice_id")]
    public required TerraformValue<string> DefaultSliceId
    {
        get => new TerraformReference<string>(this, "default_slice_id");
        set => SetArgument("default_slice_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformArgument("mobile_network_id")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => new TerraformReference<string>(this, "mobile_network_id");
        set => SetArgument("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformArgument("rat_frequency_selection_priority_index")]
    public TerraformValue<double>? RatFrequencySelectionPriorityIndex
    {
        get => new TerraformReference<double>(this, "rat_frequency_selection_priority_index");
        set => SetArgument("rat_frequency_selection_priority_index", value);
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformArgument("registration_timer_in_seconds")]
    public TerraformValue<double>? RegistrationTimerInSeconds
    {
        get => new TerraformReference<double>(this, "registration_timer_in_seconds");
        set => SetArgument("registration_timer_in_seconds", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for slice.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Slice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Slice block(s) required")]
    [TerraformArgument("slice")]
    public required TerraformList<AzurermMobileNetworkSimPolicySliceBlock> Slice { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkSimPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_equipment_aggregate_maximum_bit_rate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEquipmentAggregateMaximumBitRate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserEquipmentAggregateMaximumBitRate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserEquipmentAggregateMaximumBitRate block(s) allowed")]
    [TerraformArgument("user_equipment_aggregate_maximum_bit_rate")]
    public required TerraformList<AzurermMobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRateBlock> UserEquipmentAggregateMaximumBitRate { get; set; } = new();

}
