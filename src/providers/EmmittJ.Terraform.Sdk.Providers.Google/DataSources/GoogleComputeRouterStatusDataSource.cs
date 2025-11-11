using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router_status.
/// </summary>
public class GoogleComputeRouterStatusDataSource : TerraformDataSource
{
    public GoogleComputeRouterStatusDataSource(string name) : base("google_compute_router_status", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    [TerraformPropertyName("best_routes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BestRoutes => new TerraformReference(this, "best_routes");

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    [TerraformPropertyName("best_routes_for_router")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BestRoutesForRouter => new TerraformReference(this, "best_routes_for_router");

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

}
