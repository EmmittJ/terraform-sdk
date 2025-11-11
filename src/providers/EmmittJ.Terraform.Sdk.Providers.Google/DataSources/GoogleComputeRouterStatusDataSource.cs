using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router_status.
/// </summary>
public partial class GoogleComputeRouterStatusDataSource : TerraformDataSource
{
    public GoogleComputeRouterStatusDataSource(string name) : base("google_compute_router_status", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    [TerraformProperty("best_routes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BestRoutes { get; }

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    [TerraformProperty("best_routes_for_router")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BestRoutesForRouter { get; }

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Network { get; }

}
