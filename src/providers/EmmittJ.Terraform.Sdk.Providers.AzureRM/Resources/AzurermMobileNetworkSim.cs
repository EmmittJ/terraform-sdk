using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for static_ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkSimStaticIpConfigurationBlock() : TerraformBlock("static_ip_configuration")
{
    /// <summary>
    /// The attached_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedDataNetworkId is required")]
    [TerraformProperty("attached_data_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttachedDataNetworkId { get; set; }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    [TerraformProperty("slice_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SliceId { get; set; }

    /// <summary>
    /// The static_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("static_ipv4_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StaticIpv4Address { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkSimTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_sim resource.
/// </summary>
public partial class AzurermMobileNetworkSim : TerraformResource
{
    public AzurermMobileNetworkSim(string name) : base("azurerm_mobile_network_sim", name)
    {
    }

    /// <summary>
    /// The authentication_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationKey is required")]
    [TerraformProperty("authentication_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationKey { get; set; }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformProperty("device_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegratedCircuitCardIdentifier is required")]
    [TerraformProperty("integrated_circuit_card_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntegratedCircuitCardIdentifier { get; set; }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternationalMobileSubscriberIdentity is required")]
    [TerraformProperty("international_mobile_subscriber_identity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InternationalMobileSubscriberIdentity { get; set; }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    [TerraformProperty("mobile_network_sim_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MobileNetworkSimGroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The operator_key_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorKeyCode is required")]
    [TerraformProperty("operator_key_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OperatorKeyCode { get; set; }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformProperty("sim_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SimPolicyId { get; set; }

    /// <summary>
    /// Block for static_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("static_ip_configuration")]
    public TerraformList<AzurermMobileNetworkSimStaticIpConfigurationBlock> StaticIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMobileNetworkSimTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformProperty("sim_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SimState { get; }

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("vendor_key_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VendorKeyFingerprint { get; }

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    [TerraformProperty("vendor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VendorName { get; }

}
