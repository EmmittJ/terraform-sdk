using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for terms in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRouterRoutePolicyTermsBlock : TerraformBlockBase
{
    /// <summary>
    /// The evaluation priority for this term, which must be between 0 (inclusive) and 231 (exclusive), and unique within the list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRouterRoutePolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_router_route_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRouterRoutePolicy : TerraformResource
{
    public GoogleComputeRouterRoutePolicy(string name) : base("google_compute_router_route_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the route policy. This policy&#39;s name, which must be a resource ID segment and unique within all policies owned by the Router
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the router and NAT reside.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name of the Cloud Router in which this route policy will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformProperty("router")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Router { get; set; }

    /// <summary>
    /// This is policy&#39;s type, which is one of IMPORT or EXPORT Possible values: [&amp;quot;ROUTE_POLICY_TYPE_IMPORT&amp;quot;, &amp;quot;ROUTE_POLICY_TYPE_EXPORT&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for terms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Terms is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Terms block(s) required")]
    [TerraformProperty("terms")]
    public TerraformList<TerraformBlock<GoogleComputeRouterRoutePolicyTermsBlock>>? Terms { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRouterRoutePolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

}
