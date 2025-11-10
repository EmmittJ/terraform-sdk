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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    [TerraformPropertyName("best_routes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BestRoutes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "best_routes");

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    [TerraformPropertyName("best_routes_for_router")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BestRoutesForRouter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "best_routes_for_router");

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

}
