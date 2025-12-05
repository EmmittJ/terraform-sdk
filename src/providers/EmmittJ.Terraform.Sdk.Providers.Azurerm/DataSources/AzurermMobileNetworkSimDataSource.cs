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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    public required TerraformValue<string> MobileNetworkSimGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mobile_network_sim_group_id");
        set => SetArgument("mobile_network_sim_group_id", value);
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
    /// The device_type attribute.
    /// </summary>
    public TerraformValue<string> DeviceType
        => CreateReference("device_type");

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public TerraformValue<string> IntegratedCircuitCardIdentifier
        => CreateReference("integrated_circuit_card_identifier");

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public TerraformValue<string> InternationalMobileSubscriberIdentity
        => CreateReference("international_mobile_subscriber_identity");

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformValue<string> SimPolicyId
        => CreateReference("sim_policy_id");

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    public TerraformValue<string> SimState
        => CreateReference("sim_state");

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StaticIpConfiguration
        => CreateReference("static_ip_configuration");

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> VendorKeyFingerprint
        => CreateReference("vendor_key_fingerprint");

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    public TerraformValue<string> VendorName
        => CreateReference("vendor_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkSimDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkSimDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
