using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_service.
/// </summary>
public partial class AzurermMobileNetworkServiceDataSource : TerraformDataSource
{
    public AzurermMobileNetworkServiceDataSource(string name) : base("azurerm_mobile_network_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformProperty("mobile_network_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMobileNetworkServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The pcc_rule attribute.
    /// </summary>
    [TerraformProperty("pcc_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PccRule { get; }

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    [TerraformProperty("service_precedence")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ServicePrecedence { get; }

    /// <summary>
    /// The service_qos_policy attribute.
    /// </summary>
    [TerraformProperty("service_qos_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceQosPolicy { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
