using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeProjectDefaultNetworkTierTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a google_compute_project_default_network_tier resource.
/// </summary>
public partial class GoogleComputeProjectDefaultNetworkTier : TerraformResource
{
    public GoogleComputeProjectDefaultNetworkTier(string name) : base("google_compute_project_default_network_tier", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The default network tier to be configured for the project. This field can take the following values: PREMIUM or STANDARD.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    [TerraformProperty("network_tier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkTier { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeProjectDefaultNetworkTierTimeoutsBlock>? Timeouts { get; set; }

}
