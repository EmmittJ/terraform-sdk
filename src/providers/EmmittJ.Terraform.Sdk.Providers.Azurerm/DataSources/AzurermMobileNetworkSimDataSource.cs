using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkSimDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_sim Terraform data source.
/// Retrieves information about a azurerm_mobile_network_sim.
/// </summary>
public partial class AzurermMobileNetworkSimDataSource(string name) : TerraformDataSource("azurerm_mobile_network_sim", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    public required TerraformValue<string> MobileNetworkSimGroupId
    {
        get => new TerraformReference<string>(this, "mobile_network_sim_group_id");
        set => SetArgument("mobile_network_sim_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformValue<string> DeviceType
    {
        get => new TerraformReference<string>(this, "device_type");
    }

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public TerraformValue<string> IntegratedCircuitCardIdentifier
    {
        get => new TerraformReference<string>(this, "integrated_circuit_card_identifier");
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public TerraformValue<string> InternationalMobileSubscriberIdentity
    {
        get => new TerraformReference<string>(this, "international_mobile_subscriber_identity");
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformValue<string> SimPolicyId
    {
        get => new TerraformReference<string>(this, "sim_policy_id");
    }

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    public TerraformValue<string> SimState
    {
        get => new TerraformReference<string>(this, "sim_state");
    }

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StaticIpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "static_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> VendorKeyFingerprint
    {
        get => new TerraformReference<string>(this, "vendor_key_fingerprint");
    }

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    public TerraformValue<string> VendorName
    {
        get => new TerraformReference<string>(this, "vendor_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkSimDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkSimDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
