using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSharedVpcServiceProjectTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_shared_vpc_service_project resource.
/// </summary>
public class GoogleComputeSharedVpcServiceProject : TerraformResource
{
    public GoogleComputeSharedVpcServiceProject(string name) : base("google_compute_shared_vpc_service_project", name)
    {
    }

    /// <summary>
    /// The deletion policy for the shared VPC service. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProject is required")]
    [TerraformPropertyName("host_project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostProject { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProject is required")]
    [TerraformPropertyName("service_project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceProject { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeSharedVpcServiceProjectTimeoutsBlock>? Timeouts { get; set; } = new();

}
