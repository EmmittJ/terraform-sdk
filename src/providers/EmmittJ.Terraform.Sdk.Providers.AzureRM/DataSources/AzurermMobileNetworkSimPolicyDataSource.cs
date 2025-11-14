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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkSimPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    [TerraformArgument("default_slice_id")]
    public TerraformValue<string> DefaultSliceId
    {
        get => new TerraformReference<string>(this, "default_slice_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    [TerraformArgument("rat_frequency_selection_priority_index")]
    public TerraformValue<double> RatFrequencySelectionPriorityIndex
    {
        get => new TerraformReference<double>(this, "rat_frequency_selection_priority_index");
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    [TerraformArgument("registration_timer_in_seconds")]
    public TerraformValue<double> RegistrationTimerInSeconds
    {
        get => new TerraformReference<double>(this, "registration_timer_in_seconds");
    }

    /// <summary>
    /// The slice attribute.
    /// </summary>
    [TerraformArgument("slice")]
    public TerraformList<object> Slice
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "slice").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    [TerraformArgument("user_equipment_aggregate_maximum_bit_rate")]
    public TerraformList<object> UserEquipmentAggregateMaximumBitRate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "user_equipment_aggregate_maximum_bit_rate").ResolveNodes(ctx));
    }

}
