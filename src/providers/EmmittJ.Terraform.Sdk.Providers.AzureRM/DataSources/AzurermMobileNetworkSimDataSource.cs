using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkSimDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim.
/// </summary>
public partial class AzurermMobileNetworkSimDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimDataSource(string name) : base("azurerm_mobile_network_sim", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMobileNetworkSimDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    [TerraformProperty("device_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeviceType { get; }

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [TerraformProperty("integrated_circuit_card_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IntegratedCircuitCardIdentifier { get; }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [TerraformProperty("international_mobile_subscriber_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InternationalMobileSubscriberIdentity { get; }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    [TerraformProperty("sim_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SimPolicyId { get; }

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    [TerraformProperty("sim_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SimState { get; }

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("static_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StaticIpConfiguration { get; }

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
