using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for static_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimStaticIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The attached_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedDataNetworkId is required")]
    [TerraformPropertyName("attached_data_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AttachedDataNetworkId { get; set; }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    [TerraformPropertyName("slice_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SliceId { get; set; }

    /// <summary>
    /// The static_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("static_ipv4_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StaticIpv4Address { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("authentication_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthenticationKey { get; set; }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformPropertyName("device_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegratedCircuitCardIdentifier is required")]
    [TerraformPropertyName("integrated_circuit_card_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IntegratedCircuitCardIdentifier { get; set; }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternationalMobileSubscriberIdentity is required")]
    [TerraformPropertyName("international_mobile_subscriber_identity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InternationalMobileSubscriberIdentity { get; set; }

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
    /// The operator_key_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorKeyCode is required")]
    [TerraformPropertyName("operator_key_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OperatorKeyCode { get; set; }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("sim_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SimPolicyId { get; set; }

    /// <summary>
    /// Block for static_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("static_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkSimStaticIpConfigurationBlock>>? StaticIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkSimTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformPropertyName("sim_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SimState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sim_state");

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
