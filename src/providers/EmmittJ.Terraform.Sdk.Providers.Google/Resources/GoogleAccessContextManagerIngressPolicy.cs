using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerIngressPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_access_context_manager_ingress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerIngressPolicy : TerraformResource
{
    public GoogleAccessContextManagerIngressPolicy(string name) : base("google_access_context_manager_ingress_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressPolicyName is required")]
    [TerraformProperty("ingress_policy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IngressPolicyName { get; set; }

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
    public partial TerraformBlock<GoogleAccessContextManagerIngressPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessPolicyId { get; }

}
