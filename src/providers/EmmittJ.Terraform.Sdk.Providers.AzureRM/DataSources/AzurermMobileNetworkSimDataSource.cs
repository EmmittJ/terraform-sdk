using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    [TerraformPropertyName("mobile_network_sim_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MobileNetworkSimGroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSimDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformPropertyName("device_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeviceType => new TerraformReference(this, "device_type");

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [TerraformPropertyName("integrated_circuit_card_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IntegratedCircuitCardIdentifier => new TerraformReference(this, "integrated_circuit_card_identifier");

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [TerraformPropertyName("international_mobile_subscriber_identity")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternationalMobileSubscriberIdentity => new TerraformReference(this, "international_mobile_subscriber_identity");

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("sim_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SimPolicyId => new TerraformReference(this, "sim_policy_id");

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformPropertyName("sim_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SimState => new TerraformReference(this, "sim_state");

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("static_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StaticIpConfiguration => new TerraformReference(this, "static_ip_configuration");

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("vendor_key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VendorKeyFingerprint => new TerraformReference(this, "vendor_key_fingerprint");

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    [TerraformPropertyName("vendor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VendorName => new TerraformReference(this, "vendor_name");

}
