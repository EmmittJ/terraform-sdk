using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterResourceTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_resource resource.
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterResource : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterResource(string name) : base("google_access_context_manager_service_perimeter_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerimeterName is required")]
    [TerraformProperty("perimeter_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PerimeterName { get; set; }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Resource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerServicePerimeterResourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessPolicyId { get; }

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of perimeter resources on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of resources. The resource to add or remove is merged into that list and then this etag is sent with the PATCH call along with the updated resource list.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}
