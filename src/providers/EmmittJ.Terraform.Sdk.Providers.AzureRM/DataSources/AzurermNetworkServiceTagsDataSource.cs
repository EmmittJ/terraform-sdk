using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkServiceTagsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_service_tags.
/// </summary>
public partial class AzurermNetworkServiceTagsDataSource : TerraformDataSource
{
    public AzurermNetworkServiceTagsDataSource(string name) : base("azurerm_network_service_tags", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    [TerraformProperty("location_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocationFilter { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkServiceTagsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AddressPrefixes { get; }

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    [TerraformProperty("ipv4_cidrs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Ipv4Cidrs { get; }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidrs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Ipv6Cidrs { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
