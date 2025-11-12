using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeSharedVpcServiceProjectTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_compute_shared_vpc_service_project resource.
/// </summary>
public partial class GoogleComputeSharedVpcServiceProject : TerraformResource
{
    public GoogleComputeSharedVpcServiceProject(string name) : base("google_compute_shared_vpc_service_project", name)
    {
    }

    /// <summary>
    /// The deletion policy for the shared VPC service. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProject is required")]
    [TerraformProperty("host_project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostProject { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProject is required")]
    [TerraformProperty("service_project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceProject { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeSharedVpcServiceProjectTimeoutsBlock Timeouts { get; set; } = new();

}
