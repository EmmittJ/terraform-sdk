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
public class AzurermMobileNetworkSimDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_mobile_network_sim.
/// </summary>
public class AzurermMobileNetworkSimDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimDataSource(string name) : base("azurerm_mobile_network_sim", name)
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
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    [TerraformArgument("mobile_network_sim_group_id")]
    public required TerraformValue<string> MobileNetworkSimGroupId
    {
        get => new TerraformReference<string>(this, "mobile_network_sim_group_id");
        set => SetArgument("mobile_network_sim_group_id", value);
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
    public AzurermMobileNetworkSimDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformArgument("device_type")]
    public TerraformValue<string> DeviceType
    {
        get => new TerraformReference<string>(this, "device_type");
    }

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [TerraformArgument("integrated_circuit_card_identifier")]
    public TerraformValue<string> IntegratedCircuitCardIdentifier
    {
        get => new TerraformReference<string>(this, "integrated_circuit_card_identifier");
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [TerraformArgument("international_mobile_subscriber_identity")]
    public TerraformValue<string> InternationalMobileSubscriberIdentity
    {
        get => new TerraformReference<string>(this, "international_mobile_subscriber_identity");
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformArgument("sim_policy_id")]
    public TerraformValue<string> SimPolicyId
    {
        get => new TerraformReference<string>(this, "sim_policy_id");
    }

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformArgument("sim_state")]
    public TerraformValue<string> SimState
    {
        get => new TerraformReference<string>(this, "sim_state");
    }

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    [TerraformArgument("static_ip_configuration")]
    public TerraformList<object> StaticIpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "static_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    [TerraformArgument("vendor_key_fingerprint")]
    public TerraformValue<string> VendorKeyFingerprint
    {
        get => new TerraformReference<string>(this, "vendor_key_fingerprint");
    }

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    [TerraformArgument("vendor_name")]
    public TerraformValue<string> VendorName
    {
        get => new TerraformReference<string>(this, "vendor_name");
    }

}
