using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    [TerraformPropertyName("mobile_network_sim_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MobileNetworkSimGroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSimDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformPropertyName("device_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "device_type");

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [TerraformPropertyName("integrated_circuit_card_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IntegratedCircuitCardIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "integrated_circuit_card_identifier");

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [TerraformPropertyName("international_mobile_subscriber_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternationalMobileSubscriberIdentity => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "international_mobile_subscriber_identity");

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("sim_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SimPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sim_policy_id");

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformPropertyName("sim_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SimState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sim_state");

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("static_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StaticIpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "static_ip_configuration");

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("vendor_key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VendorKeyFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vendor_key_fingerprint");

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    [TerraformPropertyName("vendor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VendorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vendor_name");

}
