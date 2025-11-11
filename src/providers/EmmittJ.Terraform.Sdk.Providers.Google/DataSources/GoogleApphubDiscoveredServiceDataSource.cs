using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_discovered_service.
/// </summary>
public partial class GoogleApphubDiscoveredServiceDataSource : TerraformDataSource
{
    public GoogleApphubDiscoveredServiceDataSource(string name) : base("google_apphub_discovered_service", name)
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
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformProperty("service_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The service_properties attribute.
    /// </summary>
    [TerraformProperty("service_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServiceProperties { get; }

    /// <summary>
    /// The service_reference attribute.
    /// </summary>
    [TerraformProperty("service_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServiceReference { get; }

}
