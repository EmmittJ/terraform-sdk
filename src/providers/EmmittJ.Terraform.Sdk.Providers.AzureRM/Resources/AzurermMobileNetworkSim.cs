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
/// Block type for static_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimStaticIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_ip_configuration";

    /// <summary>
    /// The attached_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedDataNetworkId is required")]
    [TerraformArgument("attached_data_network_id")]
    public required TerraformValue<string> AttachedDataNetworkId
    {
        get => new TerraformReference<string>(this, "attached_data_network_id");
        set => SetArgument("attached_data_network_id", value);
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

    /// <summary>
    /// The static_ipv4_address attribute.
    /// </summary>
    [TerraformArgument("static_ipv4_address")]
    public TerraformValue<string>? StaticIpv4Address
    {
        get => new TerraformReference<string>(this, "static_ipv4_address");
        set => SetArgument("static_ipv4_address", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mobile_network_sim resource.
/// </summary>
public class AzurermMobileNetworkSim : TerraformResource
{
    public AzurermMobileNetworkSim(string name) : base("azurerm_mobile_network_sim", name)
    {
    }

    /// <summary>
    /// The authentication_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationKey is required")]
    [TerraformArgument("authentication_key")]
    public required TerraformValue<string> AuthenticationKey
    {
        get => new TerraformReference<string>(this, "authentication_key");
        set => SetArgument("authentication_key", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformArgument("device_type")]
    public TerraformValue<string>? DeviceType
    {
        get => new TerraformReference<string>(this, "device_type");
        set => SetArgument("device_type", value);
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
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegratedCircuitCardIdentifier is required")]
    [TerraformArgument("integrated_circuit_card_identifier")]
    public required TerraformValue<string> IntegratedCircuitCardIdentifier
    {
        get => new TerraformReference<string>(this, "integrated_circuit_card_identifier");
        set => SetArgument("integrated_circuit_card_identifier", value);
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternationalMobileSubscriberIdentity is required")]
    [TerraformArgument("international_mobile_subscriber_identity")]
    public required TerraformValue<string> InternationalMobileSubscriberIdentity
    {
        get => new TerraformReference<string>(this, "international_mobile_subscriber_identity");
        set => SetArgument("international_mobile_subscriber_identity", value);
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
    /// The operator_key_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorKeyCode is required")]
    [TerraformArgument("operator_key_code")]
    public required TerraformValue<string> OperatorKeyCode
    {
        get => new TerraformReference<string>(this, "operator_key_code");
        set => SetArgument("operator_key_code", value);
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformArgument("sim_policy_id")]
    public TerraformValue<string>? SimPolicyId
    {
        get => new TerraformReference<string>(this, "sim_policy_id");
        set => SetArgument("sim_policy_id", value);
    }

    /// <summary>
    /// Block for static_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("static_ip_configuration")]
    public TerraformList<AzurermMobileNetworkSimStaticIpConfigurationBlock> StaticIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkSimTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformArgument("sim_state")]
    public TerraformValue<string> SimState
    {
        get => new TerraformReference<string>(this, "sim_state");
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
