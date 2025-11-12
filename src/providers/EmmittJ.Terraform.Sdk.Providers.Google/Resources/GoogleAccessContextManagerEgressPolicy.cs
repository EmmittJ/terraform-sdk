using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerEgressPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_access_context_manager_egress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerEgressPolicy : TerraformResource
{
    public GoogleAccessContextManagerEgressPolicy(string name) : base("google_access_context_manager_egress_policy", name)
    {
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EgressPolicyName is required")]
    [TerraformProperty("egress_policy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EgressPolicyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Resource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleAccessContextManagerEgressPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessPolicyId { get; }

}
