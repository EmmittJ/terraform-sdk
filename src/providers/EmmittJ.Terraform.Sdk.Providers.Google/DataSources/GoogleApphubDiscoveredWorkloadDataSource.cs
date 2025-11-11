using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_discovered_workload.
/// </summary>
public partial class GoogleApphubDiscoveredWorkloadDataSource : TerraformDataSource
{
    public GoogleApphubDiscoveredWorkloadDataSource(string name) : base("google_apphub_discovered_workload", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadUri is required")]
    [TerraformProperty("workload_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkloadUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The workload_properties attribute.
    /// </summary>
    [TerraformProperty("workload_properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WorkloadProperties { get; }

    /// <summary>
    /// The workload_reference attribute.
    /// </summary>
    [TerraformProperty("workload_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WorkloadReference { get; }

}
